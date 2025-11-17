using Base.Defs;
using Base.Core;
using PhoenixPoint.Geoscape.Entities.Research;
using PhoenixPoint.Geoscape.Entities.Research.Reward;
using PhoenixPoint.Tactical.Entities.Statuses;
using PhoenixPoint.Common.Core;
using System.Linq;

namespace Reaperpointmod
{
    internal class ReaperpointmodResearch
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void ReaperResearch()
        {
            ReaperpointmodConfig ReaperResearchConfig = ReaperpointmodMain.Main.Config;
            ResearchDef TheExalted = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_DisciplesOfAnu_ResearchDef"));
            TheExalted.Resources = new ResourcePack()
            {
                new ResourceUnit
              {
                Type = ResourceType.Supplies,
                Value = ReaperResearchConfig.SuppliesValue
              }
            };
            ResearchDef TobiasWest = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_NewJericho_ResearchDef"));
            TobiasWest.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                   Type = ResourceType.Materials,
                   Value = ReaperResearchConfig.MaterialsValue
                }

            };
            ResearchDef AthenaBarnabasNikolaiStasZhara = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Synedrion_ResearchDef"));
            AthenaBarnabasNikolaiStasZhara.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                Type = ResourceType.Tech,
                Value = ReaperResearchConfig.TechValue
                }
            };
            ResearchDef PandoranEvol = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_EvolvedAliens_ResearchDef"));
            PandoranEvol.Resources = new ResourcePack
            {
              new ResourceUnit
              {
                  Type = ResourceType.Materials,
                  Value = ReaperResearchConfig.PandoranEvoleMaterialsValue
              },
              new ResourceUnit
              {
                  Type = ResourceType.Tech,
                  Value = ReaperResearchConfig.PandoranEvoleTechValue
              }
            };
            
            
            ResearchDef ColonyPandoran = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Colony_ResearchDef"));
            ColonyPandoran.Resources = new ResourcePack()
            {
              new ResourceUnit
              {
                    Type = ResourceType.Supplies,
                    Value = ReaperResearchConfig.PandoranColonySuppliesValue
              },
              new ResourceUnit
              {
                  Type = ResourceType.Materials,
                  Value = ReaperResearchConfig.PandoranColonyMaterialsValue
              },
              new ResourceUnit
              {
                  Type = ResourceType.Tech,
                  Value = ReaperResearchConfig.PandoranColonyTechValue
              }
            };
            ResearchDef LairPandoran = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Lair_ResearchDef"));
            LairPandoran.Resources = new ResourcePack()
            {
            new ResourceUnit
            {
                Type = ResourceType.Supplies,
                Value = ReaperResearchConfig.PandoranLairSuppliesValue
            },
              new ResourceUnit
              {
                  Type = ResourceType.Materials,
                  Value = ReaperResearchConfig.PandoranLairMaterialsValue
              },
              new ResourceUnit
              {
                  Type = ResourceType.Tech,
                  Value = ReaperResearchConfig.PandoranLairTechValue
              }
            };
            ResearchDef ScyllaQueen = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Queen_ResearchDef"));
            ScyllaQueen.Resources = new ResourcePack()
            {
                  new ResourceUnit
                  {
                      Type = ResourceType.Supplies,
                      Value = ReaperResearchConfig.ScyllaResearcSuppliesValue
                  },
                  new ResourceUnit
                  {
                      Type = ResourceType.Materials,
                      Value = ReaperResearchConfig.ScyllaResearcMaterialsValue
                  },
                  new ResourceUnit
                  {
                      Type = ResourceType.Tech,
                      Value = ReaperResearchConfig.ScyllaResearcTechValue
                  }
            };
            ResearchDef MutoidCreate = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Mutoid_ResearchDef"));
            MutoidCreate.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = ReaperResearchConfig.MutoidMutagensValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = 1715f
                }
            };
            ResearchDef AcheronAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Acheron_ResearchDef"));
            AcheronAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = ReaperResearchConfig.AcheronMutagensValue
                },

                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = 1715f
                }
            };
            ResearchDef MindfraggerAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Mindfragger_ResearchDef"));
            ResearchDef FirewormAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Fireworm_ResearchDef"));
            ResearchDef PoisonwormAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Poisonworm_ResearchDef"));
            ResearchDef AcidwormAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Acidworm_ResearchDef"));
            ResearchDef MindfraggerEggAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_MindfraggerEgg_ResearchDef"));
            ResearchDef WormEggAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_WormEgg_ResearchDef"));
            ResearchDef SirenAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Siren_ResearchDef"));
            ResearchDef ChironAutopsy = ReaperpointmodResearch.Repo.GetAllDefs<ResearchDef>().FirstOrDefault(a => a.name.Equals("PX_Alien_Chiron_ResearchDef"));
            MindfraggerAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.MindfraggerMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            FirewormAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.FirewormMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            PoisonwormAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.PoisonwormMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            AcidwormAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.AcidwormMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            MindfraggerEggAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.MindfraggerEggMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Supplies,
                    Value = ReaperResearchConfig.MindfraggerEggSuppliesValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            WormEggAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.WormEggMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Supplies,
                    Value = ReaperResearchConfig.WormEggSuppliesValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            SirenAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.SirenMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            ChironAutopsy.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Supplies,
                    Value = ReaperResearchConfig.ChironSuppliesValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Materials,
                    Value = ReaperResearchConfig.ChironMaterialsValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Tech,
                    Value = ReaperResearchConfig.ChironTechValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Mutagen,
                    Value = 308f
                }
            };
            /*MindfraggerAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.MindfraggerMaterialsValue);
            FirewormAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.FirewormMaterialsValue);
            PoisonwormAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.PoisonwormMaterialsValue);
            AcidwormAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.AcidwormMaterialsValue);
            MindfraggerEggAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.MindfraggerEggMaterialsValue);
            MindfraggerEggAutopsy.Resources[1] = new ResourceUnit(ResourceType.Supplies, ReaperResearchConfig.MindfraggerEggSuppliesValue);
            WormEggAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.WormEggMaterialsValue);
            WormEggAutopsy.Resources[1] = new ResourceUnit(ResourceType.Supplies, ReaperResearchConfig.WormEggSuppliesValue);
            SirenAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.SirenMaterialsValue);
            ChironAutopsy.Resources[0] = new ResourceUnit(ResourceType.Materials, ReaperResearchConfig.ChironMaterialsValue);
            ChironAutopsy.Resources[1] = new ResourceUnit(ResourceType.Supplies, ReaperResearchConfig.ChironSuppliesValue);
            ChironAutopsy.Resources[2] = new ResourceUnit(ResourceType.Tech, ReaperResearchConfig.ChironTechValue);*/
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
            AnuAlienReligion.Resources = new ResourcePack()
            {
                new ResourceUnit
                {
                    Type = ResourceType.Supplies,
                    Value = ReaperResearchConfig.AARSuppliesValue
                },
                new ResourceUnit
                {
                    Type = ResourceType.Tech,
                    Value = ReaperResearchConfig.AARTechValue
                }
            };
                /*Resources[0] = new ResourceUnit(ResourceType.Supplies, ReaperResearchConfig.AARSuppliesValue);
            AnuAlienReligion.Resources[1] = new ResourceUnit(ResourceType.Tech, ReaperResearchConfig.AARTechValue);*/
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
            AircraftBuffResearchRewardDef SynBuffAirSpeed = ReaperpointmodResearch.Repo.GetAllDefs<AircraftBuffResearchRewardDef>().FirstOrDefault(a => a.name.Equals("SYN_MoonMission_ResearchDef_AircraftBuffResearchRewardDef_0"));
            SynBuffAirSpeed.ModData.SpeedMultiplier = ReaperResearchConfig.MMPAirBuffSpeed;
        }
    }
}
