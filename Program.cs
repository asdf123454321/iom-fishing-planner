using System.Text;
using CommandLine;
using FishingPlanner.Services;

try
{
    var options = Parser.Default.ParseArguments<Options>(args).Value;

    var (stats, states) = DataLoader.Load(options.Stats);

    var mechanicMath = new MechanicMath(stats, options);
    var placementOptimizer = new PlacementOptimizer(mechanicMath, stats, options, states);

    placementOptimizer.Optimize();

    // Header
    Console.WriteLine($"Goal: {options.Goal}, Tier: {options.Tier}, Priority: {options.Priority}");
    var headerRow = new StringBuilder();
    var maxFishCount = states.Max(state => state.Fish.Length);
    headerRow.Append($"{"Dock", -8} {"Fisher", 7} {"Drones", 7}");
    for (var fishNum = 1; fishNum <= maxFishCount; fishNum++)
    {
        headerRow.Append($" {"Fish #" + fishNum, -32}");
    }
    headerRow.Append($" {"Legend", 10}");
    Console.WriteLine(headerRow.ToString());

    // Rows
    foreach (var state in states)
    {
        var effectivePower = mechanicMath.GetEffectivePower(state);
        var lastFish = state.Fish[^1];

        var row = new StringBuilder();

        var fishers = state.FisherCount == 0 ? "-" : "✔";
        var drones = state.DroneCount == 0 ? "-" : state.DroneCount.FormatCompact();
        row.Append($"{state.Dock.Name, -8} {fishers, 7} {drones, 7}");

        for (var fishIndex = 0; fishIndex < maxFishCount; fishIndex++)
        {
            if (fishIndex >= state.Fish.Length)
            {
                row.Append($" {string.Empty, -30}");
                continue;
            }

            var fishEntry = state.Fish[fishIndex];
            var catchPercent = mechanicMath.GetCatchesPerAction(effectivePower, fishEntry.Power) * 100;
            var fishDisplay = catchPercent == 0 ? "-" : $"{fishEntry.Name} ({catchPercent.FormatPercent()})";
            row.Append($" {fishDisplay, -32}");
        }

        var legendaryNumerator = (int)mechanicMath.GetCatchesPerAction(effectivePower, lastFish.Power);
        var legendaryDenominator = mechanicMath.GetLegendaryCardDenominator();
        var legendaryChance = legendaryNumerator == 0 ? "-" : $"{legendaryNumerator}/{legendaryDenominator.FormatCompact(0)}";
        row.Append($" {legendaryChance, 10}");

        Console.WriteLine(row.ToString());
    }

    var unassignedDrones = (options.DroneCount ?? stats.FishingDroneCapacity) - states.Sum(state => state.DroneCount);
    if (unassignedDrones > 0)
    {
        Console.WriteLine($"Unassigned drones: {unassignedDrones.FormatCompact()}");
    }

    return 0;
}
catch (Exception exception)
{
    Console.Error.WriteLine($"Error: {exception.Message}");
    return 1;
}
