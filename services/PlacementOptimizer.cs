using System.Net.Sockets;

namespace FishingPlanner.Services;

public class PlacementOptimizer(MechanicMath mechanicMath, Stats stats, Options options, State[] states)
{
    public void Optimize()
    {
        var (fishers, drones, ceiling) = GetAvailableResources();
        var targets = GetAvailableTargets();

        if (!targets.Any())
        {
            throw new InvalidOperationException($"There are no valid targets for goal={options.Goal}, tier={options.Tier}.");
        }

        // Assign fisher.
        if (fishers > 0)
        {
            int dockIndex = GetNoWasteFisherDockIndex(targets, ceiling);
            states[dockIndex].FisherCount = 1;
        }

        // Assign drones.
        if (options.Priority is Priority.Easiest or Priority.Hardest)
        {
            CalculateOrdered(targets, drones, ceiling);
        }
        else
        {
            CalculateEquality(targets, drones, ceiling);
        }
    }

    private (int fishers, int drones, double ceiling) GetAvailableResources()
    {
        var fishers = options.IgnoreFisher ? 0 : 1;
        var drones = options.DroneCount ?? (int)stats.FishingDroneCapacity;
        var ceiling = options.Goal == Goal.LegendaryCards ? MechanicMath.MaximumLegendaryCatchOdds : MechanicMath.MaximumCatchOdds;

        return (fishers, drones, ceiling);
    }

    private IEnumerable<Target> GetAvailableTargets()
    {
        // Filter cards.
        var targets = options.Goal switch
        {
            Goal.None => states
                .Select(s => new Target(s.Dock, s.Fish)),
            Goal.Cards => states
                .Select(s => new Target(s.Dock, s.Fish.Where(f => !mechanicMath.IsRegularCardCompleteForNow(f.Index))))
                .Where(t => t.Fish.Any()),
            Goal.LegendaryCards => states
                .Select(s => new Target(s.Dock, s.Fish))
                .Where(s => !mechanicMath.IsLegendaryCardCompleteForNow(s.Dock.Index)),
            _ => []
        };

        // Handle tier filter.
        if (options.Tier != Tier.All)
        {
            targets = targets.Where(t => (options.Tier == Tier.Tier1 && t.Dock.Tier == 1) || (options.Tier == Tier.Tier2 && t.Dock.Tier == 2));
        }

        // Handle priority order.
        if (options.Priority == Priority.Hardest)
        {
            targets = targets.Reverse();
        }

        return targets;
    }

    private int GetNoWasteFisherDockIndex(IEnumerable<Target> targets, double ceiling)
    {
        Target? idealTarget = null;
        
        // For ordered placements, prioritize first target that does not waste fisher power.
        if (options.Priority is Priority.Easiest or Priority.Hardest)
        {
            idealTarget = targets
                .FirstOrDefault(t => {
                    var fisherPower = stats.FishingRodPower * (t.Dock.Tier == 2 ? stats.FishingTier2DockMulti : 1);
                    var catchesPerAction = mechanicMath.GetCatchesPerAction(fisherPower, t.LastFish.Power, ceiling);
                    return catchesPerAction < ceiling;
                }, null);
        }
        
        // If all targets waste fisher power or priority is equality, prioritize the hardest target.
        idealTarget ??= targets.OrderByDescending(s => s.LastFish.Power).First();

        return idealTarget.Dock.Index;
    }
    
    private void CalculateOrdered(IEnumerable<Target> targets, int drones, double ceiling)
    {
        foreach (var target in targets)
        {
            if (drones == 0) break;

            var state = states[target.Dock.Index];
            var fishPower = target.Fish.Last().Power;

            var dronesNeeded = mechanicMath.CalculateDronesToReachCeiling(state.Dock.Tier, fishPower, state.FisherCount, ceiling);

            if (dronesNeeded > drones)
            {
                // For legendary cards, if all drones were used before hitting max, walk back to the highest available tier.
                if (options.Goal == Goal.LegendaryCards)
                {
                    var effectivePower = mechanicMath.GetEffectivePower(target.Dock.Tier, state.FisherCount, drones);
                    var previousCeiling = Math.Floor(mechanicMath.GetCatchesPerAction(effectivePower, fishPower, ceiling));

                    dronesNeeded = mechanicMath.CalculateDronesToReachCeiling(target.Dock.Tier, fishPower, state.FisherCount, previousCeiling);
                }
                // For everything else, just use the rest of the drones.
                else
                {
                    dronesNeeded = drones;
                }
            }

            state.DroneCount = dronesNeeded;
            drones -= dronesNeeded;
        }
    }

    private void CalculateEquality(IEnumerable<Target> targets, int drones, double ceiling)
    {
        // Create a map of dock index to expected results per tick.
        var expectedResults = targets.ToDictionary(t => t.Dock.Index, t => mechanicMath.CalculateResultsPerTick(t, ceiling));

        // Legendary cards are a nightmare due to the Floor(x / 100) style calculation. Here's my best attempt at combined logic.
        while (drones > 0)
        {
            // Order results by current least expected results.
            var (state, dronesToNextTier, _, _) = expectedResults
                .Select(kvp => {
                    var state = states[kvp.Key];
                    return (
                        state,
                        dronesToNextTier: mechanicMath.GetDronesToNextTier(state),
                        effectiveResultsPerTick: mechanicMath.CalculateEffectiveResultsPerTick(state, kvp.Value),
                        catchesPerAction: mechanicMath.GetCatchesPerAction(mechanicMath.GetEffectivePower(state), state.LastFish.Power, ceiling) 
                    );
                })
                .Where(v => v.catchesPerAction < ceiling) // where dock is not maxed out
                .OrderBy(v => v.effectiveResultsPerTick) // order by lowest powered dock
                .FirstOrDefault(v => v.dronesToNextTier <= drones);

            if (state is null) break;
            
            state.DroneCount += dronesToNextTier;
            drones -= dronesToNextTier;
        }
    }
}