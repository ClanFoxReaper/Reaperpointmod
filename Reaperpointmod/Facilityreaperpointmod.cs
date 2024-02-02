using Base.Core;
using Base.Defs;
using Base.Levels;
using PhoenixPoint.Common.Game;
using PhoenixPoint.Modding;
using PhoenixPoint.Common.Levels.MapGeneration;
using PhoenixPoint.Common.Entities.Items;
using PhoenixPoint.Geoscape.Entities.PhoenixBases;
using PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents;
using System.Linq;
using UnityEngine;

namespace Reaperpointmod
{
    internal class Facilityreaperpointmod
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void FacilityReaper()
        {
            ReaperpointmodConfig ReaperFacilityConfig = ReaperpointmodMain.Main.Config;

            ResourceGeneratorFacilityComponentDef Lab = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [ResearchLab_PhoenixFacilityDef]"));
            Lab.BaseResourcesOutput[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Research,
                Value = ReaperFacilityConfig.ResearchLabValue
            };

            ResourceGeneratorFacilityComponentDef Fabrica = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [FabricationPlant_PhoenixFacilityDef]"));
            Fabrica.BaseResourcesOutput[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Production,
                Value = ReaperFacilityConfig.FabricationPlantValue
            };

            ResourceGeneratorFacilityComponentDef Cyber = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [BionicsLab_PhoenixFacilityDef]"));
            Cyber.BaseResourcesOutput[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Research,
                Value = ReaperFacilityConfig.CyberLabValue
            };

            ResourceGeneratorFacilityComponentDef FoodMaterialsTech = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [FoodProduction_PhoenixFacilityDef]"));
            FoodMaterialsTech.BaseResourcesOutput[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies,
                Value = ReaperFacilityConfig.FoodProdValue
            };
            FoodMaterialsTech.BaseResourcesOutput.Add(new PhoenixPoint.Common.Core.ResourceUnit(PhoenixPoint.Common.Core.ResourceType.Materials, ReaperFacilityConfig.FoodProdValue));
            FoodMaterialsTech.BaseResourcesOutput.Add(new PhoenixPoint.Common.Core.ResourceUnit(PhoenixPoint.Common.Core.ResourceType.Tech, ReaperFacilityConfig.FoodProdValue));

            ResourceGeneratorFacilityComponentDef Mutagen = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [MutationLab_PhoenixFacilityDef]"));
            Mutagen.BaseResourcesOutput[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Mutagen,
                Value = ReaperFacilityConfig.MutagenProdValue
            };

            ContainerFacilityComponentDef LivingQuarters = Facilityreaperpointmod.Repo.GetAllDefs<ContainerFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_Container [LivingQuarters_PhoenixFacilityDef]"));
            LivingQuarters.SoldiersCapacity = ReaperFacilityConfig.SoldiersCapacityAmount;
            ContainerFacilityComponentDef ItemsStore = Facilityreaperpointmod.Repo.GetAllDefs<ContainerFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_Container [Stores_PhoenixFacilityDef]"));
            ItemsStore.ItemsCapacity = ReaperFacilityConfig.ItemsCapacityValue;

            HealFacilityComponentDef Health = Facilityreaperpointmod.Repo.GetAllDefs<HealFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_Heal [MedicalBay_PhoenixFacilityDef]"));
            Health.BaseHeal = ReaperFacilityConfig.BaseHealAmount;
            HealFacilityComponentDef StaminaHealth = Facilityreaperpointmod.Repo.GetAllDefs<HealFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_Heal [LivingQuarters_PhoenixFacilityDef]"));
            StaminaHealth.BaseStaminaHeal = ReaperFacilityConfig.BaseStaminaHealValue;

            ExperienceFacilityComponentDef ExpSkillPoint = Facilityreaperpointmod.Repo.GetAllDefs<ExperienceFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_Experience [TrainingFacility_PhoenixFacilityDef]"));
            ExpSkillPoint.SkillPointsPerDay = ReaperFacilityConfig.SkillPointPerDayValue;
            ExpSkillPoint.ExperiencePerUser = ReaperFacilityConfig.ExperiencePerUserValue;
        }
    }
}
