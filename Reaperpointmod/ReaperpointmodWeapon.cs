using Base.Defs;
using PhoenixPoint.Tactical.Entities.Abilities;
using PhoenixPoint.Tactical.Entities.Weapons;
using System.Linq;
using UnityEngine;

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
            Ares.IncompetenceAccuracyMultiplier = 2;
            Ares.HandsToUse = 2;
            Ares.DamagePayload.AutoFireShotCount = 6;
            Ares.DamagePayload.ProjectilesPerShot = 1;
            Ares.DamagePayload.StopOnFirstHit = false;
            Ares.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.AresDamage;

            WeaponDef FireBird = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_SniperRifle_WeaponDef"));
            FireBird.APToUsePerc = ReaperWeaponConfig.FireBirdActionPointToUsePerc;
            FireBird.IncompetenceAccuracyMultiplier = 2;
            FireBird.HandsToUse = 2;
            FireBird.DamagePayload.AutoFireShotCount = 1;
            FireBird.DamagePayload.ProjectilesPerShot = 1;
            FireBird.DamagePayload.StopOnFirstHit = false;
            FireBird.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.FireBirdDamage;

            WeaponDef HelII = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_WeaponDef"));
            HelII.APToUsePerc = ReaperWeaponConfig.HelActionPointToUsePerc;
            HelII.IncompetenceAccuracyMultiplier = 2;
            HelII.HandsToUse = 2;
            HelII.DamagePayload.AutoFireShotCount = 1;
            HelII.DamagePayload.ProjectilesPerShot = 1;
            HelII.DamagePayload.StopOnFirstHit = false;
            HelII.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.HelDamage;

            WeaponDef TyrI = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_Autocannon_WeaponDef"));
            TyrI.APToUsePerc = ReaperWeaponConfig.TyrIActionPointToUsePerc;
            TyrI.IncompetenceAccuracyMultiplier = 2;
            TyrI.HandsToUse = 2;
            TyrI.DamagePayload.AutoFireShotCount = 3;
            TyrI.DamagePayload.ProjectilesPerShot = 1;
            TyrI.DamagePayload.StopOnFirstHit = false;
            TyrI.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.TyrIDamage;

            WeaponDef Cypher = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Pistol_WeaponDef"));
            Cypher.APToUsePerc = ReaperWeaponConfig.CypherActionpointToUsePerc;
            Cypher.IncompetenceAccuracyMultiplier = 2;
            Cypher.HandsToUse = 1;
            Cypher.DamagePayload.AutoFireShotCount = 1;
            Cypher.DamagePayload.ProjectilesPerShot = 1;
            Cypher.DamagePayload.StopOnFirstHit = false;
            Cypher.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.CypherDamage;

            WeaponDef Mercy = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ShotgunRifle_WeaponDef"));
            Mercy.APToUsePerc = ReaperWeaponConfig.MercyActionPointToUsePerc;
            Mercy.IncompetenceAccuracyMultiplier = 2;
            Mercy.HandsToUse = 2;
            Mercy.DamagePayload.AutoFireShotCount = 1;
            Mercy.DamagePayload.ProjectilesPerShot = 1;
            Mercy.DamagePayload.StopOnFirstHit = false;
            Mercy.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MercyDamage;

            WeaponDef Slamstrike = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_SlamstrikeShotgun_WeaponDef"));
            Slamstrike.APToUsePerc = ReaperWeaponConfig.SlamStrikeActionPointToUsePerc;
            Slamstrike.IncompetenceAccuracyMultiplier = 2;
            Slamstrike.HandsToUse = 2;
            Slamstrike.DamagePayload.AutoFireShotCount = 1;
            Slamstrike.DamagePayload.ProjectilesPerShot = 1;
            Slamstrike.DamagePayload.StopOnFirstHit = true;
            Slamstrike.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.SlamStrikeDamage;

            WeaponDef Vidar = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_AssaultGrenadeLauncher_WeaponDef"));
            Vidar.APToUsePerc = ReaperWeaponConfig.VidarActionPointToUsePerc;
            Vidar.IncompetenceAccuracyMultiplier = 1;
            Vidar.HandsToUse = 2;
            Vidar.DamagePayload.AutoFireShotCount = 1;
            Vidar.DamagePayload.ProjectilesPerShot = 1;
            Vidar.DamagePayload.StopOnFirstHit = false;
            Vidar.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.VidarDamage;

            WeaponDef Hawk = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("FS_LightSniperRifle_WeaponDef"));
            Hawk.APToUsePerc = ReaperWeaponConfig.HawkActionPointToUsePerc;
            Hawk.IncompetenceAccuracyMultiplier = 2;
            Hawk.HandsToUse = 2;
            Hawk.DamagePayload.AutoFireShotCount = 1;
            Hawk.DamagePayload.ProjectilesPerShot = 1;
            Hawk.DamagePayload.StopOnFirstHit = false;
            Hawk.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.HawkDamage;

            WeaponDef Gungnir = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_VirophageSniperRifle_WeaponDef"));
            Gungnir.APToUsePerc = ReaperWeaponConfig.GungnirActionPointToUsePerc;
            Gungnir.IncompetenceAccuracyMultiplier = 2;
            Gungnir.HandsToUse = 2;
            Gungnir.DamagePayload.AutoFireShotCount = 1;
            Gungnir.DamagePayload.ProjectilesPerShot = 1;
            Gungnir.DamagePayload.StopOnFirstHit = false;
            Gungnir.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GungnirDamage;

            WeaponDef Goliath = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_GrenadeLauncher_WeaponDef"));
            Goliath.APToUsePerc = ReaperWeaponConfig.GoliathActionPointToUsePerc;
            Goliath.IncompetenceAccuracyMultiplier = 1;
            Goliath.HandsToUse = 2;
            Goliath.DamagePayload.AutoFireShotCount = 1;
            Goliath.DamagePayload.ProjectilesPerShot = 1;
            Goliath.DamagePayload.StopOnFirstHit = true;
            Goliath.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoliathDamage;

            WeaponDef Jormungandr = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AcidCannon_WeaponDef"));
            Jormungandr.APToUsePerc = ReaperWeaponConfig.JormungandrActionPointToUsePerc;
            Jormungandr.IncompetenceAccuracyMultiplier = 2;
            Jormungandr.HandsToUse = 2;
            Jormungandr.DamagePayload.AutoFireShotCount = 1;
            Jormungandr.DamagePayload.ProjectilesPerShot = 10;
            Jormungandr.DamagePayload.StopOnFirstHit = true;
            Jormungandr.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.JormungandrDamage;

            WeaponDef ShockLance = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_StunRod_WeaponDef"));
            ShockLance.APToUsePerc = ReaperWeaponConfig.PSLActionPointToUsePerc;
            ShockLance.IncompetenceAccuracyMultiplier = 2;
            ShockLance.HandsToUse = 1;
            ShockLance.DamagePayload.AutoFireShotCount = 1;
            ShockLance.DamagePayload.ProjectilesPerShot = 1;
            ShockLance.DamagePayload.StopOnFirstHit = false;
            ShockLance.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.PSLDamage;

            WeaponDef Ragnarok = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ShredingMissileLauncherPack_WeaponDef"));
            Ragnarok.APToUsePerc = ReaperWeaponConfig.RagnarokActionPointToUsePerc;
            Ragnarok.IncompetenceAccuracyMultiplier = 2;
            Ragnarok.HandsToUse = 0;
            Ragnarok.DamagePayload.AutoFireShotCount = 1;
            Ragnarok.DamagePayload.ProjectilesPerShot = 1;
            Ragnarok.DamagePayload.StopOnFirstHit = true;
            Ragnarok.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.RagnarokDamage;

            WeaponDef Gorgon = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_LaserPDW_WeaponDef"));
            Gorgon.APToUsePerc = ReaperWeaponConfig.GorgonEyeAActionPointToUsePerc;
            Gorgon.IncompetenceAccuracyMultiplier = 2;
            Gorgon.HandsToUse = 2;
            Gorgon.DamagePayload.AutoFireShotCount = 4;
            Gorgon.DamagePayload.ProjectilesPerShot = 1;
            Gorgon.DamagePayload.StopOnFirstHit = false;
            Gorgon.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GorGonEyeADamage;

            WeaponDef Destiny = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_LaserArrayPack_WeaponDef"));
            Destiny.APToUsePerc = ReaperWeaponConfig.DestinyActionPointToUsePerc;
            Destiny.IncompetenceAccuracyMultiplier = 2;
            Destiny.HandsToUse = 0;
            Destiny.DamagePayload.AutoFireShotCount = 3;
            Destiny.DamagePayload.ProjectilesPerShot = 1;
            Destiny.DamagePayload.StopOnFirstHit = false;
            Destiny.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.DestinyDamage;

            WeaponDef Scorcher = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_LaserTechTurretGun_WeaponDef"));
            Scorcher.APToUsePerc = ReaperWeaponConfig.ScorcherATActionPointToUsePerc;
            Scorcher.IncompetenceAccuracyMultiplier = 2;
            Scorcher.HandsToUse = 0;
            Scorcher.DamagePayload.AutoFireShotCount = 8;
            Scorcher.DamagePayload.ProjectilesPerShot = 1;
            Scorcher.DamagePayload.StopOnFirstHit = false;
            Scorcher.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ScorcherATDamage;

            WeaponDef Neuro = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Neurazer_WeaponDef"));
            Neuro.APToUsePerc = ReaperWeaponConfig.NeurazerActionPointToUsePerc;
            Neuro.IncompetenceAccuracyMultiplier = 1;
            Neuro.HandsToUse = 1;
            Neuro.DamagePayload.AutoFireShotCount = 1;
            Neuro.DamagePayload.ProjectilesPerShot = 1;
            Neuro.DamagePayload.StopOnFirstHit = false;
            Neuro.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.NeurazerDamage;
            Neuro.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.NeurazerPiercing;
            Neuro.DamagePayload.DamageKeywords[2].Value = ReaperWeaponConfig.NeurazerParalysis;

            WeaponDef Sky = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_SniperRifle_RisingSun_WeaponDef"));
            Sky.APToUsePerc = ReaperWeaponConfig.FBSkyActionPointToUsePerc;
            Sky.IncompetenceAccuracyMultiplier = 2;
            Sky.HandsToUse = 2;
            Sky.DamagePayload.AutoFireShotCount = 1;
            Sky.DamagePayload.ProjectilesPerShot = 1;
            Sky.DamagePayload.StopOnFirstHit = false;
            Sky.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.FBSkyDamage;

            WeaponDef GoldMagnus = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AssaultRifle_Gold_WeaponDef"));
            GoldMagnus.APToUsePerc = ReaperWeaponConfig.GoldenAresActionPointToUsePerc;
            GoldMagnus.IncompetenceAccuracyMultiplier = 2;
            GoldMagnus.HandsToUse = 2;
            GoldMagnus.DamagePayload.AutoFireShotCount = 6;
            GoldMagnus.DamagePayload.ProjectilesPerShot = 1;
            GoldMagnus.DamagePayload.StopOnFirstHit = false;
            GoldMagnus.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoldenAresDamage;

            WeaponDef GoldBormin = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_Gold_WeaponDef"));
            GoldBormin.APToUsePerc = ReaperWeaponConfig.GoldenHelIIActionPointToUsePerc;
            GoldBormin.IncompetenceAccuracyMultiplier = 2;
            GoldBormin.HandsToUse = 2;
            GoldBormin.DamagePayload.AutoFireShotCount = 1;
            GoldBormin.DamagePayload.ProjectilesPerShot = 1;
            GoldBormin.DamagePayload.StopOnFirstHit = false;
            GoldBormin.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoldenHelIIDamage;

            WeaponDef GoldSelma = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_SniperRifle_Gold_WeaponDef"));
            GoldSelma.APToUsePerc = ReaperWeaponConfig.GoldenFireBirdActionPointToUsePerc;
            GoldSelma.IncompetenceAccuracyMultiplier = 2;
            GoldSelma.HandsToUse = 2;
            GoldSelma.DamagePayload.AutoFireShotCount = 1;
            GoldSelma.DamagePayload.ProjectilesPerShot = 1;
            GoldSelma.DamagePayload.StopOnFirstHit = false;
            GoldSelma.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.GoldenFireBirdDamage;

            WeaponDef xmas = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_Christmas_WeaponDef"));
            xmas.APToUsePerc = ReaperWeaponConfig.xmasactionpointtouseperc;
            xmas.IncompetenceAccuracyMultiplier = 2;
            xmas.HandsToUse = 2;
            xmas.DamagePayload.AutoFireShotCount = 1;
            xmas.DamagePayload.ProjectilesPerShot = 1;
            xmas.DamagePayload.StopOnFirstHit = false;
            xmas.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.xmasdamage;

            WeaponDef Hunter = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannon_Headhunter_WeaponDef"));
            Hunter.APToUsePerc = ReaperWeaponConfig.HHHelIIActionPointToUsePerc;
            Hunter.IncompetenceAccuracyMultiplier = 2;
            Hunter.HandsToUse = 2;
            Hunter.DamagePayload.AutoFireShotCount = 1;
            Hunter.DamagePayload.ProjectilesPerShot = 1;
            Hunter.DamagePayload.StopOnFirstHit = false;
            Hunter.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.HHHelIIDamage;

            WeaponDef ARDanchev = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AcidAssaultRifle_WeaponDef"));
            ARDanchev.APToUsePerc = ReaperWeaponConfig.ARDanchevActionPointToUsePerc;
            ARDanchev.IncompetenceAccuracyMultiplier = 2;
            ARDanchev.HandsToUse = 2;
            ARDanchev.DamagePayload.AutoFireShotCount = 6;
            ARDanchev.DamagePayload.ProjectilesPerShot = 1;
            ARDanchev.DamagePayload.StopOnFirstHit = true;
            ARDanchev.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ARDanchevDamage;
            ARDanchev.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ARDanchevAcid;

            WeaponDef MGDanchev = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_PoisonMachineGun_WeaponDef"));
            MGDanchev.APToUsePerc = ReaperWeaponConfig.MGDanchevActionPointToUsePerc;
            MGDanchev.IncompetenceAccuracyMultiplier = 2;
            MGDanchev.HandsToUse = 2;
            MGDanchev.DamagePayload.AutoFireShotCount = 10;
            MGDanchev.DamagePayload.ProjectilesPerShot = 1;
            MGDanchev.DamagePayload.StopOnFirstHit = true;
            MGDanchev.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MGDanchevDamage;
            MGDanchev.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.MGDanchevPoison;

            WeaponDef Mattock = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Mattock_WeaponDef"));
            Mattock.APToUsePerc = ReaperWeaponConfig.MattockActionPointToUsePerc;
            Mattock.IncompetenceAccuracyMultiplier = 2;
            Mattock.HandsToUse = 1;
            Mattock.DamagePayload.AutoFireShotCount = 1;
            Mattock.DamagePayload.ProjectilesPerShot = 1;
            Mattock.DamagePayload.StopOnFirstHit = true;
            Mattock.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MattockDamage;
            Mattock.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.MattockShock;

            WeaponDef Scyther = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Scyther_WeaponDef"));
            Scyther.APToUsePerc = ReaperWeaponConfig.ScytherActionPointToUsePerc;
            Scyther.IncompetenceAccuracyMultiplier = 2;
            Scyther.HandsToUse = 1;
            Scyther.DamagePayload.AutoFireShotCount = 1;
            Scyther.DamagePayload.ProjectilesPerShot = 1;
            Scyther.DamagePayload.StopOnFirstHit = true;
            Scyther.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ScytherDamage;
            Scyther.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ScytherShred;

            WeaponDef ShardGun = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_ShardGun_WeaponDef"));
            ShardGun.APToUsePerc = ReaperWeaponConfig.ShardGunActionPointToUsePerc;
            ShardGun.IncompetenceAccuracyMultiplier = 2;
            ShardGun.HandsToUse = 2;
            ShardGun.DamagePayload.AutoFireShotCount = 1;
            ShardGun.DamagePayload.ProjectilesPerShot = 15;
            ShardGun.DamagePayload.StopOnFirstHit = true;
            ShardGun.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ShardGunDamage;
            ShardGun.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ShardGunPiercing;

            WeaponDef Rebuke = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Rebuke_WeaponDef"));
            Rebuke.APToUsePerc = ReaperWeaponConfig.RebukeActionPointToUsePerc;
            Rebuke.IncompetenceAccuracyMultiplier = 1;
            Rebuke.HandsToUse = 2;
            Rebuke.DamagePayload.AutoFireShotCount = 1;
            Rebuke.DamagePayload.ProjectilesPerShot = 1;
            Rebuke.DamagePayload.StopOnFirstHit = false;
            Rebuke.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.RebukeDamage;
            Rebuke.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.RebukeShred;

            WeaponDef Scorpion = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_Scorpion_WeaponDef"));
            Scorpion.APToUsePerc = ReaperWeaponConfig.ScorpionActionPointToUsePerc;
            Scorpion.IncompetenceAccuracyMultiplier = 2;
            Scorpion.HandsToUse = 2;
            Scorpion.DamagePayload.AutoFireShotCount = 1;
            Scorpion.DamagePayload.ProjectilesPerShot = 1;
            Scorpion.DamagePayload.StopOnFirstHit = true;
            Scorpion.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ScorpionDamage;
            Scorpion.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ScorpionPiercing;

            WeaponDef CrystalCrossbow = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AC_CrystalCrossbow_WeaponDef"));
            CrystalCrossbow.APToUsePerc = ReaperWeaponConfig.CrystalCrossbowActionPointToUsePerc;
            CrystalCrossbow.IncompetenceAccuracyMultiplier = 2;
            CrystalCrossbow.HandsToUse = 2;
            CrystalCrossbow.DamagePayload.AutoFireShotCount = 1;
            CrystalCrossbow.DamagePayload.ProjectilesPerShot = 1;
            CrystalCrossbow.DamagePayload.StopOnFirstHit = true;
            CrystalCrossbow.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.CrystalCrossbowDamage;
            CrystalCrossbow.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.CrystalCrossbowPiercing;

            WeaponDef xbox = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("SY_LaserAssaultRifle_Neon_WeaponDef"));
            xbox.APToUsePerc = ReaperWeaponConfig.SYARNeonActionPointToUsePerc;
            xbox.IncompetenceAccuracyMultiplier = 2;
            xbox.HandsToUse = 2;
            xbox.DamagePayload.AutoFireShotCount = 6;
            xbox.DamagePayload.ProjectilesPerShot = 1;
            xbox.DamagePayload.StopOnFirstHit = false;
            xbox.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.SYARNeonDamage;

            WeaponDef playstation = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("SY_LaserAssaultRifle_WhiteNeon_WeaponDef"));
            playstation.APToUsePerc = ReaperWeaponConfig.SYARWhiteNeonActionPointToUsePerc;
            playstation.IncompetenceAccuracyMultiplier = 2;
            playstation.HandsToUse = 2;
            playstation.DamagePayload.AutoFireShotCount = 6;
            playstation.DamagePayload.ProjectilesPerShot = 1;
            playstation.DamagePayload.StopOnFirstHit = false;
            playstation.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.SYARWhiteNeonDamage;

            WeaponDef AxeViking = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("AN_Blade_Viking_WeaponDef"));
            AxeViking.APToUsePerc = ReaperWeaponConfig.AxeVikingActionPointToUsePerc;
            AxeViking.IncompetenceAccuracyMultiplier = 2;
            AxeViking.HandsToUse = 1;
            AxeViking.DamagePayload.AutoFireShotCount = 1;
            AxeViking.DamagePayload.ProjectilesPerShot = 1;
            AxeViking.DamagePayload.StopOnFirstHit = false;
            AxeViking.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.AxeVikingDamage;
            AxeViking.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.AxeVikingBleed;

            WeaponDef KaosCrossbow = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("SY_Crossbow_Bonus_WeaponDef"));
            KaosCrossbow.APToUsePerc = ReaperWeaponConfig.KaosCrossbowActionPointToUsePerc;
            KaosCrossbow.IncompetenceAccuracyMultiplier = 2;
            KaosCrossbow.HandsToUse = 2;
            KaosCrossbow.DamagePayload.AutoFireShotCount = 1;
            KaosCrossbow.DamagePayload.ProjectilesPerShot = 1;
            KaosCrossbow.DamagePayload.StopOnFirstHit = false;
            KaosCrossbow.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.KaosCrossbowDamage;

            WeaponDef Odin = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HandGrenade_WeaponDef"));
            Odin.APToUsePerc = ReaperWeaponConfig.OdinActionPointToUsePerc;
            Odin.IncompetenceAccuracyMultiplier = 1;
            Odin.HandsToUse = 1;
            Odin.DamagePayload.AutoFireShotCount = 1;
            Odin.DamagePayload.ProjectilesPerShot = 1;
            Odin.DamagePayload.StopOnFirstHit = true;
            Odin.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.OdinDamage;

            WeaponDef Mjolnir = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ShredderGrenade_WeaponDef"));
            Mjolnir.APToUsePerc = ReaperWeaponConfig.MjolnirActionPointToUsePerc;
            Mjolnir.IncompetenceAccuracyMultiplier = 1;
            Mjolnir.HandsToUse = 1;
            Mjolnir.DamagePayload.AutoFireShotCount = 1;
            Mjolnir.DamagePayload.ProjectilesPerShot = 1;
            Mjolnir.DamagePayload.StopOnFirstHit = true;
            Mjolnir.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.MjolnirDamage;
            Mjolnir.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.MjolnirShred;

            WeaponDef Yggdrasil = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_VirophageGrenade_WeaponDef"));
            Yggdrasil.APToUsePerc = ReaperWeaponConfig.YggdrasilActionPointToUsePerc;
            Yggdrasil.IncompetenceAccuracyMultiplier = 1;
            Yggdrasil.HandsToUse = 1;
            Yggdrasil.DamagePayload.AutoFireShotCount = 1;
            Yggdrasil.DamagePayload.ProjectilesPerShot = 1;
            Yggdrasil.DamagePayload.StopOnFirstHit = true;
            Yggdrasil.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.YggdrasilDamage;
            Yggdrasil.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.YggdrasilVirophage;
            Yggdrasil.DamagePayload.DamageKeywords[2].Value = ReaperWeaponConfig.YggdrasilShred;

            WeaponDef Vita = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HealGrenade_WeaponDef"));
            Vita.APToUsePerc = ReaperWeaponConfig.VitaActionPointToUsePerc;
            Vita.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.VitaHeal;

            WeaponDef SindicateDevastator = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Devastator_WeaponDef"));
            SindicateDevastator.APToUsePerc = ReaperWeaponConfig.ChaosDevastatorActionPointToUsePerc;
            SindicateDevastator.IncompetenceAccuracyMultiplier = 2;
            SindicateDevastator.HandsToUse = 2;
            SindicateDevastator.DamagePayload.AutoFireShotCount = 2;
            SindicateDevastator.DamagePayload.ProjectilesPerShot = 1;
            SindicateDevastator.DamagePayload.StopOnFirstHit = false;
            SindicateDevastator.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosDevastatorDamage;
            SindicateDevastator.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosDevastatorShock;

            WeaponDef SindicateObliterator = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Obliterator_WeaponDef"));
            SindicateObliterator.APToUsePerc = ReaperWeaponConfig.ChaosObliteratorActionPointToUsePerc;
            SindicateObliterator.IncompetenceAccuracyMultiplier = 2;
            SindicateObliterator.HandsToUse = 2;
            SindicateObliterator.DamagePayload.AutoFireShotCount = 8;
            SindicateObliterator.DamagePayload.ProjectilesPerShot = 1;
            SindicateObliterator.DamagePayload.StopOnFirstHit = false;
            SindicateObliterator.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosObliteratorDamage;

            WeaponDef SindicateRedemptor = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Redemptor_WeaponDef"));
            SindicateRedemptor.APToUsePerc = ReaperWeaponConfig.ChaosRedemptorActionPointToUsePerc;
            SindicateRedemptor.IncompetenceAccuracyMultiplier = 2;
            SindicateRedemptor.HandsToUse = 2;
            SindicateRedemptor.DamagePayload.AutoFireShotCount = 1;
            SindicateRedemptor.DamagePayload.ProjectilesPerShot = 8;
            SindicateRedemptor.DamagePayload.StopOnFirstHit = false;
            SindicateRedemptor.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosRedemptorDamage;
            SindicateRedemptor.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosRedemptorAcid;

            WeaponDef SindicateSubjector = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Subjector_WeaponDef"));
            SindicateSubjector.APToUsePerc = ReaperWeaponConfig.ChaosSubjectorActionPointToUsePerc;
            SindicateSubjector.IncompetenceAccuracyMultiplier = 2;
            SindicateSubjector.HandsToUse = 2;
            SindicateSubjector.DamagePayload.AutoFireShotCount = 1;
            SindicateSubjector.DamagePayload.ProjectilesPerShot = 1;
            SindicateSubjector.DamagePayload.StopOnFirstHit = false;
            SindicateSubjector.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosSubjectorDamage;
            SindicateSubjector.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosSubjectorPoison;

            WeaponDef SindicateTormentor = ReaperpointmodWeapon.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Tormentor_WeaponDef"));
            SindicateTormentor.APToUsePerc = ReaperWeaponConfig.ChaosTormentorActionPointToUsePerc;
            SindicateTormentor.IncompetenceAccuracyMultiplier = 2;
            SindicateTormentor.HandsToUse = 1;
            SindicateTormentor.DamagePayload.AutoFireShotCount = 2;
            SindicateTormentor.DamagePayload.ProjectilesPerShot = 1;
            SindicateTormentor.DamagePayload.StopOnFirstHit = false;
            SindicateTormentor.DamagePayload.DamageKeywords[0].Value = ReaperWeaponConfig.ChaosTormentorDamage;
            SindicateTormentor.DamagePayload.DamageKeywords[1].Value = ReaperWeaponConfig.ChaosTormentorPiercing;

            ShootAbilityDef LAS = ReaperpointmodWeapon.Repo.GetAllDefs<ShootAbilityDef>().FirstOrDefault(a => a.name.Equals("LaserArray_ShootAbilityDef"));
            LAS.UsesPerTurn = ReaperWeaponConfig.LASAUsesPerTurn;

            ShootAbilityDef LRS = ReaperpointmodWeapon.Repo.GetAllDefs<ShootAbilityDef>().FirstOrDefault(a => a.name.Equals("LaunchRocket_ShootAbilityDef"));
            LRS.UsesPerTurn = ReaperWeaponConfig.LRSAUsesPerTurn;
        }
    }
}

