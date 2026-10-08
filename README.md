# Idle Obelisk Miner Fishing Allocation Optimizer

This project aims to optimize the allocation of fishing resources in the Idle Obelisk Miner game. By analyzing the game's mechanics and player strategies, the tool suggests the most efficient way to allocate fishing resources to maximize profits.

## How to Use

### Prerequisites
- .NET 10 Runtime
- Run EXPORTSTATS code in the game and paste the results into the `exportstats.json` file

### Installation
1. Clone this repository to your local machine.
2. Install the required dependencies using the .NET CLI:
   ```sh
   dotnet restore
   ```

### Running the Project
1. Navigate to the project directory.
2. Run the main script with the desired parameters:
   ```sh
   dotnet run --goal [equality|cards|legendary-cards] --tier [all|1|2] --priority [equality|easiest|hardest] --stats <path-to-exportstats.json>
   ```

### Parameters
- `--goal <goal>`: The optimization goal. Options are `equality`, `cards`, and `legendary-cards`.
- `--tier <scope>`: The scope for the equality goal. Options are `all`, `1`, and `2`.
- `--priority <priority>`: The card priority. Options are `equality`, `easiest`, and `hardest`.
- `--stats <path-to-exportstats.json>`: Path to the `exportstats.json` file. Default is the current directory.

### Examples
1. Optimize for equality (all tiers):
   ```sh
   dotnet run --goal equality --stats exportstats.json
   ```

2. Optimize for the easiest cards (tier 2):
   ```sh
   dotnet run --goal cards --tier 2 --priority easiest --stats exportstats.json
   ```

3. Optimize for legendary cards (equality goal, tier 1):
   ```sh
   dotnet run --goal legendary-cards --tier 1 --priority equality --stats exportstats.json
   ```
