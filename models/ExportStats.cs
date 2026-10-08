using System.Text.Json.Serialization;

namespace FishingPlanner.Models;

public class ExportStats
{
    [JsonPropertyName("time")]
    public double Time { get; set; }
    [JsonPropertyName("stats")]
    public Stats Stats { get; set; } = new();
    [JsonPropertyName("version")]
    public string Version { get; set; } = "";
}

public class Stats
{
    // ==========================================
    // LOOTBUGS & LOOTFROGS
    // ==========================================
    [JsonPropertyName("lootbug_loot_multi")]
    public double LootbugLootMulti { get; set; }
    [JsonPropertyName("lootbug_spawn_rate")]
    public double LootbugSpawnRate { get; set; }
    [JsonPropertyName("lootbug_triple_chance")]
    public double LootbugTripleChance { get; set; }
    [JsonPropertyName("lootbug_bank_cap")]
    public double LootbugBankCap { get; set; }
    [JsonPropertyName("lootbug_gem_cost_reduction")]
    public double LootbugGemCostReduction { get; set; }
    [JsonPropertyName("lootbug_golden_chance")]
    public double LootbugGoldenChance { get; set; }
    [JsonPropertyName("lootbug_and_elixir_uptime_array")]
    public List<double> LootbugAndElixirUptimeArray { get; set; } = [];
    [JsonPropertyName("lootfrog_10x_spawn_chance")]
    public double Lootfrog10xSpawnChance { get; set; }
    [JsonPropertyName("lootfrog_big_chance")]
    public double LootfrogBigChance { get; set; }
    [JsonPropertyName("lootfrog_big_multi")]
    public double LootfrogBigMulti { get; set; }
    [JsonPropertyName("lootfrog_capacity")]
    public double LootfrogCapacity { get; set; }
    [JsonPropertyName("lootfrog_golden_chance")]
    public double LootfrogGoldenChance { get; set; }
    [JsonPropertyName("lootfrog_golden_multi")]
    public double LootfrogGoldenMulti { get; set; }
    [JsonPropertyName("lootfrog_lanterns_used")]
    public double LootfrogLanternsUsed { get; set; }
    [JsonPropertyName("lootfrog_loot_multi")]
    public double LootfrogLootMulti { get; set; }
    [JsonPropertyName("lootfrog_massive_chance")]
    public double LootfrogMassiveChance { get; set; }
    [JsonPropertyName("lootfrog_massive_multi")]
    public double LootfrogMassiveMulti { get; set; }
    [JsonPropertyName("lootfrog_triple_spawn_chance")]
    public double LootfrogTripleSpawnChance { get; set; }
    [JsonPropertyName("lootfrogs_caught")]
    public double LootfrogsCaught { get; set; }
    [JsonPropertyName("golden_lootfrogs_caught")]
    public double GoldenLootfrogsCaught { get; set; }
    // ==========================================
    // STARS & UPGRADES
    // ==========================================
    [JsonPropertyName("star_radiant_chance")]
    public double StarRadiantChance { get; set; }
    [JsonPropertyName("star_radiant_multi")]
    public double StarRadiantMulti { get; set; }
    [JsonPropertyName("star_spawn_rate")]
    public double StarSpawnRate { get; set; }
    [JsonPropertyName("super_star_10x_chance")]
    public double SuperStar10xChance { get; set; }
    [JsonPropertyName("star_supergiant_chance")]
    public double StarSupergiantChance { get; set; }
    [JsonPropertyName("star_supergiant_multi")]
    public double StarSupergiantMulti { get; set; }
    [JsonPropertyName("super_star_radiant_chance")]
    public double SuperStarRadiantChance { get; set; }
    [JsonPropertyName("star_supernova_chance")]
    public double StarSupernovaChance { get; set; }
    [JsonPropertyName("super_star_radiant_multi")]
    public double SuperStarRadiantMulti { get; set; }
    [JsonPropertyName("star_supernova_multi")]
    public double StarSupernovaMulti { get; set; }
    [JsonPropertyName("super_star_spawn_multi")]
    public double SuperStarSpawnMulti { get; set; }
    [JsonPropertyName("star_triple_spawn_chance")]
    public double StarTripleSpawnChance { get; set; }
    [JsonPropertyName("super_star_supergiant_chance")]
    public double SuperStarSupergiantChance { get; set; }
    [JsonPropertyName("super_star_supergiant_multi")]
    public double SuperStarSupergiantMulti { get; set; }
    [JsonPropertyName("super_star_supernova_chance")]
    public double SuperStarSupernovaChance { get; set; }
    [JsonPropertyName("starburst_fuel_grade")]
    public double StarburstFuelGrade { get; set; }
    [JsonPropertyName("super_star_supernova_multi")]
    public double SuperStarSupernovaMulti { get; set; }
    [JsonPropertyName("super_star_triple_chance")]
    public double SuperStarTripleChance { get; set; }
    [JsonPropertyName("star_auto_catch_chance")]
    public double StarAutoCatchChance { get; set; }
    [JsonPropertyName("star_double_spawn_chance")]
    public double StarDoubleSpawnChance { get; set; }
    [JsonPropertyName("all_star_multi")]
    public double AllStarMulti { get; set; }
    [JsonPropertyName("stars_regular_upgrades_array")]
    public List<double> StarsRegularUpgradesArray { get; set; } = [];
    [JsonPropertyName("stars_star_level_array")]
    public List<double> StarsStarLevelArray { get; set; } = [];
    [JsonPropertyName("stars_super_star_upgrades_array")]
    public List<double> StarsSuperStarUpgradesArray { get; set; } = [];
    // ==========================================
    // STONKS & FLOWERS / FLOORS
    // ==========================================
    [JsonPropertyName("super_stonks_chance")]
    public double SuperStonksChance { get; set; }
    [JsonPropertyName("super_stonks_multi")]
    public double SuperStonksMulti { get; set; }
    [JsonPropertyName("stonks_chance")]
    public double StonksChance { get; set; }
    [JsonPropertyName("stonks_multi")]
    public double StonksMulti { get; set; }
    [JsonPropertyName("ultra_stonks_chance")]
    public double UltraStonksChance { get; set; }
    [JsonPropertyName("ultra_stonks_multi")]
    public double UltraStonksMulti { get; set; }
    [JsonPropertyName("current_floor")]
    public double CurrentFloor { get; set; }
    [JsonPropertyName("prismatic_floor_chance")]
    public double PrismaticFloorChance { get; set; }
    [JsonPropertyName("prismatic_floor_multi")]
    public double PrismaticFloorMulti { get; set; }
    [JsonPropertyName("rainbow_floor_chance")]
    public double RainbowFloorChance { get; set; }
    [JsonPropertyName("rainbow_floor_multi")]
    public double RainbowFloorMulti { get; set; }
    [JsonPropertyName("golden_floor_chance")]
    public double GoldenFloorChance { get; set; }
    [JsonPropertyName("golden_floor_multi")]
    public double GoldenFloorMulti { get; set; }
    [JsonPropertyName("all_floor_multipliers")]
    public double AllFloorMultipliers { get; set; }
    [JsonPropertyName("floor_clear_requirement_multi")]
    public double FloorClearRequirementMulti { get; set; }
    // ==========================================
    // ITEM, SKILL, & GAME STATE
    // ==========================================
    [JsonPropertyName("item_duration_multi")]
    public double ItemDurationMulti { get; set; }
    [JsonPropertyName("item_uptime_array")]
    public List<double> ItemUptimeArray { get; set; } = [];
    [JsonPropertyName("experience_multi")]
    public double ExperienceMulti { get; set; }
    [JsonPropertyName("xp_level_cap")]
    public double XpLevelCap { get; set; }
    [JsonPropertyName("prestige_point_multi")]
    public double PrestigePointMulti { get; set; }
    [JsonPropertyName("candy_eaten")]
    public double CandyEaten { get; set; }
    [JsonPropertyName("steak_eaten")]
    public double SteakEaten { get; set; }
    [JsonPropertyName("pizzas_eaten")]
    public double PizzasEaten { get; set; }
    [JsonPropertyName("game_speed_multi")]
    public double GameSpeedMulti { get; set; }
    [JsonPropertyName("world_4_quest_progress")]
    public double World4QuestProgress { get; set; }
    [JsonPropertyName("worlds_unlocked")]
    public double WorldsUnlocked { get; set; }
    [JsonPropertyName("skill_tree_nodes_array")]
    public List<double> SkillTreeNodesArray { get; set; } = [];
    [JsonPropertyName("relics_array")]
    public List<double> RelicsArray { get; set; } = [];
    [JsonPropertyName("stickers_array")]
    public List<double> StickersArray { get; set; } = [];
    // ==========================================
    // CRAFTING & BARS
    // ==========================================
    [JsonPropertyName("craft_100x_chance")]
    public double Craft100xChance { get; set; }
    [JsonPropertyName("craft_10x_chance")]
    public double Craft10xChance { get; set; }
    [JsonPropertyName("craft_20x_chance")]
    public double Craft20xChance { get; set; }
    [JsonPropertyName("craft_5x_chance")]
    public double Craft5xChance { get; set; }
    [JsonPropertyName("double_craft_chance")]
    public double DoubleCraftChance { get; set; }
    [JsonPropertyName("triple_craft_chance")]
    public double TripleCraftChance { get; set; }
    [JsonPropertyName("free_craft_chance")]
    public double FreeCraftChance { get; set; }
    [JsonPropertyName("bar_craft_cost_multi")]
    public double BarCraftCostMulti { get; set; }
    [JsonPropertyName("bar_output_multi")]
    public double BarOutputMulti { get; set; }
    [JsonPropertyName("bar_upgrade_cost_reduction")]
    public double BarUpgradeCostReduction { get; set; }
    [JsonPropertyName("workshop_array")]
    public List<double> WorkshopArray { get; set; } = [];
    // ==========================================
    // DRONES
    // ==========================================
    [JsonPropertyName("drone_attack_speed_percent")]
    public double DroneAttackSpeedPercent { get; set; }
    [JsonPropertyName("drone_count")]
    public double DroneCount { get; set; }
    [JsonPropertyName("drone_damage_percent")]
    public double DroneDamagePercent { get; set; }
    [JsonPropertyName("drone_movespeed_percent")]
    public double DroneMovespeedPercent { get; set; }
    [JsonPropertyName("drone_radius_percent")]
    public double DroneRadiusPercent { get; set; }
    [JsonPropertyName("drone_rapid_fire_chance")]
    public double DroneRapidFireChance { get; set; }
    [JsonPropertyName("drone_suit_cap")]
    public double DroneSuitCap { get; set; }
    [JsonPropertyName("drone_triple_damage_chance")]
    public double DroneTripleDamageChance { get; set; }
    [JsonPropertyName("drones_suit_level_array")]
    public List<double> DronesSuitLevelArray { get; set; } = [];
    [JsonPropertyName("drones_suit_owned_array")]
    public List<double> DronesSuitOwnedArray { get; set; } = [];
    // ==========================================
    // GEMS & VEINS & ORES
    // ==========================================
    [JsonPropertyName("gem_upgrade_cap_increase")]
    public double GemUpgradeCapIncrease { get; set; }
    [JsonPropertyName("gem_upgrades_array")]
    public List<double> GemUpgradesArray { get; set; } = [];
    [JsonPropertyName("vein_2x_spawn_array")]
    public double Vein2xSpawnArray { get; set; }
    [JsonPropertyName("vein_income_multi")]
    public double VeinIncomeMulti { get; set; }
    [JsonPropertyName("vein_researched_array")]
    public double VeinResearchedArray { get; set; }
    [JsonPropertyName("vein_spawn_rate_multi")]
    public double VeinSpawnRateMulti { get; set; }
    [JsonPropertyName("ore_income_multi")]
    public double OreIncomeMulti { get; set; }
    [JsonPropertyName("ore_sell_price_multi")]
    public double OreSellPriceMulti { get; set; }
    [JsonPropertyName("gleaming_vein_chance")]
    public double GleamingVeinChance { get; set; }
    [JsonPropertyName("ores_per_screen")]
    public double OresPerScreen { get; set; }
    [JsonPropertyName("gleaming_vein_multi")]
    public double GleamingVeinMulti { get; set; }
    [JsonPropertyName("rainbow_ore_chance")]
    public double RainbowOreChance { get; set; }
    [JsonPropertyName("rainbow_ore_multi")]
    public double RainbowOreMulti { get; set; }
    [JsonPropertyName("rainbow_vein_chance")]
    public double RainbowVeinChance { get; set; }
    [JsonPropertyName("rainbow_vein_multi")]
    public double RainbowVeinMulti { get; set; }
    [JsonPropertyName("golden_ore_chance")]
    public double GoldenOreChance { get; set; }
    [JsonPropertyName("golden_ore_multi")]
    public double GoldenOreMulti { get; set; }
    [JsonPropertyName("golden_vein_chance")]
    public double GoldenVeinChance { get; set; }
    [JsonPropertyName("golden_vein_multi")]
    public double GoldenVeinMulti { get; set; }
    [JsonPropertyName("multi_rock_chance")]
    public double MultiRockChance { get; set; }
    // ==========================================
    // OBELISK & CARDS & FUELS
    // ==========================================
    [JsonPropertyName("obelisk_armor_reduction")]
    public double ObeliskArmorReduction { get; set; }
    [JsonPropertyName("obelisk_cooldown_multi")]
    public double ObeliskCooldownMulti { get; set; }
    [JsonPropertyName("obelisk_level")]
    public double ObeliskLevel { get; set; }
    [JsonPropertyName("obelisk_timer_add")]
    public double ObeliskTimerAdd { get; set; }
    [JsonPropertyName("infernal_card_multi")]
    public double InfernalCardMulti { get; set; }
    [JsonPropertyName("prism_fuel_grade")]
    public double PrismFuelGrade { get; set; }
    [JsonPropertyName("chain_fuel_grade")]
    public double ChainFuelGrade { get; set; }
    [JsonPropertyName("veinseeker_fuel_grade")]
    public double VeinseekerFuelGrade { get; set; }
    [JsonPropertyName("midas_fuel_grade")]
    public double MidasFuelGrade { get; set; }
    [JsonPropertyName("bear_fuel_grade")]
    public double BearFuelGrade { get; set; }
    [JsonPropertyName("minotaur_fuel_grade")]
    public double MinotaurFuelGrade { get; set; }
    [JsonPropertyName("frogger_fuel_grade")]
    public double FroggerFuelGrade { get; set; }
    [JsonPropertyName("void_fuel_grade")]
    public double VoidFuelGrade { get; set; }
    [JsonPropertyName("angler_fuel_grade")]
    public double AnglerFuelGrade { get; set; }
    [JsonPropertyName("elixir_fuel_grade")]
    public double ElixirFuelGrade { get; set; }
    // ==========================================
    // REVENUE & COAL & CHALLENGES
    // ==========================================
    [JsonPropertyName("challenge_upgrades_array")]
    public List<double> ChallengeUpgradesArray { get; set; } = [];
    [JsonPropertyName("regular_upgrades_array")]
    public List<double> RegularUpgradesArray { get; set; } = [];
    [JsonPropertyName("coal_capacity_multi")]
    public double CoalCapacityMulti { get; set; }
    [JsonPropertyName("coal_drone_exp_multi")]
    public double CoalDroneExpMulti { get; set; }
    [JsonPropertyName("coal_fuel_duration_multi")]
    public double CoalFuelDurationMulti { get; set; }
    [JsonPropertyName("coal_fuel_save_chance")]
    public double CoalFuelSaveChance { get; set; }
    [JsonPropertyName("coal_generation_seconds")]
    public double CoalGenerationSeconds { get; set; }
    // ==========================================
    // FISHING & DOCK MECHANICS
    // ==========================================
    [JsonPropertyName("fishing_5x_tick_chance")]
    public double Fishing5xTickChance { get; set; }
    [JsonPropertyName("fishing_double_tick_chance")]
    public double FishingDoubleTickChance { get; set; }
    [JsonPropertyName("fishing_drone_capacity")]
    public double FishingDroneCapacity { get; set; }
    [JsonPropertyName("fishing_drone_multiplier")]
    public double FishingDroneMultiplier { get; set; }
    [JsonPropertyName("fishing_drone_power")]
    public double FishingDronePower { get; set; }
    [JsonPropertyName("is_drone_angler_equipped")]
    public bool IsDroneAnglerEquipped { get; set; }
    [JsonPropertyName("is_drone_angler_equipped_and_fueled")]
    public bool IsDroneAnglerEquippedAndFueled { get; set; }
    [JsonPropertyName("fishing_enhance_array")]
    public List<double> FishingEnhanceArray { get; set; } = [];
    [JsonPropertyName("fishing_income_multi")]
    public double FishingIncomeMulti { get; set; }
    [JsonPropertyName("is_drone_basic_equipped")]
    public bool IsDroneBasicEquipped { get; set; }
    [JsonPropertyName("is_drone_bear_equipped")]
    public bool IsDroneBearEquipped { get; set; }
    [JsonPropertyName("fishing_legendary_card_levels_array")]
    public List<double> FishingLegendaryCardLevelsArray { get; set; } = [];
    [JsonPropertyName("fishing_legendary_tribute_levels_array")]
    public List<double> FishingLegendaryTributeLevelsArray { get; set; } = [];
    public static class FishingLegendaryTributeLevelsArrayIndices
    {
        public const int RainbowTrout = 0;
        public const int DunesEelworm = 1;
        public const int GlacialShellstealer = 2;
        public const int Megalodon = 3;
        public const int RadioactiveSlug = 4;
        public const int Cthulhu = 5;
        public const int GlimmeringGeoduck = 6;
        public const int Laviathan = 7;
        public const int StormSerpent = 8;
        public const int MeltingGibbous = 9;
        public const int BlackenedBasker = 10;
    }
    [JsonPropertyName("is_drone_bear_equipped_and_fueled")]
    public bool IsDroneBearEquippedAndFueled { get; set; }
    [JsonPropertyName("is_drone_chain_equipped")]
    public bool IsDroneChainEquipped { get; set; }
    [JsonPropertyName("is_drone_chain_equipped_and_fueled")]
    public bool IsDroneChainEquippedAndFueled { get; set; }
    [JsonPropertyName("fishing_notice_requirement")]
    public double FishingNoticeRequirement { get; set; }
    [JsonPropertyName("is_drone_elixir_equipped")]
    public bool IsDroneElixirEquipped { get; set; }
    [JsonPropertyName("fishing_notices_array")]
    public List<double> FishingNoticesArray { get; set; } = [];
    [JsonPropertyName("is_drone_elixir_equipped_and_fueled")]
    public bool IsDroneElixirEquippedAndFueled { get; set; }
    [JsonPropertyName("is_drone_frogger_equipped")]
    public bool IsDroneFroggerEquipped { get; set; }
    [JsonPropertyName("fishing_regular_card_array")]
    public List<double> FishingRegularCardArray { get; set; } = [];
    [JsonPropertyName("is_drone_frogger_equipped_and_fueled")]
    public bool IsDroneFroggerEquippedAndFueled { get; set; }
    [JsonPropertyName("fishing_rod_power")]
    public double FishingRodPower { get; set; }
    [JsonPropertyName("is_drone_midas_equipped")]
    public bool IsDroneMidasEquipped { get; set; }
    [JsonPropertyName("is_drone_midas_equipped_and_fueled")]
    public bool IsDroneMidasEquippedAndFueled { get; set; }
    [JsonPropertyName("is_drone_minotaur_equipped")]
    public bool IsDroneMinotaurEquipped { get; set; }
    [JsonPropertyName("is_drone_minotaur_equipped_and_fueled")]
    public bool IsDroneMinotaurEquippedAndFueled { get; set; }
    [JsonPropertyName("is_drone_prism_equipped")]
    public bool IsDronePrismEquipped { get; set; }
    [JsonPropertyName("is_drone_prism_equipped_and_fueled")]
    public bool IsDronePrismEquippedAndFueled { get; set; }
    [JsonPropertyName("fishing_shiny_chance")]
    public double FishingShinyChance { get; set; }
    [JsonPropertyName("is_drone_starburst_equipped")]
    public bool IsDroneStarburstEquipped { get; set; }
    [JsonPropertyName("fishing_shiny_multi")]
    public double FishingShinyMulti { get; set; }
    [JsonPropertyName("is_drone_starburst_equipped_and_fueled")]
    public bool IsDroneStarburstEquippedAndFueled { get; set; }
    [JsonPropertyName("fishing_super_shiny_chance")]
    public double FishingSuperShinyChance { get; set; }
    [JsonPropertyName("is_drone_veinseeker_equipped")]
    public bool IsDroneVeinseekerEquipped { get; set; }
    [JsonPropertyName("fishing_super_shiny_multi")]
    public double FishingSuperShinyMulti { get; set; }
    [JsonPropertyName("is_drone_veinseeker_equipped_and_fueled")]
    public bool IsDroneVeinseekerEquippedAndFueled { get; set; }
    [JsonPropertyName("is_drone_void_equipped")]
    public bool IsDroneVoidEquipped { get; set; }
    [JsonPropertyName("is_drone_void_equipped_and_fueled")]
    public bool IsDroneVoidEquippedAndFueled { get; set; }
    [JsonPropertyName("fishing_tick_reduction_seconds")]
    public double FishingTickReductionSeconds { get; set; }
    [JsonPropertyName("fishing_tick_speed")]
    public double FishingTickSpeed { get; set; }
    [JsonPropertyName("fishing_tier2_dock_multi")]
    public double FishingTier2DockMulti { get; set; }
    [JsonPropertyName("fishing_tiny_notice_chance")]
    public double FishingTinyNoticeChance { get; set; }
    [JsonPropertyName("fishing_token_multi")]
    public double FishingTokenMulti { get; set; }
    [JsonPropertyName("fishing_triple_tick_chance")]
    public double FishingTripleTickChance { get; set; }
    [JsonPropertyName("fishing_upgrades_array")]
    public List<double> FishingUpgradesArray { get; set; } = [];
    // ==========================================
    // VOID PORTALS & SPACE ELEMENTS
    // ==========================================
    [JsonPropertyName("rainbow_void_portal_chance")]
    public double RainbowVoidPortalChance { get; set; }
    [JsonPropertyName("rainbow_void_portal_multi")]
    public double RainbowVoidPortalMulti { get; set; }
    [JsonPropertyName("black_hole_level")]
    public double BlackHoleLevel { get; set; }
    [JsonPropertyName("golden_void_portal_chance")]
    public double GoldenVoidPortalChance { get; set; }
    [JsonPropertyName("golden_void_portal_multi")]
    public double GoldenVoidPortalMulti { get; set; }
    [JsonPropertyName("all_void_portal_multi")]
    public double AllVoidPortalMulti { get; set; }
    [JsonPropertyName("void_portal_base_multi")]
    public double VoidPortalBaseMulti { get; set; }
    [JsonPropertyName("void_portal_chance")]
    public double VoidPortalChance { get; set; }
    [JsonPropertyName("void_portal_multi")]
    public double VoidPortalMulti { get; set; }
    [JsonPropertyName("galactic_floor_chance")]
    public double GalacticFloorChance { get; set; }
    [JsonPropertyName("galactic_floor_multi")]
    public double GalacticFloorMulti { get; set; }
    [JsonPropertyName("novagiant_combo_multi")]
    public double NovagiantComboMulti { get; set; }
    [JsonPropertyName("galactic_void_portal_chance")]
    public double GalacticVoidPortalChance { get; set; }
    [JsonPropertyName("galactic_void_portal_multi")]
    public double GalacticVoidPortalMulti { get; set; }
    // ==========================================
    // ELIXIRS & CHESTS
    // ==========================================
    [JsonPropertyName("elixir_crit_chance")]
    public double ElixirCritChance { get; set; }
    [JsonPropertyName("elixir_crit_multi")]
    public double ElixirCritMulti { get; set; }
    [JsonPropertyName("chest_double_chance")]
    public double ChestDoubleChance { get; set; }
    [JsonPropertyName("chest_items_bonus")]
    public double ChestItemsBonus { get; set; }
    [JsonPropertyName("chest_meter_multi")]
    public double ChestMeterMulti { get; set; }
    // ==========================================
    // BOMBS
    // ==========================================
    [JsonPropertyName("bomb_additional_multiplier")]
    public double BombAdditionalMultiplier { get; set; }
    [JsonPropertyName("bomb_battery_cap_increases")]
    public double BombBatteryCapIncreases { get; set; }
    [JsonPropertyName("bomb_cap_multiplier")]
    public double BombCapMultiplier { get; set; }
    [JsonPropertyName("bomb_capacity")]
    public double BombCapacity { get; set; }
    [JsonPropertyName("bomb_cherry3x_chance")]
    public double BombCherry3xChance { get; set; }
    [JsonPropertyName("bomb_crit_chance")]
    public double BombCritChance { get; set; }
    [JsonPropertyName("bomb_crit_damage")]
    public double BombCritDamage { get; set; }
    [JsonPropertyName("bomb_damage")]
    public double BombDamage { get; set; }
    [JsonPropertyName("bomb_free_chance")]
    public double BombFreeChance { get; set; }
    [JsonPropertyName("bomb_of_plenty_make_gold_chance")]
    public double BombOfPlentyMakeGoldChance { get; set; }
    [JsonPropertyName("bomb_of_plenty_multi")]
    public double BombOfPlentyMulti { get; set; }
    [JsonPropertyName("bomb_omega_crit_chance")]
    public double BombOmegaCritChance { get; set; }
    [JsonPropertyName("bomb_omega_crit_damage")]
    public double BombOmegaCritDamage { get; set; }
    [JsonPropertyName("bomb_recharge_speed")]
    public double BombRechargeSpeed { get; set; }
    [JsonPropertyName("bomb_super_crit_chance")]
    public double BombSuperCritChance { get; set; }
    [JsonPropertyName("bomb_super_crit_damage")]
    public double BombSuperCritDamage { get; set; }
    [JsonPropertyName("bomb_trans_apply_bop_chance")]
    public double BombTransApplyBopChance { get; set; }
    [JsonPropertyName("bomb_transmuter_multi")]
    public double BombTransmuterMulti { get; set; }
    [JsonPropertyName("bomb_ultra_crit_chance")]
    public double BombUltraCritChance { get; set; }
    [JsonPropertyName("bomb_ultra_crit_damage")]
    public double BombUltraCritDamage { get; set; }
    [JsonPropertyName("bomb_workshop_cap_increase")]
    public double BombWorkshopCapIncrease { get; set; }
    // ==========================================
    // STATUES
    // ==========================================
    [JsonPropertyName("statue_0_set1")]
    public double Statue0Set1 { get; set; }
    [JsonPropertyName("statue_0_set2")]
    public double Statue0Set2 { get; set; }
    [JsonPropertyName("statue_0_set3")]
    public double Statue0Set3 { get; set; }
    [JsonPropertyName("statue_1_set1")]
    public double Statue1Set1 { get; set; }
    [JsonPropertyName("statue_1_set2")]
    public double Statue1Set2 { get; set; }
    [JsonPropertyName("statue_1_set3")]
    public double Statue1Set3 { get; set; }
    [JsonPropertyName("statue_2_set1")]
    public double Statue2Set1 { get; set; }
    [JsonPropertyName("statue_2_set2")]
    public double Statue2Set2 { get; set; }
    [JsonPropertyName("statue_2_set3")]
    public double Statue2Set3 { get; set; }
    [JsonPropertyName("statue_3_set1")]
    public double Statue3Set1 { get; set; }
    [JsonPropertyName("statue_3_set2")]
    public double Statue3Set2 { get; set; }
    [JsonPropertyName("statue_3_set3")]
    public double Statue3Set3 { get; set; }
    [JsonPropertyName("statue_4_set1")]
    public double Statue4Set1 { get; set; }
    [JsonPropertyName("statue_4_set2")]
    public double Statue4Set2 { get; set; }
    [JsonPropertyName("statue_4_set3")]
    public double Statue4Set3 { get; set; }
    [JsonPropertyName("statue_5_set1")]
    public double Statue5Set1 { get; set; }
    [JsonPropertyName("statue_5_set2")]
    public double Statue5Set2 { get; set; }
    [JsonPropertyName("statue_5_set3")]
    public double Statue5Set3 { get; set; }
    [JsonPropertyName("statue_6_set1")]
    public double Statue6Set1 { get; set; }
    [JsonPropertyName("statue_6_set2")]
    public double Statue6Set2 { get; set; }
    [JsonPropertyName("statue_6_set3")]
    public double Statue6Set3 { get; set; }
    [JsonPropertyName("statue_7_set1")]
    public double Statue7Set1 { get; set; }
    [JsonPropertyName("statue_7_set2")]
    public double Statue7Set2 { get; set; }
    [JsonPropertyName("statue_7_set3")]
    public double Statue7Set3 { get; set; }
    [JsonPropertyName("statue_8_set1")]
    public double Statue8Set1 { get; set; }
    [JsonPropertyName("statue_8_set2")]
    public double Statue8Set2 { get; set; }
    [JsonPropertyName("statue_8_set3")]
    public double Statue8Set3 { get; set; }
    // ==========================================
    // FREEBIES & ARTIFACTS
    // ==========================================
    [JsonPropertyName("freebie_5x_chance")]
    public double Freebie5xChance { get; set; }
    [JsonPropertyName("freebie_bank_cap")]
    public double FreebieBankCap { get; set; }
    [JsonPropertyName("freebie_cooldown_seconds")]
    public double FreebieCooldownSeconds { get; set; }
    [JsonPropertyName("freebie_gems_bonus")]
    public double FreebieGemsBonus { get; set; }
    [JsonPropertyName("freebie_refresh_chance")]
    public double FreebieRefreshChance { get; set; }
    [JsonPropertyName("artifact_cap_increase")]
    public double ArtifactCapIncrease { get; set; }
    [JsonPropertyName("artifact_tier4_cap_increase")]
    public double ArtifactTier4CapIncrease { get; set; }
    // ==========================================
    // CONTRACTS & PETS
    // ==========================================
    [JsonPropertyName("contract_10x_points_chance")]
    public double Contract10xPointsChance { get; set; }
    [JsonPropertyName("contract_5x_points_chance")]
    public double Contract5xPointsChance { get; set; }
    [JsonPropertyName("pet_array")]
    public List<double> PetArray { get; set; } = [];
    [JsonPropertyName("contract_cap_increase")]
    public double ContractCapIncrease { get; set; }
    [JsonPropertyName("contract_cost_reduction")]
    public double ContractCostReduction { get; set; }
    [JsonPropertyName("pet_levelup_chance_multi")]
    public double PetLevelupChanceMulti { get; set; }
    [JsonPropertyName("contract_double_points_chance")]
    public double ContractDoublePointsChance { get; set; }
    [JsonPropertyName("pet_quest_array")]
    public List<double> PetQuestArray { get; set; } = [];
    [JsonPropertyName("contract_points_rewarded")]
    public double ContractPointsRewarded { get; set; }
    [JsonPropertyName("contract_triple_points_chance")]
    public double ContractTriplePointsChance { get; set; }
    [JsonPropertyName("pet_skin_set_a_array")]
    public List<double> PetSkinSetAArray { get; set; } = [];
    [JsonPropertyName("contract_upgrade_cost_reduction")]
    public double ContractUpgradeCostReduction { get; set; }
    [JsonPropertyName("pet_skin_set_b_array")]
    public List<double> PetSkinSetBArray { get; set; } = [];
    [JsonPropertyName("contracts_array")]
    public List<double> ContractsArray { get; set; } = [];
    // ==========================================
    // PICKAXE
    // ==========================================
    [JsonPropertyName("pickaxe_attack_speed_per_second")]
    public double PickaxeAttackSpeedPerSecond { get; set; }
    [JsonPropertyName("pickaxe_crit_chance")]
    public double PickaxeCritChance { get; set; }
    [JsonPropertyName("pickaxe_crit_damage")]
    public double PickaxeCritDamage { get; set; }
    [JsonPropertyName("pickaxe_damage")]
    public double PickaxeDamage { get; set; }
    [JsonPropertyName("pickaxe_omega_crit_chance")]
    public double PickaxeOmegaCritChance { get; set; }
    [JsonPropertyName("pickaxe_omega_crit_damage")]
    public double PickaxeOmegaCritDamage { get; set; }
    [JsonPropertyName("pickaxe_radius_percent")]
    public double PickaxeRadiusPercent { get; set; }
    [JsonPropertyName("pickaxe_super_crit_chance")]
    public double PickaxeSuperCritChance { get; set; }
    [JsonPropertyName("pickaxe_super_crit_damage")]
    public double PickaxeSuperCritDamage { get; set; }
    [JsonPropertyName("pickaxe_ultra_crit_chance")]
    public double PickaxeUltraCritChance { get; set; }
    [JsonPropertyName("pickaxe_ultra_crit_damage")]
    public double PickaxeUltraCritDamage { get; set; }
    [JsonPropertyName("idols_array")]
    public List<double> IdolsArray { get; set; } = [];
    // ==========================================
    // CALCULATED FIELDS
    // ==========================================
    // TODO: Add constant class for Skills.
    [JsonIgnore]
    public double MotleySchoolLevel => SkillTreeNodesArray[51];
    [JsonIgnore]
    public double DronePower => FishingDronePower * FishingDroneMultiplier;
    // TODO: Add constant class for Fishing Enhancements.
    [JsonIgnore]
    public double TierTwoDockTickReductionLevel => FishingEnhanceArray[10];
    [JsonIgnore]
    public double PolyCardMultiEnhanceLevel => FishingEnhanceArray[14];
    [JsonIgnore]
    public double CthuluTributeLevel => FishingLegendaryTributeLevelsArray[FishingLegendaryTributeLevelsArrayIndices.Cthulhu];
    [JsonIgnore]
    public double LavaithanTributeLevel => FishingLegendaryTributeLevelsArray[FishingLegendaryTributeLevelsArrayIndices.Laviathan];
    // TODO: Add constant class for Fishing Upgrades.
    [JsonIgnore]
    public double TierOneBoatLevel => FishingUpgradesArray[2];
    [JsonIgnore]
    public double TierTwoBoatLevel => FishingUpgradesArray[12];
    [JsonIgnore]
    public double PolyCardMultiUpgradeLevel => FishingUpgradesArray[16];
}
