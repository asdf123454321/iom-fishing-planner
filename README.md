# Idle Obelisk Miner Fishing Allocation Optimizer

This project aims to optimize the allocation of fishing resources in the Idle Obelisk Miner game. By analyzing the game's mechanics and player strategies, the tool suggests the most efficient way to allocate fishing resources to maximize profits.

## How to Use

### Prerequisites
- .NET 10 Runtime
- Run EXPORTSTATS code in the game and paste the results into the `exportstats.json` file

### Installation
1. Clone this repository to your local machine.
1. Install the required dependencies using the .NET CLI:
   ```sh
   dotnet restore
   ```

### Running the Project
1. Navigate to the project directory.
1. Run the main script with the desired parameters:
   ```sh
   dotnet run --goal [Equality|Cards|LegendaryCards] --tier [All|Tier1|Tier2] --priority [Equality|Easiest|Hardest] --ignore-fisher --drone-count <###> --stats <path-to-exportstats.json>
   ```

### Parameters
  - `-g`, `--goal`: Specify goal. Options: None (default), Cards, LegendaryCards
  - `-t`, `--tier`: Specify tier. Options: All (default), Tier1, Tier2
  - `-p`, `--priority`: Specify priority. Options: Easiest (default), Hardest, Equality
  - `-s`, `--stats`: Path to exportstats.json (default: current directory)
  - `-i`, `--ignore-fisher`: Ignore fisher when optimizing placements
  - `-d`, `--drone-count`: Override drone count when optimizing placements
  - `--help`: Display this help screen.

### Examples
1. Run default options (no goal, all tiers, easiest first) with stats directory:
   ```sh
   ./FishingPlanner.exe -s "C:\\Users\\username\\Documents\\exportstats.json"
   ```

1. Optimize for the easiest cards (tier 2):
   ```sh
   ./FishingPlanner.exe -g Cards -t Tier2 -p Easiest
   ```

1. Optimize for easiest legendary cards in tier 1:
   ```sh
   ./FishingPlanner.exe -g LegendaryCards -t Tier1 -p Equality
   ```

1. Optimize for leftovers. Place no fisher and 150 drones on tier 1 for equality:
   ```sh
   ./FishingPlanner.exe -t Tier1 -p Equality -i -d 150
   ```
