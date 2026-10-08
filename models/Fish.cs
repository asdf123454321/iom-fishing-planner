namespace FishingPlanner.Models;

public class Fish(string id, string name, string description, string dock, int power, int cardIndex)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public string Dock { get; set; } = dock;
    public int Power { get; set; } = power;
    public int Index { get; set; } = cardIndex;
}
