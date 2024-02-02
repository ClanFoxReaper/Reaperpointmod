using Base.Core;
using Base.Defs;
using Base.Levels;
using PhoenixPoint.Common.Game;
using PhoenixPoint.Modding;
using Code.PhoenixPoint.Tactical.Entities.Equipments;
using PhoenixPoint.Tactical.Entities.Abilities;
using PhoenixPoint.Geoscape.Entities.Research;
using PhoenixPoint.Geoscape.Entities.Research.Cost;
using PhoenixPoint.Geoscape.Entities.Research.Requirement;
using PhoenixPoint.Geoscape.Entities.Research.Reward;
using PhoenixPoint.Tactical.Entities.Statuses;
using PhoenixPoint.Tactical.Entities.Weapons;
using System.Linq;
using UnityEngine;

namespace Reaperpointmod
{
    internal class ReaperpointmodResearch
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void ReaperResearch()
        {
            ReaperpointmodConfig ReaperResearchConfig = ReaperpointmodMain.Main.Config;

            ResearchDef TheExalted = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_DisciplesOfAnu_ResearchDef"));
            TheExalted.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies, 
                Value = ReaperResearchConfig.SuppliesValue * 70
            };

            ResearchDef TobiasWest = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_NewJericho_ResearchDef"));
            TobiasWest.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperResearchConfig.MaterialsValue * 70
            };

            ResearchDef AthenaBarnabasNikolaiStasZhara = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Synedrion_ResearchDef"));
            AthenaBarnabasNikolaiStasZhara.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperResearchConfig.TechValue * 70
            };

            ResearchDef PandoranEvol = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_EvolvedAliens_ResearchDef"));
            PandoranEvol.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperResearchConfig.PandoranEvoleMaterialsValue * 70
            };
            PandoranEvol.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperResearchConfig.PandoranEvoleTechValue * 70
            };

            ResearchDef ColonyPandoran = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Colony_ResearchDef"));
            ColonyPandoran.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies,
                Value = ReaperResearchConfig.PandoranColonySuppliesValue * 70
            };
            ColonyPandoran.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperResearchConfig.PandoranColonyMaterialsValue * 70
            };
            ColonyPandoran.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperResearchConfig.PandoranColonyTechValue * 70
            };

            ResearchDef LairPandoran = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Lair_ResearchDef"));
            LairPandoran.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies,
                Value = ReaperResearchConfig.PandoranLairSuppliesValue * 70
            };
            LairPandoran.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperResearchConfig.PandoranLairMaterialsValue * 70
            };
            LairPandoran.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperResearchConfig.PandoranLairTechValue * 70
            };

            ResearchDef ScyllaQueen = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Queen_ResearchDef"));
            ScyllaQueen.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies, 
                Value = ReaperResearchConfig.ScyllaResearcSuppliesValue * 70 
            };
            ScyllaQueen.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperResearchConfig.ScyllaResearcMaterialsValue * 70
            };
            ScyllaQueen.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperResearchConfig.ScyllaResearcTechValue * 70
            };

            ResearchDef MutoidCreate = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Mutoid_ResearchDef"));
            MutoidCreate.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Mutagen,
                Value = ReaperResearchConfig.MutoidMutagensValue * 70
            };

            ResearchDef AcheronAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Acheron_ResearchDef"));
            AcheronAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Mutagen,
                Value = ReaperResearchConfig.AcheronMutagensValue * 70
            };
            ResearchDef MindfraggerAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Mindfragger_ResearchDef"));
            ResearchDef FirewormAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Fireworm_ResearchDef"));
            ResearchDef PoisonwormAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Poisonworm_ResearchDef"));
            ResearchDef AcidwormAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Acidworm_ResearchDef"));
            ResearchDef MindfraggerEggAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_MindfraggerEgg_ResearchDef"));
            ResearchDef WormEggAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_WormEgg_ResearchDef"));
            ResearchDef SirenAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Siren_ResearchDef"));
            ResearchDef ChironAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Chiron_ResearchDef"));

            MindfraggerAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.MindfraggerMaterialsValue * 70 
            };
            FirewormAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.FirewormMaterialsValue * 70 
            };
            PoisonwormAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.PoisonwormMaterialsValue * 70 
            };
            AcidwormAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.AcidwormMaterialsValue * 70 
            };
            MindfraggerEggAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.MindfraggerEggMaterialsValue * 70 
            };
            MindfraggerEggAutopsy.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies, 
                Value = ReaperResearchConfig.MindfraggerEggSuppliesValue * 70 
            };
            WormEggAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.WormEggMaterialsValue * 70 
            };
            WormEggAutopsy.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies, 
                Value = ReaperResearchConfig.WormEggSuppliesValue * 70 
            };
            SirenAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.SirenMaterialsValue * 70 
            };
            ChironAutopsy.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Materials, 
                Value = ReaperResearchConfig.ChironMaterialsValue * 70 
            };
            ChironAutopsy.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies, 
                Value = ReaperResearchConfig.ChironSuppliesValue * 70 
            };
            ChironAutopsy.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Tech, 
                Value = ReaperResearchConfig.ChironTechValue * 70 
            };

            DamageMultiplierStatusDef MindfraggerVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToFacehugger_FactionEffectDef]"));
            MindfraggerVivisection.Multiplier = ReaperResearchConfig.MindFraggerDamageMultiplier;

            DamageMultiplierStatusDef FirewormVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToFireworm_FactionEffectDef]"));
            FirewormVivisection.Multiplier = ReaperResearchConfig.FirewormDamageMultiplier;
            
            DamageMultiplierStatusDef PoisonwormVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToPoisonworm_FactionEffectDef]"));
            PoisonwormVivisection.Multiplier = ReaperResearchConfig.PoisonwormDamageMultiplier;

            DamageMultiplierStatusDef AcidwormVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToAcidworm_FactionEffectDef]"));
            AcidwormVivisection.Multiplier = ReaperResearchConfig.AcidwormDamageMultiplier;

            DamageMultiplierStatusDef ArthronVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToCrabman_FactionEffectDef]"));
            ArthronVivisection.Multiplier = ReaperResearchConfig.ArthronDamageMultiplier;

            DamageMultiplierStatusDef TritonVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToFishman_FactionEffectDef]"));
            TritonVivisection.Multiplier = ReaperResearchConfig.TritonDamageMultiplier;

            DamageMultiplierStatusDef SirenVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToSiren_FactionEffectDef]"));
            SirenVivisection.Multiplier = ReaperResearchConfig.SirenDamageMultiplier;

            DamageMultiplierStatusDef ChironVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToChiron_FactionEffectDef]"));
            ChironVivisection.Multiplier = ReaperResearchConfig.ChironDamageMultiplier;

            DamageMultiplierStatusDef ScyllaVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToQueen_FactionEffectDef]"));
            ScyllaVivisection.Multiplier = ReaperResearchConfig.ScyllaDamageMultiplier;

            DamageMultiplierStatusDef TerrorSentinel = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToSentinelTerror_FactionEffectDef]"));
            TerrorSentinel.Multiplier = ReaperResearchConfig.TerrorSentinelDamageMultiplier;

            DamageMultiplierStatusDef HatchingSentinel = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToSentinelHatching_FactionEffectDef]"));
            HatchingSentinel.Multiplier = ReaperResearchConfig.HatchingSentinelDamageMultiplier;

            DamageMultiplierStatusDef MistSentinel = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToSentinelMist_FactionEffectDef]"));
            MistSentinel.Multiplier = ReaperResearchConfig.MistSentinelDamageMultiplier;

            DamageMultiplierStatusDef PandoranSpawnery = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToSpawnery_FactionEffectDef]"));
            PandoranSpawnery.Multiplier = ReaperResearchConfig.PandoranSpawneryDamageMultiplier;

            DamageMultiplierStatusDef AcheronVivisection = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToAcheron_FactionEffectDef]"));
            AcheronVivisection.Multiplier = ReaperResearchConfig.AcheronDamageMultiplier;

            DamageMultiplierStatusDef MoonDataAnalys = ReaperpointmodResearch.Repo.GetAllDefs<DamageMultiplierStatusDef>().FirstOrDefault(a => a.name.Equals("E_Status [DamageBonusToAliens_FactionEffectDef]"));
            MoonDataAnalys.Multiplier = ReaperResearchConfig.MoonDataAnalysDamageMultiplier;

            FactionModifierResearchRewardDef ProtoCiv = ReaperpointmodResearch.Repo.GetAllDefs<FactionModifierResearchRewardDef>().FirstOrDefault(a => a.name.Equals("PX_ProtoCivilisation1_ResearchDef_FactionModifierResearchRewardDef_0"));
            ProtoCiv.ExperienceAfterMissionModifier = ReaperResearchConfig.EAMModifier;

            ResearchDef AnuAlienReligion = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("ANU_AlienReligion_ResearchDef"));

            AnuAlienReligion.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies, 
                Value = ReaperResearchConfig.AARSuppliesValue * 70 
            };
            AnuAlienReligion.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit 
            { 
                Type = PhoenixPoint.Common.Core.ResourceType.Tech, 
                Value = ReaperResearchConfig.AARTechValue * 70 
            };

            ResearchBonusResearchRewardDef NewJerichoPandoranPhysiology = ReaperpointmodResearch.Repo.GetAllDefs<ResearchBonusResearchRewardDef>().FirstOrDefault(a => a.name.Equals("NJ_AlienPhysiology_ResearchDef_ResearchBonusResearchRewardDef_0"));
            NewJerichoPandoranPhysiology.Amount = ReaperResearchConfig.NJPandoranPhyliologyAmount;
            FacilityBuffResearchRewardDef ProductionRobotics = ReaperpointmodResearch.Repo.GetAllDefs<FacilityBuffResearchRewardDef>().FirstOrDefault(a => a.name.Equals("NJ_AutomatedFactories_ResearchDef_FacilityBuffResearchRewardDef_0"));
            ProductionRobotics.Increase = ReaperResearchConfig.NJProdRobotAmount;
            FacilityBuffResearchRewardDef CentralizedAI = ReaperpointmodResearch.Repo.GetAllDefs<FacilityBuffResearchRewardDef>().FirstOrDefault(a => a.name.Equals("NJ_CentralizedAI_ResearchDef_FacilityBuffResearchRewardDef_0"));
            CentralizedAI.Increase = ReaperResearchConfig.NJCentralAIAmount;
            FactionModifierResearchRewardDef NJSU = ReaperpointmodResearch.Repo.GetAllDefs<FactionModifierResearchRewardDef>().FirstOrDefault(a => a.name.Equals("NJ_SateliteUplink_ResearchDef_FactionModifierResearchRewardDef_0"));
            NJSU.ScannerRangeModifier = ReaperResearchConfig.NJSUScannerRangeAmount;

            FacilityBuffResearchRewardDef SynFusionCellTech = ReaperpointmodResearch.Repo.GetAllDefs<FacilityBuffResearchRewardDef>().FirstOrDefault(a => a.name.Equals("SYN_FusionCellTech_ResearchDef_FacilityBuffResearchRewardDef_0"));
            SynFusionCellTech.Increase = ReaperResearchConfig.NFTAmount;
            FacilityBuffResearchRewardDef SynNanoHealing = ReaperpointmodResearch.Repo.GetAllDefs<FacilityBuffResearchRewardDef>().FirstOrDefault(a => a.name.Equals("SYN_NanoHealing_ResearchDef_FacilityBuffResearchRewardDef_0"));
            SynNanoHealing.Increase = ReaperResearchConfig.NanoHealingAmount;
            FacilityBuffResearchRewardDef SynSAItech = ReaperpointmodResearch.Repo.GetAllDefs<FacilityBuffResearchRewardDef>().FirstOrDefault(a => a.name.Equals("SYN_SentientAITech_ResearchDef_FacilityBuffResearchRewardDef_0"));
            SynSAItech.Increase = ReaperResearchConfig.SentientAIsAmount;

        }
    }
}
