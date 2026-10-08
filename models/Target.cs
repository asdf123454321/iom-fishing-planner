namespace FishingPlanner.Models;

public record Target(Dock Dock, IEnumerable<Fish> Fish)
{
    public Fish LastFish => Fish.LastOrDefault() ?? throw new Exception($"No fish found for target dockIndex={Dock.Index}.");
}
