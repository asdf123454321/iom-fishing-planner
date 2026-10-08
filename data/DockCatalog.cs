using FishingPlanner.Services;

namespace FishingPlanner.Data;

public class DockCatalog
{
    public static Dock? GetByIndex(int index) => All.FirstOrDefault(d => d.Index == index) ?? throw new Exception($"Dock not found with index {index}");
    
    public static Dock? GetByName(string name) => All.FirstOrDefault(d => d.Name.EqualsIgnoreCase(name)) ?? throw new Exception($"Dock not found with name {name}");

    public static Dock[] All = [
        new ("Lake", 1, 5, 0, 0),
        new ("Desert", 1, 8, 1, 1),
        new ("Tundra", 1, 12, 2, 2),
        new ("Ocean", 1, 16, 3, 3),
        new ("Nuclear", 1, 22, 4, 4),
        new ("Abyss", 1, 30, 5, 5),
        new ("Cave", 2, 40, 6, 6),
        new ("Volcano", 2, 50, 7, 7),
        new ("Sky", 2, 60, 8, 8),
        new ("Solaris", 2, 70, 9, 9),
        new ("Galaxy", 2, 80, 10, 10),
    ];
}
