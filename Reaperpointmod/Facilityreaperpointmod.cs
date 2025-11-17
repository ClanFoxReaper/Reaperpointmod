using Base.Defs;
using PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents;
using PhoenixPoint.Common.Core;
using System.Linq;

namespace Reaperpointmod
{
    internal class Facilityreaperpointmod
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void FacilityReaper()
        {
            ReaperpointmodConfig ReaperFacilityConfig = ReaperpointmodMain.Main.Config;

            ResourceGeneratorFacilityComponentDef Lab = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [ResearchLab_PhoenixFacilityDef]"));
            Lab.BaseResourcesOutput[0] = new ResourceUnit
            {
                Type = ResourceType.Research,
                Value = ReaperFacilityConfig.ResearchLabValue
            };
            Lab.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Tech, 1.84f));

            ResourceGeneratorFacilityComponentDef Fabrica = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [FabricationPlant_PhoenixFacilityDef]"));
            Fabrica.BaseResourcesOutput[0] = new ResourceUnit
            {
                Type = ResourceType.Production,
                Value = ReaperFacilityConfig.FabricationPlantValue
            };
            Fabrica.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Materials, 1.84f));

            ResourceGeneratorFacilityComponentDef Cyber = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [BionicsLab_PhoenixFacilityDef]"));
            Cyber.BaseResourcesOutput[0] = new ResourceUnit
            {
                Type = ResourceType.Research,
                Value = ReaperFacilityConfig.CyberLabValue
            };
            Cyber.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Materials, 17.15f));
            Cyber.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Tech, 6.78f));

            ResourceGeneratorFacilityComponentDef FoodMaterialsTech = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [FoodProduction_PhoenixFacilityDef]"));
            FoodMaterialsTech.BaseResourcesOutput[0] = new ResourceUnit
            {
                Type = ResourceType.Supplies,
                Value = ReaperFacilityConfig.FoodProdValue
            };
            FoodMaterialsTech.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Materials, 17.15f));
            FoodMaterialsTech.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Tech, 6.78f));

            ResourceGeneratorFacilityComponentDef Mutagen = Facilityreaperpointmod.Repo.GetAllDefs<ResourceGeneratorFacilityComponentDef>().FirstOrDefault(a => a.name.Equals("E_ResourceGenerator [MutationLab_PhoenixFacilityDef]"));
            Mutagen.BaseResourcesOutput[0] = new ResourceUnit
            {
                Type = ResourceType.Mutagen,
                Value = ReaperFacilityConfig.MutagenProdValue
            };
            Mutagen.BaseResourcesOutput.Add(new ResourceUnit(ResourceType.Supplies, 3.08f));

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
