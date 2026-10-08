namespace FishingPlanner.Models;

public class Dock(string name, int tier, int baseTicks, int boatsRequired, int index)
{
    public string Name { get; set; } = name;
    public int Tier { get; set; } = tier;
    public int BaseTicks { get; set; } = baseTicks;
    public int BoatsRequired { get; set; } = boatsRequired;
    public int Index { get; set; } = index;
}