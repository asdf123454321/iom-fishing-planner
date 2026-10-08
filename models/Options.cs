using CommandLine;

namespace FishingPlanner.Models;

public class Options
{
    [Option('g', "goal", Required = false, HelpText = "Specify goal. Options: None (default), Cards, LegendaryCards")]
    public Goal Goal { get; set; } = Goal.None;

    [Option('t', "tier", Required = false, HelpText = "Specify tier. Options: All (default), Tier1, Tier2")]
    public Tier Tier { get; set; } = Tier.All;

    [Option('p', "priority", Required = false, HelpText = "Specify priority. Options: Easiest (default), Hardest, Equality")]
    public Priority Priority { get; set; } = Priority.Easiest;

    [Option('s', "stats", Required = false, HelpText = "Path to exportstats.json (default: current directory)")]
    public string Stats { get; set; } = "exportstats.json";

    [Option('i', "ignore-fisher", Required = false, HelpText = "Ignore fisher when optimizing placements")]
    public bool IgnoreFisher { get; set; } = false;

    [Option('d', "drone-count", Required = false, HelpText = "Override drone count when optimizing placements")]
    public int? DroneCount { get; set; } = null;
}
