using Base.Defs;
using Base.Core;
using Base.Levels;
using PhoenixPoint.Tactical.Entities.Abilities;
using PhoenixPoint.Tactical.Entities.Weapons;
using PhoenixPoint.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperpointmod
{
    internal class ReaperpointmodWeapon
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void ReaperWeapon()
        {
            ReaperpointmodConfig ReaperWeaponConfig = ReaperpointmodMain.Main.Config;
            WeaponDef Ares = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AssaultRifle_WeaponDef"));
            Ares.APToUsePerc = ReaperWeaponConfig.AresActionPointToUsePerc;
            Ares.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.AresDamage;

            WeaponDef FireBird = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_SniperRifle_WeaponDef"));
            FireBird.APToUsePerc = ReaperWeaponConfig.FireBirdActionPointToUsePerc;
            FireBird.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.FireBirdDamage;

            WeaponDef HelII = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_WeaponDef"));
            HelII.APToUsePerc = ReaperWeaponConfig.HelActionPointToUsePerc;
            HelII.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.HelDamage;

            WeaponDef TyrI = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_Autocannon_WeaponDef"));
            TyrI.APToUsePerc = ReaperWeaponConfig.TyrIActionPointToUsePerc;
            TyrI.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.TyrIDamage;

            WeaponDef Cypher = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Pistol_WeaponDef"));
            Cypher.APToUsePerc = ReaperWeaponConfig.CypherActionpointToUsePerc;
            Cypher.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.CypherDamage;

            WeaponDef Mercy = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ShotgunRifle_WeaponDef"));
            Mercy.APToUsePerc = ReaperWeaponConfig.MercyActionPointToUsePerc;
            Mercy.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MercyDamage;

            WeaponDef Slamstrike = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_SlamstrikeShotgun_WeaponDef"));
            Slamstrike.APToUsePerc = ReaperWeaponConfig.SlamStrikeActionPointToUsePerc;
            Slamstrike.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.SlamStrikeDamage;

            WeaponDef Vidar = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_AssaultGrenadeLauncher_WeaponDef"));
            Vidar.APToUsePerc = ReaperWeaponConfig.VidarActionPointToUsePerc;
            Vidar.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.VidarDamage;

            WeaponDef Hawk = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_LightSniperRifle_WeaponDef"));
            Hawk.APToUsePerc = ReaperWeaponConfig.HawkActionPointToUsePerc;
            Hawk.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.HawkDamage;

            WeaponDef Gungnir = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_VirophageSniperRifle_WeaponDef"));
            Gungnir.APToUsePerc = ReaperWeaponConfig.GungnirActionPointToUsePerc;
            Gungnir.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GungnirDamage;

            WeaponDef Goliath = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_GrenadeLauncher_WeaponDef"));
            Goliath.APToUsePerc = ReaperWeaponConfig.GoliathActionPointToUsePerc;
            Goliath.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoliathDamage;

            WeaponDef Jormungandr = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AcidCannon_WeaponDef"));
            Jormungandr.APToUsePerc = ReaperWeaponConfig.JormungandrActionPointToUsePerc;
            Jormungandr.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.JormungandrDamage;

            WeaponDef ShockLance = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_StunRod_WeaponDef"));
            ShockLance.APToUsePerc = ReaperWeaponConfig.PSLActionPointToUsePerc;
            ShockLance.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.PSLDamage;

            WeaponDef Ragnarok = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ShredingMissileLauncherPack_WeaponDef"));
            Ragnarok.APToUsePerc = ReaperWeaponConfig.RagnarokActionPointToUsePerc;
            Ragnarok.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.RagnarokDamage;

            WeaponDef Gorgon = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_LaserPDW_WeaponDef"));
            Gorgon.APToUsePerc = ReaperWeaponConfig.GorgonEyeAActionPointToUsePerc;
            Gorgon.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GorGonEyeADamage;

            WeaponDef Destiny = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_LaserArrayPack_WeaponDef"));
            Destiny.APToUsePerc = ReaperWeaponConfig.DestinyActionPointToUsePerc;
            Destiny.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.DestinyDamage;

            WeaponDef Scorcher = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_LaserTechTurretGun_WeaponDef"));
            Scorcher.APToUsePerc = ReaperWeaponConfig.ScorcherATActionPointToUsePerc;
            Scorcher.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ScorcherATDamage;

            WeaponDef Neuro = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Neurazer_WeaponDef"));
            Neuro.APToUsePerc = ReaperWeaponConfig.NeurazerActionPointToUsePerc;
            Neuro.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.NeurazerDamage;
            Neuro.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.NeurazerPiercing;
            Neuro.DamagePayload.DamageKeywords[2].Value = ReaperWeaponConfig.NeurazerParalysis;

            WeaponDef Sky = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_SniperRifle_RisingSun_WeaponDef"));
            Sky.APToUsePerc = ReaperWeaponConfig.FBSkyActionPointToUsePerc;
            Sky.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.FBSkyDamage;

            WeaponDef GoldMagnus = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AssaultRifle_Gold_WeaponDef"));
            GoldMagnus.APToUsePerc = ReaperWeaponConfig.GoldenAresActionPointToUsePerc;
            GoldMagnus.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoldenAresDamage;

            WeaponDef GoldBormin = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_Gold_WeaponDef"));
            GoldBormin.APToUsePerc = ReaperWeaponConfig.GoldenHelIIActionPointToUsePerc;
            GoldBormin.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoldenHelIIDamage;

            WeaponDef GoldSelma = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_SniperRifle_Gold_WeaponDef"));
            GoldSelma.APToUsePerc = ReaperWeaponConfig.GoldenFireBirdActionPointToUsePerc;
            GoldSelma.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoldenFireBirdDamage;

            WeaponDef xmas = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_Christmas_WeaponDef"));
            xmas.APToUsePerc = ReaperWeaponConfig.xmasactionpointtouseperc;
            xmas.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.xmasdamage;

            WeaponDef Hunter = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_Headhunter_WeaponDef"));
            Hunter.APToUsePerc = ReaperWeaponConfig.HHHelIIActionPointToUsePerc;
            Hunter.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.HHHelIIDamage;

            WeaponDef ARDanchev = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AcidAssaultRifle_WeaponDef"));
            ARDanchev.APToUsePerc = ReaperWeaponConfig.ARDanchevActionPointToUsePerc;
            ARDanchev.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ARDanchevDamage;
            ARDanchev.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ARDanchevAcid;

            WeaponDef MGDanchev = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_PoisonMachineGun_WeaponDef"));
            MGDanchev.APToUsePerc = ReaperWeaponConfig.MGDanchevActionPointToUsePerc;
            MGDanchev.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MGDanchevDamage;
            MGDanchev.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.MGDanchevPoison;

            WeaponDef Mattock = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Mattock_WeaponDef"));
            Mattock.APToUsePerc = ReaperWeaponConfig.MattockActionPointToUsePerc;
            Mattock.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MattockDamage;
            Mattock.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.MattockShock;

            WeaponDef Scyther = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Scyther_WeaponDef"));
            Scyther.APToUsePerc = ReaperWeaponConfig.ScytherActionPointToUsePerc;
            Scyther.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ScytherDamage;
            Scyther.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ScytherShred;

            WeaponDef ShardGun = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_ShardGun_WeaponDef"));
            ShardGun.APToUsePerc = ReaperWeaponConfig.ShardGunActionPointToUsePerc;
            ShardGun.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ShardGunDamage;
            ShardGun.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ShardGunPiercing;

            WeaponDef Rebuke = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Rebuke_WeaponDef"));
            Rebuke.APToUsePerc = ReaperWeaponConfig.RebukeActionPointToUsePerc;
            Rebuke.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.RebukeDamage;
            Rebuke.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.RebukeShred;

            WeaponDef Scorpion = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Scorpion_WeaponDef"));
            Scorpion.APToUsePerc = ReaperWeaponConfig.ScorpionActionPointToUsePerc;
            Scorpion.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ScorpionDamage;
            Scorpion.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ScorpionPiercing;

            WeaponDef CrystalCrossbow = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_CrystalCrossbow_WeaponDef"));
            CrystalCrossbow.APToUsePerc = ReaperWeaponConfig.CrystalCrossbowActionPointToUsePerc;
            CrystalCrossbow.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.CrystalCrossbowDamage;
            CrystalCrossbow.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.CrystalCrossbowPiercing;

            WeaponDef xbox = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("SY_LaserAssaultRifle_Neon_WeaponDef"));
            xbox.APToUsePerc = ReaperWeaponConfig.SYARNeonActionPointToUsePerc;
            xbox.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.SYARNeonDamage;

            WeaponDef playstation = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("SY_LaserAssaultRifle_WhiteNeon_WeaponDef"));
            playstation.APToUsePerc = ReaperWeaponConfig.SYARWhiteNeonActionPointToUsePerc;
            playstation.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.SYARWhiteNeonDamage;

            WeaponDef AxeViking = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AN_Blade_Viking_WeaponDef"));
            AxeViking.APToUsePerc = ReaperWeaponConfig.AxeVikingActionPointToUsePerc;
            AxeViking.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.AxeVikingDamage;
            AxeViking.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.AxeVikingBleed;

            WeaponDef KaosCrossbow = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("SY_Crossbow_Bonus_WeaponDef"));
            KaosCrossbow.APToUsePerc = ReaperWeaponConfig.KaosCrossbowActionPointToUsePerc;
            KaosCrossbow.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.KaosCrossbowDamage;

            WeaponDef Odin = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HandGrenade_WeaponDef"));
            Odin.APToUsePerc = ReaperWeaponConfig.OdinActionPointToUsePerc;
            Odin.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.OdinDamage;

            WeaponDef Mjolnir = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ShredderGrenade_WeaponDef"));
            Mjolnir.APToUsePerc = ReaperWeaponConfig.MjolnirActionPointToUsePerc;
            Mjolnir.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MjolnirDamage;
            Mjolnir.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.MjolnirShred;

            WeaponDef Yggdrasil = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_VirophageGrenade_WeaponDef"));
            Yggdrasil.APToUsePerc = ReaperWeaponConfig.YggdrasilActionPointToUsePerc;
            Yggdrasil.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.YggdrasilDamage;
            Yggdrasil.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.YggdrasilVirophage;
            Yggdrasil.DamagePayload.DamageKeywords[2].Value = ReaperWeaponConfig.YggdrasilShred;

            WeaponDef Vita = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HealGrenade_WeaponDef"));
            Vita.APToUsePerc = ReaperWeaponConfig.VitaActionPointToUsePerc;
            Vita.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.VitaHeal;

            WeaponDef SindicateDevastator = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Devastator_WeaponDef"));
            SindicateDevastator.APToUsePerc = ReaperWeaponConfig.ChaosDevastatorActionPointToUsePerc;
            SindicateDevastator.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosDevastatorDamage;
            SindicateDevastator.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosDevastatorShock;

            WeaponDef SindicateObliterator = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Obliterator_WeaponDef"));
            SindicateObliterator.APToUsePerc = ReaperWeaponConfig.ChaosObliteratorActionPointToUsePerc;
            SindicateObliterator.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosObliteratorDamage;

            WeaponDef SindicateRedemptor = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Redemptor_WeaponDef"));
            SindicateRedemptor.APToUsePerc = ReaperWeaponConfig.ChaosRedemptorActionPointToUsePerc;
            SindicateRedemptor.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosRedemptorDamage;
            SindicateRedemptor.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosRedemptorAcid;

            WeaponDef SindicateSubjector = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Subjector_WeaponDef"));
            SindicateSubjector.APToUsePerc = ReaperWeaponConfig.ChaosSubjectorActionPointToUsePerc;
            SindicateSubjector.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosSubjectorDamage;
            SindicateSubjector.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosSubjectorPoison;

            WeaponDef SindicateTormentor = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Tormentor_WeaponDef"));
            SindicateTormentor.APToUsePerc = ReaperWeaponConfig.ChaosTormentorActionPointToUsePerc;
            SindicateTormentor.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosTormentorDamage;
            SindicateTormentor.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosTormentorPiercing;

            ShootAbilityDef LAS = ReaperpointmodWeapon.Repo.GetAllDefs<ShootAbilityDef>().FirstOrDefault(a => a.name.Equals("LaserArray_ShootAbilityDef"));
            LAS.UsesPerTurn = ReaperWeaponConfig.LASAUsesPerTurn;

            ShootAbilityDef LRS = ReaperpointmodWeapon.Repo.GetAllDefs<ShootAbilityDef>().FirstOrDefault(a => a.name.Equals("LaunchRocket_ShootAbilityDef"));
            LRS.UsesPerTurn = ReaperWeaponConfig.LRSAUsesPerTurn;
        }
    }
}

