namespace FishingPlanner.Models;

public sealed class State(Dock dock, Fish[] fish)
{
    public Dock Dock { get; } = dock;
    public Fish[] Fish { get; } = fish;
    public int FisherCount { get; set; }
    public int DroneCount { get; set; }

    public Fish LastFish => Fish[^1] ?? throw new Exception($"No fish found for state dockIndex={Dock.Index}.");
}