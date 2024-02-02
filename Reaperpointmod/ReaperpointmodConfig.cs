using PhoenixPoint.Modding;

namespace Reaperpointmod
{
	/// <summary>
	/// ModConfig is mod settings that players can change from within the game.
	/// Config is only editable from players in main menu.
	/// Only one config can exist per mod assembly.
	/// Config is serialized on disk as json.
	/// </summary>
	public class ReaperpointmodConfig : ModConfig
	{
        /// Only public fields are serialized.
        /// Supported types for in-game UI are:
		[ConfigField("Prestige Helmet Heavy", "Accuracy = -4%, Perception = -5, Stealth = -10%. This Default stats")]
        public float GoldenHelmetHeavyForBorminPerception = -5f;
        public float GoldenHelmetHeavyForBorminStealth = -0.1f;
        public float GoldenHelmetHeavyForBorminAccuracy = -0.04f;

        [ConfigField("Prestige Torso Heavy", "Speed = -1, Accuracy = -8%, Perception = 0, Stealth = -20%. This Default stats")]
        public float GoldenTorsoHeavyForBorminSpeed = -1f;
        public float GoldenTorsoHeavyForBorminPerception = 0f;
        public float GoldenTorsoHeavyForBorminStealth = -0.2f;
        public float GoldenTorsoHeavyForBorminAccuracy = -0.08f;

        [ConfigField("Prestige Legs Armor Heavy", "Speed = -1, Acciracy = -4%, Perception = 0, Stealth = -10%. Default stats")]
        public float GoldenLegsArmorHeavyForBorminSpeed = -1f;
        public float GoldenLegsArmorHeavyForBorminPerception = 0f;
        public float GoldenLegsArmorHeavyForBorminStealth = -0.1f;
        public float GoldenLegsArmorHeavyForBorminAccuracy = -0.04f;

        [ConfigField("Living Helmet Armor", "Perception = 0, Stealth = 5%, Accuracy = 5%. Default stats")]
        public float LivingHelmetArmorPerception = 0f;
        public float LivingHelmetArmorStealth = 0.05f;
        public float LivingHelmetArmorAccuracy = 0.05f;

        [ConfigField("Living Torso Armor", "Perception = 0, Stealth = 10%, Accuracy = 5%. Default stats")]
        public float LivingTorsoArmorPerception = 0f;
        public float LivingTorsoArmorStealth = 0.1f;
        public float LivingTorsoArmorAccuracy = 0.05f;

        [ConfigField("Living Legs Armor", "Perception = 0, Stealth = 10%, Accuracy = 5%. Default stats")]
        public float LivingLegsArmorPerception = 0f;
        public float LivingLegsArmorStealth = 0.1f;
        public float LivingLegsArmorAccuracy = 0.05f;

        [ConfigField("Prestige Helmet Assault", "Accuracy = 0%, Perception = 0 Stealth = 0%. This Default stats")]
        public float GoldenHelmetAssaultForMagnusPerception = 0f;
        public float GoldenHelmetAssaultForMagnusStealth = 0f;
        public float GoldenHelmetAssaultForMagnusAccuracy = 0f;

        [ConfigField("Prestige Torso Assault", "Accuracy = 0%, Perception = 0 Stealth = 0%. Default stats")]
        public float GoldenTorsoAssaultForMagnusPerception = 0f;
        public float GoldenTorsoAssaultForMagnusStealth = 0f;
        public float GoldenTorsoAssaultForMagnusAccuracy = 0f;

        [ConfigField("Prestige Legs Armor Assault", "Speed = 1, Accuracy = 0%, Perception = 0 Stealth = 0%. Default stats")]
        public float GoldenLegsArmorAssaultForMagnusSpeed = 1f;
        public float GoldenLegsArmorAssaultForMagnusPerception = 0f;
        public float GoldenLegsArmorAssaultForMagnusStealth = 0f;
        public float GoldenLegsArmorAssaultForMagnusAccuracy = 0f;

        [ConfigField("Prestige Helmet Sniper", "Perception = 5, Stealth = 3%, Accuracy = 8%. Default stats")]
        public float GoldenHelmetSniperForSelmaPerception = 5f;
        public float GoldenHelmetSniperForSelmaStealth = 0.03f;
        public float GoldenHelmetSniperForSelmaAccuracy = 0.08f;

        [ConfigField("Prestige Torso Sniper", "Speed = -1, Perception = 0, Stealth = 5%, Accuracy = 4%. Default stats")]
        public float GoldenTorsoSniperForSelmaSpeed = -1f;
        public float GoldenTorsoSniperForSelmaPerception = 0f;
        public float GoldenTorsoSniperForSelmaStealth = 0.05f;
        public float GoldenTorsoSniperForSelmaAccuracy = 0.04f;

        [ConfigField("Prestige Legs Armor Sniper", "Perception = 0, Stealth = 6%, Accuracy = 4%. Default stats")]
        public float GoldenLegsArmorSniperForSelmaPerception = 0f;
        public float GoldenLegsArmorSniperForSelmaStealth = 0.06f;
        public float GoldenLegsArmorSniperForSelmaAccuracy = 0.04f;

        [ConfigField("Christmas Helmet Heavy", "Accuracy = -4%, Perception = -5, Stealth = -10%. This Default stats")]
        public float ChristmasHelmetHeavyPerception = -5f;
        public float ChristmasHelmetHeavyStealth = -0.1f;
        public float ChristmasHelmetHeavyAccuracy = -0.04f;

        [ConfigField("Christmas Torso Heavy", "Speed = -1, Accuracy = -8%, Perception = 0, Stealth = -20%. This Default stats")]
        public float ChristmasTorsoHeavySpeed = -1f;
        public float ChristmasTorsoHeavyPerception = 0f;
        public float ChristmasTorsoHeavyStealth = -0.2f;
        public float ChristmasTorsoHeavyAccuracy = -0.08f;

        [ConfigField("Christmas Legs Armor Heavy", "Speed = -1, Acciracy = -4%, Perception = 0, Stealth = -10%. Default stats")]
        public float ChristmasLegsArmorHeavySpeed = -1f;
        public float ChristmasLegsArmorHeavyPerception = 0f;
        public float ChristmasLegsArmorHeavyStealth = -0.1f;
        public float ChristmasLegsArmorHeavyAccuracy = -0.04f;

        [ConfigField("Headhunter Helmet Heavy", "Accuracy = -4%, Perception = -5, Stealth = -10%. This Default stats")]
        public float HeadhunterHelmetHeavyPerception = -5f;
        public float HeadhunterHelmetHeavyStealth = -0.1f;
        public float HeadhunterHelmetHeavyAccuracy = -0.04f;

        [ConfigField("Headhunter Torso Heavy", "Speed = -1, Accuracy = -8%, Perception = 0, Stealth = -20%. This Default stats")]
        public float HeadhunterTorsoHeavySpeed = -1f;
        public float HeadhunterTorsoHeavyPerception = 0f;
        public float HeadhunterTorsoHeavyStealth = -0.2f;
        public float HeadhunterTorsoHeavyAccuracy = -0.08f;

        [ConfigField("Headhunter Legs Armor Heavy", "Speed = -1, Acciracy = -4%, Perception = 0, Stealth = -10%. Default stats")]
        public float HeadhunterLegsArmorHeavySpeed = -1f;
        public float HeadhunterLegsArmorHeavyPerception = 0f;
        public float HeadhunterLegsArmorHeavyStealth = -0.1f;
        public float HeadhunterLegsArmorHeavyAccuracy = -0.04f;


        [ConfigField("Rising Sun Helmet Sniper", "Perception = 5, Stealth = 3%, Accuracy = 8%. Default stats")]
        public float RisingSunHelmetPerception = 5f;
        public float RisingSunHelmetStealth = 0.03f;
        public float RisingSunHelmetAccuracy = 0.08f;

        [ConfigField("Rising Sun Torso Sniper", "Speed = -1, Perception = 0, Stealth = 5%, Accuracy = 4%. Default stats")]
        public float RisingSunTorsoSpeed = -1f;
        public float RisingSunTorsoPerception = 0f;
        public float RisingSunTorsoStealth = 0.05f;
        public float RisingSunTorsoAccuracy = 0.04f;

        [ConfigField("Rising Sun Legs Armor Sniper", "Perception = 0, Stealth = 6%, Accuracy = 4%. Default stats")]
        public float RisingSunLegsArmorPerception = 0f;
        public float RisingSunLegsArmorStealth = 0.06f;
        public float RisingSunLegsArmorAccuracy = 0.04f;

        [ConfigField("Helmet Viking", "Perception = 10, Stealth = 0%, Accuracy = 0%. Default stats")]
        public float HelmetVikingPerception = 10f;
        public float HelmetVikingStealth = 0f;
        public float HelmetVikingAccuracy = 0f;

        [ConfigField("Torso Viking", "Speed = 2, Perception = 0, Stealth = 0%, Accuracy = -5%. Default stats")]
        public float TorsoVikingSpeed = 2f;
        public float TorsoVikingPerception = 0f;
        public float TorsoVikingStealth = 0f;
        public float TorsoVikingAccuracy = -0.05f;

        [ConfigField("Legs Armor Viking", "Speed = 2, Perception = 0, Stealth = 0%, Accuracy = -5%. Default stats")]
        public float LegsArmorVikingSpeed = 2f;
        public float LegsArmorVikingPerception = 0f;
        public float LegsArmorVikingStealth = 0f;
        public float LegsArmorVikingAccuracy = -0.05f;


        [ConfigField("Aztec Helmet", "Perception = 0, Stealth = -10%, Accuracy = 7%. Default stats")]
        public float AztecHelmetPerception = 0f;
        public float AztecHelmetStealth = -0.1f;
        public float AztecHelmetAccuracy = 0.07f;

        [ConfigField("Aztec Torso", "Perception = 7, Stealth = 0%, Accuracy = 5%. Default stats")]
        public float AztecTorsoPerception = 7f;
        public float AztecTorsoStealth = 0f;
        public float AztecTorsoAccuracy = 0.05f;

        [ConfigField("Aztec Legs Armor", "Perception = 4, Stealth = 0%, Accuracy = 5%. Default stats")]
        public float AztecLegsArmorPerception = 4f;
        public float AztecLegsArmorStealth = 0f;
        public float AztecLegsArmorAccuracy = 0.05f;

        [ConfigField("Pandoran Helmet Technician", "Perception = 0, Stealth = -5%, Accuracy = 6%. Default stats")]
        public float PandoranHelmetTechnicianPerception = 0f;
        public float PandoranHelmetTechnicianStealth = -0.05f;
        public float PandoranHelmetTechnicianAccuracy = 0.06f;

        [ConfigField("Pandoran Torso Technician", "Speed = -1, Perception = 0, Stealth = -15%, Accuracy = 3%. Default stats")]
        public float PandoranTorsoTechnicianSpeed = -1f;
        public float PandoranTorsoTechnicianPerception = 0f;
        public float PandoranTorsoTechnicianStealth = -0.15f;
        public float PandoranTorsoTechnicianAccuracy = 0.03f;

        [ConfigField("Pandoran Legs Armor Technician", "Speed = -1, Perception = 0, Stealth = -1%, Accuracy = 4%. Default stats")]
        public float PandoranLegsArmorTechnicianSpeed = -1f;
        public float PandoranLegsArmorTechnicianPerception = 0f;
        public float PandoranLegsArmorTechnicianStealth = -0.01f;
        public float PandoranLegsArmorTechnicianAccuracy = 0.04f;

        [ConfigField("Neon Helmet", "Perception = 0, Stealth = 0%, Accuracy = 6%. Default stats")]
        public float NeonHelmetPerception = 0f;
        public float NeonHelmetStealth = 0f;
        public float NeonHelmetAccuracy = 0.06f;

        [ConfigField("Neon Torso", "Speed = 1, Perception = 0, Stealth = 0%, Accuracy = 3%. Default stats")]
        public float NeonTorsoSpeed = 1f;
        public float NeonTorsoPerception = 0f;
        public float NeonTorsoStealth = 0f;
        public float NeonTorsoAccuracy = 0.03f;

        [ConfigField("Neon Legs Armor", "Speed = 1, Perception = 0, Stealth = 0%, Accuracy = 2%. Default stats")]
        public float NeonLegsArmorSpeed = 1f;
        public float NeonLegsArmorPerception = 0f;
        public float NeonLegsArmorStealth = 0f;
        public float NeonLegsArmorAccuracy = 0.02f;

        [ConfigField("WhiteNeon Helmet", "Perception = 0, Stealth = 0%, Accuracy = 6%. Default stats")]
        public float WhiteNeonHelmetPerception = 0f;
        public float WhiteNeonHelmetStealth = 0f;
        public float WhiteNeonHelmetAccuracy = 0.06f;

        [ConfigField("WhiteNeon Torso", "Speed = 1, Perception = 0, Stealth = 0%, Accuracy = 3%. Default stats")]
        public float WhiteNeonTorsoSpeed = 1f;
        public float WhiteNeonTorsoPerception = 0f;
        public float WhiteNeonTorsoStealth = 0f;
        public float WhiteNeonTorsoAccuracy = 0.03f;

        [ConfigField("WhiteNeon Legs Armor", "Speed = 1, Perception = 0, Stealth = 0%, Accuracy = 2%. Default stats")]
        public float WhiteNeonLegsArmorSpeed = 1f;
        public float WhiteNeonLegsArmorPerception = 0f;
        public float WhiteNeonLegsArmorStealth = 0f;
        public float WhiteNeonLegsArmorAccuracy = 0.02f;

        [ConfigField("Kaos Helmet", "Perception = 10, Stealth = 10%, Accuracy = 0%. Default stats")]
        public float KaosHelmetPerception = 10f;
        public float KaosHelmetStealth = 0.1f;
        public float KaosHelmetAccuracy = 0f;

        [ConfigField("Kaos Torso", "Perception = 0, Stealth = 20%, Accuracy = 0%. Default stats")]

        public float KaosTorsoPerception = 0f;
        public float KaosTorsoStealth = 0.2f;
        public float KaosTorsoAccuracy = 0f;

        [ConfigField("Kaos Legs Armor", "Perception = 0, Stealth = 20%, Accuracy = 0%. Default stats")]

        public float KaosLegsArmorPerception = 0f;
        public float KaosLegsArmorStealth = 0.2f;
        public float KaosLegsArmorAccuracy = 0f;

        [ConfigField("Ares Weapon", null)]
        public int AresActionPointToUsePerc = 50;
        public float AresDamage = 30f;

        [ConfigField("FireBird Weapon", null)]
        public int FireBirdActionPointToUsePerc = 75;
        public float FireBirdDamage = 110f;

        [ConfigField("Hel II Cannon Weapon", null)]
        public int HelActionPointToUsePerc = 75;
        public float HelDamage = 200f;

        [ConfigField("Tyr I Autocannon Weapon", null)]
        public int TyrIActionPointToUsePerc = 75;
        public float TyrIDamage = 60f;

        [ConfigField("Cypher Weapon", null)]
        public int CypherActionpointToUsePerc = 25;
        public float CypherDamage = 50f;

        [ConfigField("Mercy Weapon", null)]
        public int MercyActionPointToUsePerc = 50;
        public float MercyDamage = 35f;

        [ConfigField("Slamstrike Weapon", null)]
        public int SlamStrikeActionPointToUsePerc = 50;
        public float SlamStrikeDamage = 120f;

        [ConfigField("Vidar Weapon", null)]
        public int VidarActionPointToUsePerc = 25;
        public float VidarDamage = 50f;

        [ConfigField("Hawk Weapon", null)]
        public int HawkActionPointToUsePerc = 50;
        public float HawkDamage = 90f;

        [ConfigField("Gungnir Weapon", null)]
        public int GungnirActionPointToUsePerc = 75;
        public float GungnirDamage = 110f;

        [ConfigField("Goliath Weapon", null)]
        public int GoliathActionPointToUsePerc = 75;
        public float GoliathDamage = 60f;

        [ConfigField("Jormungandr Weapon", null)]
        public int JormungandrActionPointToUsePerc = 75;
        public float JormungandrDamage = 10f;

        [ConfigField("Pheonix Shock Lance Weapon", null)]
        public int PSLActionPointToUsePerc = 50;
        public float PSLDamage = 160f;

        [ConfigField("Ragnarok Weapon", null)]
        public int RagnarokActionPointToUsePerc = 25;
        public float RagnarokDamage = 80f;

        [ConfigField("Gorgon Eye-A Weapon", null)]
        public int GorgonEyeAActionPointToUsePerc = 25;
        public float GorGonEyeADamage = 40f;

        [ConfigField("Destiny Weapon", null)]
        public int DestinyActionPointToUsePerc = 25;
        public float DestinyDamage = 70f;

        [ConfigField("Scorcher AT Weapon", null)]
        public int ScorcherATActionPointToUsePerc = 100;
        public float ScorcherATDamage = 60f;

        [ConfigField("Neurazer Weapon", null)]
        public int NeurazerActionPointToUsePerc = 25;
        public float NeurazerDamage = 10f;
        public float NeurazerPiercing = 40f;
        public float NeurazerParalysis = 8f;

        [ConfigField("Rising Sun Firebird", null)]
        public int FBSkyActionPointToUsePerc = 75;
        public float FBSkyDamage = 110f;

        [ConfigField("Prestige Assault Rifle", null)]
        public int GoldenAresActionPointToUsePerc = 50;
        public float GoldenAresDamage = 30f;

        [ConfigField("Prestige Heavy Cannon", null)]
        public int GoldenHelIIActionPointToUsePerc = 75;
        public float GoldenHelIIDamage = 200f;

        [ConfigField("Prestige Sniper Rifle", null)]
        public int GoldenFireBirdActionPointToUsePerc = 75;
        public float GoldenFireBirdDamage = 110f;

        [ConfigField("Christmas Heavy Cannon", null)]
        public int xmasactionpointtouseperc = 75;
        public float xmasdamage = 200f;

        [ConfigField("Head Hunter Heavy Cannon", null)]
        public int HHHelIIActionPointToUsePerc = 75;
        public float HHHelIIDamage = 200f;

        [ConfigField("Assault Rifle Danchev Weapon", null)]
        public int ARDanchevActionPointToUsePerc = 50;
        public float ARDanchevDamage = 30f;
        public float ARDanchevAcid = 5f;

        [ConfigField("Machine Gun Danchev Weapon", null)]
        public int MGDanchevActionPointToUsePerc = 75;
        public float MGDanchevDamage = 35f;
        public float MGDanchevPoison = 5f;

        [ConfigField("Mattock of the Ancients Weapon", null)]
        public int MattockActionPointToUsePerc = 50;
        public float MattockDamage = 220f;
        public float MattockShock = 400f;

        [ConfigField("Scyther Weapon", null)]
        public int ScytherActionPointToUsePerc = 50;
        public float ScytherDamage = 300f;
        public float ScytherShred = 30f;

        [ConfigField("Shard Gun Weapon", null)]
        public int ShardGunActionPointToUsePerc = 50;
        public float ShardGunDamage = 25f;
        public float ShardGunPiercing = 15f;

        [ConfigField("Rebuke Weapon", null)]
        public int RebukeActionPointToUsePerc = 75;
        public float RebukeDamage = 90f;
        public float RebukeShred = 30f;

        [ConfigField("Scorpion Weapon", null)]
        public int ScorpionActionPointToUsePerc = 75;
        public float ScorpionDamage = 180f;
        public float ScorpionPiercing = 80f;

        [ConfigField("Crystal Crossbow Weapon", null)]
        public int CrystalCrossbowActionPointToUsePerc = 25;
        public float CrystalCrossbowDamage = 60f;
        public float CrystalCrossbowPiercing = 40f;

        [ConfigField("Neon Assault Rifle Weapon", null)]
        public int SYARNeonActionPointToUsePerc = 50;
        public float SYARNeonDamage = 30f;

        [ConfigField("White Neon Assault Rifle Weapon", null)]
        public int SYARWhiteNeonActionPointToUsePerc = 50;
        public float SYARWhiteNeonDamage = 30f;

        [ConfigField("Axe Viking Weapon", null)]
        public int AxeVikingActionPointToUsePerc = 50;
        public float AxeVikingDamage = 140f;
        public float AxeVikingBleed = 50f;

        [ConfigField("Kaos Crossbow Weapon", null)]
        public int KaosCrossbowActionPointToUsePerc = 25;
        public float KaosCrossbowDamage = 60f;

        [ConfigField("Odin Grenade Weapon", null)]
        public int OdinActionPointToUsePerc = 50;
        public float OdinDamage = 50f;

        [ConfigField("Mjolnir Grenade Weapon", null)]
        public int MjolnirActionPointToUsePerc = 50;
        public float MjolnirDamage = 40f;
        public float MjolnirShred = 30f;

        [ConfigField("Yggdrasil Grenade Weapon", null)]
        public int YggdrasilActionPointToUsePerc = 50;
        public float YggdrasilDamage = 40f;
        public float YggdrasilVirophage = 60f;
        public float YggdrasilShred = 6f;

        [ConfigField("Laser Array Shoot Ability", null)]
        public int LASAUsesPerTurn = 1;

        [ConfigField("Launch Rocket Shoot Ability", null)]
        public int LRSAUsesPerTurn = 1;

        [ConfigField("Vita(Medical) Grenade", null)]
        public int VitaActionPointToUsePerc = 50;
        public float VitaHeal = 50f;

        [ConfigField("Kaos Devastator Weapon", null)]
        public int ChaosDevastatorActionPointToUsePerc = 75;
        public float ChaosDevastatorDamage = 150f;
        public float ChaosDevastatorShock = 150f;

        [ConfigField("Kaos Obliterator Weapon", null)]
        public int ChaosObliteratorActionPointToUsePerc = 50;
        public float ChaosObliteratorDamage = 40f;

        [ConfigField("Kaos Redemptor Weapon", null)]
        public int ChaosRedemptorActionPointToUsePerc = 50;
        public float ChaosRedemptorDamage = 50f;
        public float ChaosRedemptorAcid = 5f;

        [ConfigField("Kaos Subjector Weapon", null)]
        public int ChaosSubjectorActionPointToUsePerc = 75;
        public float ChaosSubjectorDamage = 130f;
        public float ChaosSubjectorPoison = 30f;

        [ConfigField("Kaos Tormentor Weapon", null)]
        public int ChaosTormentorActionPointToUsePerc = 25;
        public float ChaosTormentorDamage = 50f;
        public float ChaosTormentorPiercing = 10f;


        [ConfigField("Nomad Aircraft Weapon", null)]
        public int NomadAmmoCount = 30;
        public float NomadDamageRegular = 140f;

        [ConfigField("Orochi Aircraft Weapon", null)]
        public int OrochiAmmoCount = 30;
        public float OrochiDamageRegular = 180f;
        public float OrochiDamageShock = 360f;

        [ConfigField("Thunderbolt Aircraft Weapon", null)]
        public int ThunderboltAmmoCount = 30;
        public float ThunderboltDamageRegular = 150f;

        [ConfigField("Brokkr Aircraft Weapon", null)]
        public int BrokkrAmmoCount = 90;
        public float BrokkrDamageRegular = 100f;

        [ConfigField("Fenrir Aircraft Weapon", null)]
        public int FenrirAmmoCount = 98;
        public float FenrirDamageRegular = 60f;
        public float FenrirDamageVirophage = 60f;

        [ConfigField("Hand of Tyr Aircraft Weapon", null)]
        public int HandofTyrAmmoCount = 12;
        public float HandofTyrDamageRegular = 300f;
        public float HandofTyrDamageShock = 600f;

        [ConfigField("Flares Aircraft Module", null)]
        public int FlaresAmmoCount = 5;

        [ConfigField("Afterburner Aircraft Module", null)]
        public int AfterburnerAmmoCount = 5;

        [ConfigField("Cruise Control Aircraft Module", null)]
        public float CruiseControlSpeed = 100f;

        [ConfigField("Fuel Tank Aircraft Module", null)]
        public float FuelTankSpeed = 500f;

        [ConfigField("Manticore Mask Space Units", null)]
        public int ManticoreMaskSpaceForUnits = 8;

        [ConfigField("Disciple of Anu", "Amount of supplies provided after the research was completed")]
        public float SuppliesValue = 250f;

        [ConfigField("New Jericho", "Amount of material provided after the research was completed")]
        public float MaterialsValue = 315f;

        [ConfigField("Synedrion", "Amount of tech provided after the research was completed")]
        public float TechValue = 190f;

        [ConfigField("Pandoran Evole", null)]
        public float PandoranEvoleMaterialsValue = 375f;
        public float PandoranEvoleTechValue = 190f;

        [ConfigField("Pandoran Colony", null)]
        public float PandoranColonyMaterialsValue = 250f;
        public float PandoranColonyTechValue = 125f;
        public float PandoranColonySuppliesValue = 375f;

        [ConfigField("Pandoran Lair", null)]
        public float PandoranLairMaterialsValue = 375f;
        public float PandoranLairTechValue = 375f;
        public float PandoranLairSuppliesValue = 375f;

        [ConfigField("Scylla Research", "Resource given after research")]
        public float ScyllaResearcMaterialsValue = 250f;
        public float ScyllaResearcTechValue = 125f;
        public float ScyllaResearcSuppliesValue = 625f;

        [ConfigField("Mutoid resource",null)]
        public float MutoidMutagensValue = 500f;

        [ConfigField("Acheron resource", null)]
        public float AcheronMutagensValue = 250f;

        [ConfigField("Mindfragger resource", null)]
        public float MindfraggerMaterialsValue = 190f;

        [ConfigField("Fireworm resource", null)]
        public float FirewormMaterialsValue = 125f;

        [ConfigField("Poisonworm resource", null)]
        public float PoisonwormMaterialsValue = 125f;

        [ConfigField("Acidworm resource", null)]
        public float AcidwormMaterialsValue = 125f;

        [ConfigField("Mindfragger Egg resource", null)]
        public float MindfraggerEggMaterialsValue = 65f;
        public float MindfraggerEggSuppliesValue = 500f;

        [ConfigField("Worm Egg resource", null)]
        public float WormEggMaterialsValue = 65f;
        public float WormEggSuppliesValue = 500f;

        [ConfigField("Siren resource", null)]
        public float SirenMaterialsValue = 190f;

        [ConfigField("Chiron resource", null)]
        public float ChironSuppliesValue = 375f;
        public float ChironMaterialsValue = 125f;
        public float ChironTechValue = 65f;

        [ConfigField("Mindfragger Vivisection Damage", "Increases attacks on pandorans")]
        public float MindFraggerDamageMultiplier = 1.1f;

        [ConfigField("Fireworm Vivisection Damage", "Increases attacks on pandorans")]
        public float FirewormDamageMultiplier = 1.1f;

        [ConfigField("Poisonworm Vivisection Damage", "Increases attacks on pandorans")]
        public float PoisonwormDamageMultiplier = 1.1f;

        [ConfigField("Acidworm Vivisection Damage", "Increases attacks on pandorans")]
        public float AcidwormDamageMultiplier = 1.1f;

        [ConfigField("Arthron Vivisection Damage", "Increases attacks on pandorans")]
        public float ArthronDamageMultiplier = 1.1f;

        [ConfigField("Triton Vivisection Damage", "Increases attacks on pandorans")]
        public float TritonDamageMultiplier = 1.1f;

        [ConfigField("Siren Vivisection Damage", "Increases attacks on pandorans")]
        public float SirenDamageMultiplier = 1.1f;

        [ConfigField("Chiron Vivisection Damage", "Increases attacks on pandorans")]
        public float ChironDamageMultiplier = 1.1f;

        [ConfigField("Scylla Vivisection Damage", "Increases attacks on pandorans")]
        public float ScyllaDamageMultiplier = 1.1f;

        [ConfigField("Terror Sentinel Damage", "Increases attacks on pandorans")]
        public float TerrorSentinelDamageMultiplier = 1.15f;

        [ConfigField("Hatching Sentinel Damage", "Increases attacks on pandorans")]
        public float HatchingSentinelDamageMultiplier = 1.15f;

        [ConfigField("Mist Sentinel Damage", "Increases attacks on pandorans")]
        public float MistSentinelDamageMultiplier = 1.15f;

        [ConfigField("Pandoran Spawnery Damage", "Increases attacks on pandorans")]
        public float PandoranSpawneryDamageMultiplier = 1.2f;

        [ConfigField("Acheron Vivisection Damage", "Increases attacks on pandorans")]
        public float AcheronDamageMultiplier = 1.1f;

        [ConfigField("Moon Data Analys Damage", "Increases attacks on pandorans")]
        public float MoonDataAnalysDamageMultiplier = 1.1f;

        [ConfigField("Experoence After Mission", null)]
        public float EAMModifier = 0.1f;

        [ConfigField("Anu Alien Religion", "Given resource after research complete")]
        public float AARSuppliesValue = 500f;
        public float AARTechValue = 250f;

        [ConfigField("NJ Pandoran Phyliology", "Pandoran related research speed increased by 25%")]
        public float NJPandoranPhyliologyAmount = 0.25f;

        [ConfigField("NJ Production Robotics", "Fabrication Plant facility efficiency is increased by 50%")]
        public float NJProdRobotAmount = 0.5f;

        [ConfigField("NJ Centralized AI", "All base Facilities output is increased by 50%")]
        public float NJCentralAIAmount = 0.5f;

        [ConfigField("NJ Satellite Uplink", "Scanning range of Phoenix Bases is increased by 25%")]
        public float NJSUScannerRangeAmount = 0.25f;

        [ConfigField("Nuclear Fusion Technology ", "Power plant (aka Energy generator) energy production is increased by 50%.")]
        public float NFTAmount = 0.5f;

        [ConfigField("Medical Nanites", "Medical Bay facility healing at bases increased by 50% and +20 healing bonus in battle.")]
        public float NanoHealingAmount = 0.5f;

        [ConfigField("Sentient AIs", "Research point output is increased by 25%.")]
        public float SentientAIsAmount = 0.5f;

        [ConfigField("Gemini V", "Phoenix Scarab Missile Turret")]
        public int GeminiActionPointToUsePerc = 75;
        public int GeminiChargesMaxAmmo = 8;
        public float GeminiDamage = 80f;

        [ConfigField("Taurus II", "Phoenix Scarab Heavy Turret")]
        public int TaurusActionPointToUsePerc = 75;
        public int TaurusChargesMaxAmmo = 4;
        public float TaurusDamage = 350f;
        public float TaurusShockDamage = 350f;

        [ConfigField("Scorpio VII", "Phoenix Scarab Missile Turret")]
        public int ScorpioActionPointToUsePerc = 75;
        public int ScorpioChargesMaxAmmo = 8;
        public float ScorpioDamage = 120f;

        [ConfigField("The Vishnu Gun (Minigun)", "Kaos Buggy Combined Turret")]
        public int TheVishnuGunMinigunActionPointToUsePerc = 50;
        public int TheVishnuGunMinigunChargesMaxAmmo = 64;
        public float TheVishnuGunMinigunDamage = 50f;

        [ConfigField("The Vishnu Gun", "Kaos Buggy Combined Turret")]
        public int TheVishnuGunActionPointToUsePerc = 75;
        public int TheVishnuGunChargesMaxAmmo = 8;
        public float TheVishnuGunDamage = 80f;
       
        [ConfigField("The Screamer (minigun)", "Kaos Buggy Sonic Turret")]
        public int TheScreamerminigunActionPointToUsePerc = 50;
        public int TheScreamerminigunChargesMaxAmmo = 64;
        public float TheScreamerminigunDamage = 50f;

        [ConfigField("The Screamer", "Kaos Buggy Sonic Turret")]
        public int TheScreamerActionPointToUsePerc = 50;
        public int TheScreamerChargesMaxAmmo = 4;
        public float TheScreamerDamage = 80f;
        public float TheScreamerSonic = 20f;

        [ConfigField("The Fullstop (minigun)", "Kaos Buggy Goo Turret")]
        public int TheFullstopminigunActionPointToUsePerc = 50;
        public int TheFullstopminigunChargesMaxAmmo = 64;
        public float TheFullstopminigunDamage = 50f;

        [ConfigField("The Fullstop", "Kaos Buggy Goo Turret")]
        public int TheFullstopActionPointToUsePerc = 50;
        public int TheFullstopChargesMaxAmmo = 1;
        public float TheFullstopDamage = 1f;

        [ConfigField("Launch Missiles Shoot", "Default Uses Per Turn = 1. For Gemini V and Scorpio VII")]
        public int LMSUsesPerTurn = 1;

        [ConfigField("Reinforced Cargo Racks", "Phoenix Scarab Hull Upgrade")]
        public float RCRValue = 6f;

        [ConfigField("Advanced Engine Mapping Module", "Phoenix Scarab Engine Upgrade")]
        public float AEMMValue = 6f;

        [ConfigField("Experimental Exhaust System", "Kaos Buggy Engine Upgrade")]
        public float EESValue = 5f;

        [ConfigField("Jet Boosters", "Kaos Buggy Engine Upgrade")]
        public float JBValue = 11f;

        [ConfigField("Research Lab", "An AI controlled facility for all research projects")]
        public float ResearchLabValue = 4f;

        [ConfigField("Fabrication Plant", "A factory facility that produces weapons, armor, equipment and vehicles")]
        public float FabricationPlantValue = 4f;

        [ConfigField("Cybernetics Lab", "Allow produces research")]
        public float CyberLabValue = 4f;

        [ConfigField("Food Production", "A food production facility that generates enough food for 8 soldiers each day.")]
        public float FoodProdValue = 0.33f;

        [ConfigField("Mutation Lab", "Allow produces mutagens - the raw material for mutation")]
        public float MutagenProdValue = 0.25f;

        [ConfigField("Living Quarters", "All soldiers at the base (even if assigned to an aircraft) will recover 2 stamina points per hour for each living quarters in the base")]
        public int SoldiersCapacityAmount = 8;
        public float BaseStaminaHealValue = 2f;

        [ConfigField("Medical Bay", "All soldiers at the base (even if assigned to an aircraft) will recover 4 Hit Points per hour for each medical facility in the base.")]
        public float BaseHealAmount = 4f;

        [ConfigField("Store", "A storage facility for all weapons, ammo, equipment and armor. Storage capacity is shared across all bases")]
        public int ItemsCapacityValue = 200;

        [ConfigField("Training Facility", "All soldiers at the base (even if assigned to an aircraft) will gain 2 Experience Points per hour for each training facility in the base")]
        public int SkillPointPerDayValue = 1;
        public int ExperiencePerUserValue = 2;

        [ConfigField("Skill Point Level", null)]
        public int SkillPointPerLevelValue = 20;

        [ConfigField("Max Strength", null)]
        public int MaxStrenghtValue = 35;
        [ConfigField("Max Will", null)]
        public int MaxWillValue = 20;
        [ConfigField("Max Speed", null)]
        public int MaxSpeedValue = 20;
        [ConfigField("Stamina", null)]
        public int StaminaValue = 40;
        [ConfigField("Tired Status Stamina Below", null)]
        public int TiredStatusStaminaBelowValue = 25;

        [ConfigField("Easy Skill Point", null)]
        public int SoldierSkillPointsPerMissionEasy = 12;
        [ConfigField("Standard Skill Point", null)]
        public int SoldierSkillPointsPerMissionStandart = 10;
        [ConfigField("Hard Skill Point", null)]
        public int SoldierSkillPointsPerMissionHard = 8;
        [ConfigField("Very Hard Skill Point", null)]
        public int SoldierSkillPointsPerMissionVeryHard = 5;

        [ConfigField("Faction Recruit", "Anu, New Jericho and Synedrion recruiting days")]
        public float FactionRecruitDaysInterval = 7f;

        [ConfigField("Phoenix Recruit", null)]
        public int NakedRecruitsSpawnIntervalDaysValue = 3;

        [ConfigField("Number soldiers", "Default number minimum = 1 and maximum = 7")]
        public int SoldierPhoenixMin = 1;
        public int SoldierPhoenixMax = 7;

        [ConfigField("Max Player Units", "Deploy army :)")]
        public int MaxPlayerUnitsValue = 8;

        [ConfigField("Anu Defense Haven", "Giving resource after complete mission defense")]
        public float AnuDefHavenSuppliesValue = 300f;
        public float AnuDefHavenMaterialsValue = 420f;
        public float AnuDefHavenTechValue = 50f;

        [ConfigField("New Jericho Defense Haven", "Giving resource after complete mission defense")]
        public float NJDefHavenSuppliesValue = 120f;
        public float NJDefHavenMaterialValue = 510f;
        public float NJDefHavenTechValue = 75f;

        [ConfigField("Synedrion Defense Haven", "Giving resource after complete mission defense")]
        public float SynDefHavenSuppliesValue = 180f;
        public float SynDefHavenMaterialValue = 420f;
        public float SynDefHavenTechValue = 100f;

        [ConfigField("Living Crystal", "Giving resource after complete mission")]
        public float LivingCrystalMaterialsValue = 1000f;
        public float LivingCrystalValue = 1f;

        [ConfigField("Orichalcium", "Giving resource after complete mission")]
        public float OrichalciumMaterialsValue = 1000f;
        public float OrichalciumValue = 1f;

        [ConfigField("Protean Mutagen", "Giving resource after complete mission")]
        public float ProteanMutagenMaterilasValue = 1000f;
        public float ProteanMutagenValue = 1f;

        [ConfigField("Refinery Ancient", "Giving resource after complete mission")]
        public float RefineryAncientMaterialsValue = 1000f;
    }
}
