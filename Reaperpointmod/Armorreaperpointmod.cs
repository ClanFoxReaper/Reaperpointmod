using Base.Core;
using Base.Defs;
using Base.Levels;
using HarmonyLib;
using PhoenixPoint.Common.Game;
using PhoenixPoint.Modding;
using PhoenixPoint.Tactical.Entities.Abilities;
using PhoenixPoint.Tactical.Entities.Equipments;
using PhoenixPoint.Tactical.Entities.Weapons;
using System.Linq;
using UnityEngine;

namespace Reaperpointmod
{
    internal class Armorreaperpointmod

    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;
        public static void ArmorReaper()
        {
            ReaperpointmodConfig ArmorReaperConfig = ReaperpointmodMain.Main.Config;
            TacticalItemDef GoldenHelmetForBoming = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Helmet_Gold_BodyPartDef"));
            //PX_Heavy_Helmet_Gold_BodyPartDef
            GoldenHelmetForBoming.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenHelmetHeavyForBorminPerception;
            GoldenHelmetForBoming.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenHelmetHeavyForBorminStealth;
            GoldenHelmetForBoming.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenHelmetHeavyForBorminAccuracy;

            TacticalItemDef GoldenTorsoForBormin = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Torso_Gold_BodyPartDef"));
            GoldenTorsoForBormin.BodyPartAspectDef.Speed = ArmorReaperConfig.GoldenTorsoHeavyForBorminSpeed;
            GoldenTorsoForBormin.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenTorsoHeavyForBorminPerception;
            GoldenTorsoForBormin.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenTorsoHeavyForBorminStealth;
            GoldenTorsoForBormin.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenTorsoHeavyForBorminAccuracy;

            TacticalItemDef GoldenLegsForBormin = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Legs_Gold_ItemDef"));
            GoldenLegsForBormin.BodyPartAspectDef.Speed = ArmorReaperConfig.GoldenLegsArmorHeavyForBorminSpeed;
            GoldenLegsForBormin.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenLegsArmorHeavyForBorminPerception;
            GoldenLegsForBormin.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenLegsArmorHeavyForBorminStealth;
            GoldenLegsForBormin.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenLegsArmorHeavyForBorminAccuracy;

            TacticalItemDef LivingHelmetForDux = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Chitin_Helmet_ItemDef"));
            LivingHelmetForDux.BodyPartAspectDef.Perception = ArmorReaperConfig.LivingHelmetArmorPerception;
            LivingHelmetForDux.BodyPartAspectDef.Stealth = ArmorReaperConfig.LivingHelmetArmorStealth;
            LivingHelmetForDux.BodyPartAspectDef.Accuracy = ArmorReaperConfig.LivingHelmetArmorAccuracy;

            TacticalItemDef LivingTorsoForDux = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Chitin_Torso_ItemDef"));
            LivingTorsoForDux.BodyPartAspectDef.Perception = ArmorReaperConfig.LivingTorsoArmorPerception;
            LivingTorsoForDux.BodyPartAspectDef.Stealth = ArmorReaperConfig.LivingTorsoArmorStealth;
            LivingTorsoForDux.BodyPartAspectDef.Accuracy = ArmorReaperConfig.LivingTorsoArmorAccuracy;

            TacticalItemDef LivingLegsForDux = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Chitin_Legs_ItemDef"));
            LivingLegsForDux.BodyPartAspectDef.Perception = ArmorReaperConfig.LivingLegsArmorPerception;
            LivingLegsForDux.BodyPartAspectDef.Stealth = ArmorReaperConfig.LivingLegsArmorStealth;
            LivingLegsForDux.BodyPartAspectDef.Accuracy = ArmorReaperConfig.LivingLegsArmorAccuracy;

            TacticalItemDef GoldenHelmetForSelma = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Sniper_Helmet_Gold_BodyPartDef"));
            GoldenHelmetForSelma.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenHelmetSniperForSelmaPerception;
            GoldenHelmetForSelma.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenHelmetSniperForSelmaStealth;
            GoldenHelmetForSelma.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenHelmetSniperForSelmaAccuracy;

            TacticalItemDef GoldenTorsoForSelma = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Sniper_Torso_Gold_BodyPartDef"));
            GoldenTorsoForSelma.BodyPartAspectDef.Speed = ArmorReaperConfig.GoldenTorsoSniperForSelmaSpeed;
            GoldenTorsoForSelma.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenTorsoSniperForSelmaPerception;
            GoldenTorsoForSelma.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenTorsoSniperForSelmaStealth;
            GoldenTorsoForSelma.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenTorsoSniperForSelmaAccuracy;

            TacticalItemDef GoldenLegsForSelma = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Sniper_Legs_Gold_ItemDef"));
            GoldenLegsForSelma.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenLegsArmorSniperForSelmaPerception;
            GoldenLegsForSelma.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenLegsArmorSniperForSelmaStealth;
            GoldenLegsForSelma.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenLegsArmorSniperForSelmaAccuracy;

            TacticalItemDef GoldenHelmetForMagnus = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Assault_Helmet_Gold_BodyPartDef"));
            GoldenHelmetForMagnus.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenHelmetAssaultForMagnusPerception;
            GoldenHelmetForMagnus.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenHelmetAssaultForMagnusStealth;
            GoldenHelmetForMagnus.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenHelmetAssaultForMagnusAccuracy;

            TacticalItemDef GoldenTorsoForMagnus = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Assault_Legs_Gold_ItemDef"));
            GoldenTorsoForMagnus.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenTorsoAssaultForMagnusPerception;
            GoldenTorsoForMagnus.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenTorsoAssaultForMagnusStealth;
            GoldenTorsoForMagnus.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenTorsoAssaultForMagnusAccuracy;

            TacticalItemDef GoldenLegsForMagnus = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Assault_Torso_Gold_BodyPartDef"));
            GoldenLegsForMagnus.BodyPartAspectDef.Speed = ArmorReaperConfig.GoldenLegsArmorAssaultForMagnusSpeed;
            GoldenLegsForMagnus.BodyPartAspectDef.Perception = ArmorReaperConfig.GoldenLegsArmorAssaultForMagnusPerception;
            GoldenLegsForMagnus.BodyPartAspectDef.Stealth = ArmorReaperConfig.GoldenLegsArmorAssaultForMagnusStealth;
            GoldenLegsForMagnus.BodyPartAspectDef.Accuracy = ArmorReaperConfig.GoldenLegsArmorAssaultForMagnusAccuracy;

            TacticalItemDef xmashelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Helmet_Christmas_BodyPartDef"));
            xmashelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.ChristmasHelmetHeavyPerception;
            xmashelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.ChristmasHelmetHeavyStealth;
            xmashelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.ChristmasHelmetHeavyAccuracy;

            TacticalItemDef xmastorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Torso_Christmas_BodyPartDef"));
            xmastorso.BodyPartAspectDef.Speed = ArmorReaperConfig.ChristmasTorsoHeavySpeed;
            xmastorso.BodyPartAspectDef.Perception = ArmorReaperConfig.ChristmasTorsoHeavyPerception;
            xmastorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.ChristmasTorsoHeavyStealth;
            xmastorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.ChristmasTorsoHeavyAccuracy;

            TacticalItemDef xmaslegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Legs_Christmas_ItemDef"));
            xmaslegs.BodyPartAspectDef.Speed = ArmorReaperConfig.ChristmasLegsArmorHeavySpeed;
            xmaslegs.BodyPartAspectDef.Perception = ArmorReaperConfig.ChristmasLegsArmorHeavyPerception;
            xmaslegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.ChristmasLegsArmorHeavyStealth;
            xmaslegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.ChristmasLegsArmorHeavyAccuracy;

            TacticalItemDef hunterhelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Helmet_Headhunter_BodyPartDef"));
            hunterhelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.HeadhunterHelmetHeavyPerception;
            hunterhelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.HeadhunterHelmetHeavyStealth;
            hunterhelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.HeadhunterHelmetHeavyAccuracy;

            TacticalItemDef huntertorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Torso_Headhunter_BodyPartDef"));
            huntertorso.BodyPartAspectDef.Speed = ArmorReaperConfig.HeadhunterTorsoHeavySpeed;
            huntertorso.BodyPartAspectDef.Perception = ArmorReaperConfig.HeadhunterTorsoHeavyPerception;
            huntertorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.HeadhunterTorsoHeavyStealth;
            huntertorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.HeadhunterTorsoHeavyAccuracy;

            TacticalItemDef hunterlegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Heavy_Legs_Headhunter_ItemDef"));
            hunterlegs.BodyPartAspectDef.Speed = ArmorReaperConfig.HeadhunterLegsArmorHeavySpeed;
            hunterlegs.BodyPartAspectDef.Perception = ArmorReaperConfig.HeadhunterLegsArmorHeavyPerception;
            hunterlegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.HeadhunterLegsArmorHeavyStealth;
            hunterlegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.HeadhunterLegsArmorHeavyAccuracy;

            TacticalItemDef SkyHelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Sniper_Helmet_RisingSun_BodyPartDef"));
            SkyHelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.RisingSunHelmetPerception;
            SkyHelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.RisingSunHelmetStealth;
            SkyHelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.RisingSunHelmetAccuracy;

            TacticalItemDef SkyTorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Sniper_Torso_RisingSun_BodyPartDef"));
            SkyTorso.BodyPartAspectDef.Speed = ArmorReaperConfig.RisingSunTorsoSpeed;
            SkyTorso.BodyPartAspectDef.Perception = ArmorReaperConfig.RisingSunTorsoPerception;
            SkyTorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.RisingSunTorsoStealth;
            SkyTorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.RisingSunTorsoAccuracy;

            TacticalItemDef SkyLegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("PX_Sniper_Legs_RisingSun_ItemDef"));
            SkyLegs.BodyPartAspectDef.Perception = ArmorReaperConfig.RisingSunLegsArmorPerception;
            SkyLegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.RisingSunLegsArmorStealth;
            SkyLegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.RisingSunLegsArmorAccuracy;

            TacticalItemDef VikingHelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("AN_Berserker_Helmet_Viking_BodyPartDef"));
            VikingHelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.HelmetVikingPerception;
            VikingHelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.HelmetVikingStealth;
            VikingHelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.HelmetVikingAccuracy;

            TacticalItemDef VikingTorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("AN_Berserker_Torso_Viking_BodyPartDef"));
            VikingTorso.BodyPartAspectDef.Speed = ArmorReaperConfig.TorsoVikingSpeed;
            VikingTorso.BodyPartAspectDef.Perception = ArmorReaperConfig.TorsoVikingPerception;
            VikingTorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.TorsoVikingStealth;
            VikingTorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.TorsoVikingAccuracy;
            
            TacticalItemDef VikingLegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("AN_Berserker_Legs_Viking_ItemDef"));
            VikingLegs.BodyPartAspectDef.Speed = ArmorReaperConfig.LegsArmorVikingSpeed;
            VikingLegs.BodyPartAspectDef.Perception = ArmorReaperConfig.LegsArmorVikingPerception;
            VikingLegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.LegsArmorVikingStealth;
            VikingLegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.LegsArmorVikingAccuracy;

            TacticalItemDef InkiHelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("AN_Priest_Head02_AZ_BodyPartDef"));
            InkiHelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.AztecHelmetPerception;
            InkiHelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.AztecHelmetStealth;
            InkiHelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.AztecHelmetAccuracy;

            TacticalItemDef InkiTorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("AN_Priest_Torso_AZ_BodyPartDef"));
            InkiTorso.BodyPartAspectDef.Perception = ArmorReaperConfig.AztecTorsoPerception;
            InkiTorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.AztecTorsoStealth;
            InkiTorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.AztecTorsoAccuracy;

            TacticalItemDef InkiLegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("AN_Priest_Legs_AZ_ItemDef"));
            InkiLegs.BodyPartAspectDef.Perception = ArmorReaperConfig.AztecLegsArmorPerception;
            InkiLegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.AztecLegsArmorStealth;
            InkiLegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.AztecLegsArmorAccuracy;

            TacticalItemDef AntiPandoranHelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("NJ_Technician_Helmet_ALN_BodyPartDef"));
            AntiPandoranHelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.PandoranHelmetTechnicianPerception;
            AntiPandoranHelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.PandoranHelmetTechnicianStealth;
            AntiPandoranHelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.PandoranHelmetTechnicianAccuracy;

            TacticalItemDef AntiPandoranTorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("NJ_Technician_Torso_ALN_BodyPartDef"));
            AntiPandoranTorso.BodyPartAspectDef.Speed = ArmorReaperConfig.PandoranTorsoTechnicianSpeed;
            AntiPandoranTorso.BodyPartAspectDef.Perception = ArmorReaperConfig.PandoranTorsoTechnicianPerception;
            AntiPandoranTorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.PandoranTorsoTechnicianStealth;
            AntiPandoranTorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.PandoranTorsoTechnicianAccuracy;

            TacticalItemDef AntiPandoranLegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("NJ_Technician_Legs_ALN_ItemDef"));
            AntiPandoranLegs.BodyPartAspectDef.Speed = ArmorReaperConfig.PandoranLegsArmorTechnicianSpeed;
            AntiPandoranLegs.BodyPartAspectDef.Perception = ArmorReaperConfig.PandoranLegsArmorTechnicianPerception;
            AntiPandoranLegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.PandoranLegsArmorTechnicianStealth;
            AntiPandoranLegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.PandoranLegsArmorTechnicianAccuracy;

            TacticalItemDef KaosHelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Infiltrator_Bonus_Helmet_BodyPartDef"));
            KaosHelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.KaosHelmetPerception;
            KaosHelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.KaosHelmetStealth;
            KaosHelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.KaosHelmetAccuracy;

            TacticalItemDef KaosTorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Infiltrator_Bonus_Torso_BodyPartDef"));

            KaosTorso.BodyPartAspectDef.Perception = ArmorReaperConfig.KaosTorsoPerception;
            KaosTorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.KaosTorsoStealth;
            KaosTorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.KaosTorsoAccuracy;

            TacticalItemDef KaosLegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Infiltrator_Bonus_Legs_ItemDef"));

            KaosLegs.BodyPartAspectDef.Perception = ArmorReaperConfig.KaosLegsArmorPerception;
            KaosLegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.KaosLegsArmorStealth;
            KaosLegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.KaosLegsArmorAccuracy;

            TacticalItemDef microsoftxboxhelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Assault_Helmet_Neon_BodyPartDef"));
            microsoftxboxhelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.NeonHelmetPerception;
            microsoftxboxhelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.NeonHelmetStealth;
            microsoftxboxhelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.NeonHelmetAccuracy;
            
            TacticalItemDef microsoftxboxtorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Assault_Torso_Neon_BodyPartDef"));
            microsoftxboxtorso.BodyPartAspectDef.Speed = ArmorReaperConfig.NeonTorsoSpeed;
            microsoftxboxtorso.BodyPartAspectDef.Perception = ArmorReaperConfig.NeonTorsoPerception;
            microsoftxboxtorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.NeonTorsoStealth;
            microsoftxboxtorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.NeonTorsoAccuracy;
            
            TacticalItemDef microsoftxboxlegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Assault_Legs_Neon_ItemDef"));
            microsoftxboxlegs.BodyPartAspectDef.Speed = ArmorReaperConfig.NeonLegsArmorSpeed;
            microsoftxboxlegs.BodyPartAspectDef.Perception = ArmorReaperConfig.NeonLegsArmorPerception;
            microsoftxboxlegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.NeonLegsArmorStealth;
            microsoftxboxlegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.NeonLegsArmorAccuracy;

            TacticalItemDef sonyplaystationhelmet = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Assault_Helmet_WhiteNeon_BodyPartDef"));
            sonyplaystationhelmet.BodyPartAspectDef.Perception = ArmorReaperConfig.WhiteNeonHelmetPerception;
            sonyplaystationhelmet.BodyPartAspectDef.Stealth = ArmorReaperConfig.WhiteNeonHelmetStealth;
            sonyplaystationhelmet.BodyPartAspectDef.Accuracy = ArmorReaperConfig.WhiteNeonHelmetAccuracy;

            TacticalItemDef sonyplaystationtorso = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Assault_Torso_WhiteNeon_BodyPartDef"));
            sonyplaystationtorso.BodyPartAspectDef.Speed = ArmorReaperConfig.WhiteNeonTorsoSpeed;
            sonyplaystationtorso.BodyPartAspectDef.Perception = ArmorReaperConfig.WhiteNeonTorsoPerception;
            sonyplaystationtorso.BodyPartAspectDef.Stealth = ArmorReaperConfig.WhiteNeonTorsoStealth;
            sonyplaystationtorso.BodyPartAspectDef.Accuracy = ArmorReaperConfig.WhiteNeonTorsoAccuracy;

            TacticalItemDef sonyplaystationlegs = Armorreaperpointmod.Repo.GetAllDefs<TacticalItemDef>().FirstOrDefault(a => a.name.Equals("SY_Assault_Legs_WhiteNeon_ItemDef"));
            sonyplaystationlegs.BodyPartAspectDef.Speed = ArmorReaperConfig.WhiteNeonLegsArmorSpeed;
            sonyplaystationlegs.BodyPartAspectDef.Perception = ArmorReaperConfig.WhiteNeonLegsArmorPerception;
            sonyplaystationlegs.BodyPartAspectDef.Stealth = ArmorReaperConfig.WhiteNeonLegsArmorStealth;
            sonyplaystationlegs.BodyPartAspectDef.Accuracy = ArmorReaperConfig.WhiteNeonLegsArmorAccuracy;







        }

        
         
    }  
}
