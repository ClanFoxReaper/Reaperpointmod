using Base.Defs;
using Base.Core;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Common.Entities.Characters;
using System.Linq;
using PhoenixPoint.Common.Levels.Missions;
using PhoenixPoint.Geoscape.Levels;
using PhoenixPoint.Geoscape.Levels.Factions;
using PhoenixPoint.Tactical.Levels.Missions;

namespace Reaperpointmod
{
    internal class ReaperpointmodSquad
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void ReaperSquad()
        {
            ReaperpointmodConfig ReaperSquadConfig = ReaperpointmodMain.Main.Config;

            LevelProgressionDef LevelReaper = ReaperpointmodSquad.Repo.GetAllDefs<LevelProgressionDef>().FirstOrDefault(a => a.name.Equals("LevelProgressionDef"));
            LevelReaper.SkillpointsPerLevel = ReaperSquadConfig.SkillPointPerLevelValue;

            BaseStatSheetDef StatsReaper = ReaperpointmodSquad.Repo.GetAllDefs<BaseStatSheetDef>().FirstOrDefault(a => a.name.Equals("HumanSoldier_BaseStatSheetDef"));
            StatsReaper.MaxStrength = ReaperSquadConfig.MaxStrenghtValue;
            StatsReaper.MaxWill = ReaperSquadConfig.MaxWillValue;
            StatsReaper.MaxSpeed = ReaperSquadConfig.MaxSpeedValue;
            StatsReaper.Stamina = ReaperSquadConfig.StaminaValue;
            StatsReaper.TiredStatusStaminaBelow = ReaperSquadConfig.TiredStatusStaminaBelowValue;

            GameDifficultyLevelDef EasySkill = ReaperpointmodSquad.Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a=>a.name.Equals("Easy_GameDifficultyLevelDef"));
            EasySkill.SoldierSkillPointsPerMission = ReaperSquadConfig.SoldierSkillPointsPerMissionEasy;

            GameDifficultyLevelDef NormalSkill = ReaperpointmodSquad.Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("Standard_GameDifficultyLevelDef"));
            NormalSkill.SoldierSkillPointsPerMission = ReaperSquadConfig.SoldierSkillPointsPerMissionStandart;

            GameDifficultyLevelDef HardSkill = ReaperpointmodSquad.Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("Hard_GameDifficultyLevelDef"));
            HardSkill.SoldierSkillPointsPerMission = ReaperSquadConfig.SoldierSkillPointsPerMissionHard;

            GameDifficultyLevelDef VeryHardSkill = ReaperpointmodSquad.Repo.GetAllDefs<GameDifficultyLevelDef>().FirstOrDefault(a => a.name.Equals("VeryHard_GameDifficultyLevelDef"));
            VeryHardSkill.SoldierSkillPointsPerMission = ReaperSquadConfig.SoldierSkillPointsPerMissionVeryHard;

            DefRepository RSRepo = GameUtl.GameComponent<DefRepository>();
            foreach (TacMissionTypeDef tac in RSRepo.DefRepositoryDef.AllDefs.OfType<TacMissionTypeDef>().ToList())
            {
                tac.MaxPlayerUnits = ReaperSquadConfig.MaxPlayerUnitsValue;                
            }
             

            GeoFactionDef AnuRecruit = ReaperpointmodSquad.Repo.GetAllDefs<GeoFactionDef>().FirstOrDefault(a=>a.name.Equals("Anu_GeoFactionDef"));
            GeoFactionDef NJRecruit = ReaperpointmodSquad.Repo.GetAllDefs<GeoFactionDef>().FirstOrDefault(a=>a.name.Equals("NewJericho_GeoFactionDef"));
            GeoFactionDef SynedRecruit = ReaperpointmodSquad.Repo.GetAllDefs<GeoFactionDef>().FirstOrDefault(a=>a.name.Equals("Synedrion_GeoFactionDef"));
            AnuRecruit.RecruitIntervalCheckDays = ReaperSquadConfig.FactionRecruitDaysInterval;
            NJRecruit.RecruitIntervalCheckDays = ReaperSquadConfig.FactionRecruitDaysInterval;
            SynedRecruit.RecruitIntervalCheckDays = ReaperSquadConfig.FactionRecruitDaysInterval;

            GeoPhoenixFactionDef PP = ReaperpointmodSquad.Repo.GetAllDefs<GeoPhoenixFactionDef>().FirstOrDefault(a => a.name.Equals("Phoenix_GeoPhoenixFactionDef"));
            PP.NakedRecruitsSpawnIntervalDays = ReaperSquadConfig.NakedRecruitsSpawnIntervalDaysValue;
            PP.MaxNakedRecruitsAvailability = new Base.Utils.RangeDataInt(ReaperSquadConfig.SoldierPhoenixMin, ReaperSquadConfig.SoldierPhoenixMax);
        }
    }
}
