using Base.Levels;
using Base.Defs;
using Base.Core;
using PhoenixPoint.Common.Game;
using Code.PhoenixPoint.Tactical.Entities.Equipments;
using PhoenixPoint.Modding;
using PhoenixPoint.Geoscape.Entities.Missions.Outcomes;
using System.Linq;
using UnityEngine;

namespace Reaperpointmod
{
    internal class ReaperpointmodMissionReward
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void ReaperMissionReward()
        {
            ReaperpointmodConfig ReaperMissionRewardConfig = ReaperpointmodMain.Main.Config;

            ResourceMissionOutcomeDef AnuHavenDefend = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a=>a.name.Equals("HavenDefAN_ResourceMissionOutcomeDef"));
            ResourceMissionOutcomeDef NJHavenDefend = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a => a.name.Equals("HavenDefNJ_ResourceMissionOutcomeDef"));
            ResourceMissionOutcomeDef SynedHavenDefend = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a => a.name.Equals("HavenDefSY_ResourceMissionOutcomeDef"));
            ResourceMissionOutcomeDef AncientChystalLiving = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a => a.name.Equals("AncientsHarvestCrystalMissionOutcomeDef"));
            ResourceMissionOutcomeDef AncientOrichalcum = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a => a.name.Equals("AncientsHarvestOrichalcumMissionOutcomeDef"));
            ResourceMissionOutcomeDef AncientProteanMutagen = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a => a.name.Equals("AncientsHarvestProteanMissionOutcomeDef"));
            ResourceMissionOutcomeDef AncientRefinery = ReaperpointmodMissionReward.Repo.GetAllDefs<ResourceMissionOutcomeDef>().FirstOrDefault(a => a.name.Equals("AncientsRefineryMissionOutcomeDef"));

            AnuHavenDefend.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies,
                Value = ReaperMissionRewardConfig.AnuDefHavenSuppliesValue * 44
            };
            AnuHavenDefend.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.AnuDefHavenMaterialsValue
            };
            AnuHavenDefend.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperMissionRewardConfig.AnuDefHavenTechValue
            };

            NJHavenDefend.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies,
                Value = ReaperMissionRewardConfig.NJDefHavenSuppliesValue
            };
            NJHavenDefend.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.NJDefHavenMaterialValue * 41
            };
            NJHavenDefend.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperMissionRewardConfig.NJDefHavenTechValue
            };
            SynedHavenDefend.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Supplies,
                Value = ReaperMissionRewardConfig.SynDefHavenSuppliesValue
            };
            SynedHavenDefend.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.SynDefHavenMaterialValue
            };
            SynedHavenDefend.Resources[2] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Tech,
                Value = ReaperMissionRewardConfig.SynDefHavenTechValue * 32
            };
            AncientChystalLiving.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.LivingCrystalMaterialsValue
            };
            AncientChystalLiving.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.LivingCrystals,
                Value = ReaperMissionRewardConfig.LivingCrystalValue
            };
            AncientOrichalcum.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.OrichalciumMaterialsValue
            };
            AncientOrichalcum.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Orichalcum,
                Value = ReaperMissionRewardConfig.OrichalciumValue
            };
            AncientProteanMutagen.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.ProteanMutagenMaterilasValue
            };
            AncientProteanMutagen.Resources[1] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.ProteanMutane,
                Value = ReaperMissionRewardConfig.ProteanMutagenValue
            };
            AncientRefinery.Resources[0] = new PhoenixPoint.Common.Core.ResourceUnit
            {
                Type = PhoenixPoint.Common.Core.ResourceType.Materials,
                Value = ReaperMissionRewardConfig.RefineryAncientMaterialsValue
            };
        }
    }
}
