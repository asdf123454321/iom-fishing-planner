using System.Text.Json;
using FishingPlanner.Data;

namespace FishingPlanner.Services;

public static class DataLoader
{
    public static (Stats Stats, State[] DockStates) Load(string exportStatsPath)
    {
        var stats = ReadJson<ExportStats>(exportStatsPath, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }).Stats;
        var boatLevel = stats.TierOneBoatLevel + stats.TierTwoBoatLevel;
        var docks = DockCatalog.All
            .Where(dock => boatLevel >= dock.BoatsRequired)
            .ToArray();
        var eligibleDockNames = docks.Select(dock => dock.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var fish = FishCatalog.All
            .Where(item => eligibleDockNames.Contains(item.Dock))
            .ToArray();

        var dockStates = docks
            .Select(d => new State(d, fish.Where(f => f.Dock.EqualsIgnoreCase(d.Name)).ToArray()))
            .ToArray();

        return (stats, dockStates);
    }

    private static T ReadJson<T>(string path, JsonSerializerOptions options)
    {
        if (!File.Exists(path)) throw new FileNotFoundException("Required data file was not found.", path);

        return JsonSerializer.Deserialize<T>(File.ReadAllText(path), options) ?? throw new InvalidDataException($"Could not parse {Path.GetFileName(path)}.");
    }
}