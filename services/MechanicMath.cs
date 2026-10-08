using FishingPlanner.Data;

namespace FishingPlanner.Services;

public class MechanicMath(Stats stats, Options options)
{
    public const double MaximumCatchOdds = 9.99;
    public const double MaximumLegendaryCatchOdds = 9;

    public const double LegendaryCatchDenominatorBase = 150_000;

    public const double RegularCatchT1StandardDenominatorBase = 1_500;
    public const double RegularCatchT1PolyDenominatorBase = 15_000;
    public const double RegularCatchT1InfernalDenominator = 100_000_000_000;

    public const double RegularCatchT2StandardDenominatorBase = 150_000;
    public const double RegularCatchT2PolyDenominatorBase = 1_500_000;
    public const double RegularCatchT2InfernalDenominator = 200_000_000_000;

    public double GetEffectivePower(State state) => GetEffectivePower(state.Dock.Tier, state.FisherCount, state.DroneCount);

    public double GetEffectivePower(int tier, int fishers, int drones)
    {
        var rawPower = fishers * stats.FishingRodPower + drones * stats.DronePower;
        var multiplier = tier == 2 ? stats.FishingTier2DockMulti : 1;

        return rawPower * multiplier;
    }

    public double GetCatchesPerAction(double effectivePower, double fishPower, double ceiling = MaximumCatchOdds)
    {
        return Math.Min(Math.Round(effectivePower / fishPower, 2, MidpointRounding.AwayFromZero), ceiling);
    }

    public (double FisherResultsPerTick, double DroneResultsPerTick) CalculateResultsPerTick(Target t, double ceiling)
    {
        var ticks = GetDockTicks(t.Dock);
        var cardOdds = options.Goal switch
        {
            Goal.LegendaryCards => GetLegendaryCardDenominator(),
            Goal.Cards => GetRegularCardDenominator(t.LastFish),
            Goal.None or _ => 1
        };
        // Fisher.
        var fisherPower = GetEffectivePower(t.Dock.Tier, 1, 0);
        var fisherCatchesPerAction = GetCatchesPerAction(fisherPower, t.LastFish.Power, ceiling);
        // Drones.
        var dronePower = GetEffectivePower(t.Dock.Tier, 0, 1);
        var droneCatchesPerAction = GetCatchesPerAction(dronePower, t.LastFish.Power, ceiling);

        return (
            FisherResultsPerTick: fisherCatchesPerAction / cardOdds / ticks,
            DroneResultsPerTick: droneCatchesPerAction / cardOdds / ticks
        );
    }

    public double CalculateEffectiveResultsPerTick(State state, (double FisherResultsPerTick, double DroneResultsPerTick) results)
    {
        return state.FisherCount * results.FisherResultsPerTick + state.DroneCount * results.DroneResultsPerTick;
    }

    public double GetLegendaryCardDenominator()
    {
        return stats.IsDroneAnglerEquippedAndFueled
            ? LegendaryCatchDenominatorBase / (1.02 + stats.AnglerFuelGrade * 0.02)
            : LegendaryCatchDenominatorBase;
    }

    public double GetRegularCardDenominator(Fish fish)
    {
        var dock = DockCatalog.GetByName(fish.Dock);
        var cardLevel = stats.FishingRegularCardArray[fish.Index];

        return (dock.Tier, cardLevel) switch
        {
            (1, 0) => RegularCatchT1StandardDenominatorBase * Math.Pow(1.1, fish.Index),
            (1, 2) => RegularCatchT1PolyDenominatorBase * Math.Pow(1.1, fish.Index),
            (1, 3) => RegularCatchT1InfernalDenominator,
            (2, 0) => RegularCatchT2StandardDenominatorBase * Math.Pow(1.1, fish.Index),
            (2, 2) => RegularCatchT2PolyDenominatorBase * Math.Pow(1.1, fish.Index),
            (2, 3) => RegularCatchT2InfernalDenominator,
            _ => -1
        };
    }

    public double GetExpectedCatch(Fish fish)
    {
        var cardLevel = stats.FishingRegularCardArray[fish.Index];

        double allMulti = stats.FishingIncomeMulti;
        double shinyMulti = stats.FishingShinyChance / 100 * stats.FishingShinyMulti;
        double superShinyMulti = stats.FishingShinyChance / 100 * stats.FishingSuperShinyChance / 100 * stats.FishingSuperShinyMulti;
        
        double polychromeMulti = (1 + stats.PolyCardMultiUpgradeLevel * 0.08) * (1 + stats.PolyCardMultiEnhanceLevel * 0.1); // approximate calculation because EXPORTSTATS doesn't include polychrome potency bundle
        double infernalMulti = stats.InfernalCardMulti * (1 + stats.FishingRegularCardArray.Count(c => c == 4) * 0.085); // approximate calculation because EXPORTSTATS doesn't include other cards.

        return allMulti * shinyMulti * superShinyMulti * cardLevel switch
        {
            1 => 1.5,
            2 => 2.0,
            3 => 4.0 * polychromeMulti,
            4 => 4.0 * polychromeMulti * infernalMulti,
            _ => 1
        };
    }
    
    public bool IsRegularCardCompleteForNow(int index)
    {
        var cardLevel = stats.FishingRegularCardArray[index];
        bool isInfernalUnlocked = stats.LavaithanTributeLevel >= 3;

        return (isInfernalUnlocked && cardLevel >= 4) || (!isInfernalUnlocked && cardLevel >= 3) || cardLevel == 1;
    }

    public bool IsLegendaryCardCompleteForNow(int index)
    {
        var cardLevel = stats.FishingLegendaryCardLevelsArray[index];
        bool isInfernalUnlocked = stats.LavaithanTributeLevel >= 3;

        return (isInfernalUnlocked && cardLevel >= 4) || (!isInfernalUnlocked && cardLevel >= 3) || cardLevel == 1;
    }

    public double GetDockTicks(Dock dock)
    {
        // Motley School skill reduces Abyss dock by 2 per level and tier 2 docks by 1 per level
        // Tier Two Dock Tick Reduction enhancement reduces tier 2 docks by 1 per level
        double flatReduction = dock.Tier switch {
            1 when dock.Name == "Abyss" => stats.MotleySchoolLevel * 2,
            2 => stats.MotleySchoolLevel + stats.TierTwoDockTickReductionLevel,
            _ => 0
        };
        // Cthulu Tribute 1 is a 10% reduction in ticks.
        double percentReduction = stats.CthuluTributeLevel >= 2 ? 0.9 : 1;

        return Math.Floor((dock.BaseTicks - flatReduction) * percentReduction);
    }
    
    public int CalculateDronesToReachCeiling(int tier, double fishPower, int fishers, double ceiling)
    {
        var neededPower = fishPower * ceiling;
        var fisherPower = fishers * stats.FishingRodPower;
        var multiplier = tier == 2 ? stats.FishingTier2DockMulti : 1;

        int dronesNeeded = (int)Math.Ceiling((neededPower - fisherPower * multiplier) / (stats.DronePower * multiplier));

        return Math.Max(dronesNeeded, 0);
    }

    public int GetDronesToNextTier(State state)
    {
        if (options.Goal is Goal.None or Goal.Cards) // Each drone improves catch rate or card odds.
        {
            return 1;
        }
        else
        {
            var effectivePower = GetEffectivePower(state);
            var expectedCatchRate = GetCatchesPerAction(effectivePower, state.LastFish.Power, MaximumLegendaryCatchOdds);
            var nextCeiling = Math.Floor(expectedCatchRate) + 1;

            int neededDrones = CalculateDronesToReachCeiling(state.Dock.Tier, state.LastFish.Power, state.FisherCount, nextCeiling);

            return neededDrones - state.DroneCount;
        }
    }
}