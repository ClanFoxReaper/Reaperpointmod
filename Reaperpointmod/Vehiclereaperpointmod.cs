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
using PhoenixPoint.Common.Entities.Equipments;

namespace Reaperpointmod
{
    internal class Vehiclereaperpointmod
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void VehicleReaper()
        {
            ReaperpointmodConfig ReaperVehicleConfig = ReaperpointmodMain.Main.Config;

            GroundVehicleWeaponDef Taurus = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Scarab_Taurus_GroundVehicleWeaponDef"));
            Taurus.APToUsePerc = ReaperVehicleConfig.TaurusActionPointToUsePerc;
            Taurus.ChargesMax = ReaperVehicleConfig.TaurusChargesMaxAmmo;
            Taurus.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TaurusDamage;
            Taurus.DamagePayload.DamageKeywords[2].Value = ReaperVehicleConfig.TaurusShockDamage;

            GroundVehicleWeaponDef Scorpio = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Scarab_Scorpio_GroundVehicleWeaponDef"));
            Scorpio.APToUsePerc = ReaperVehicleConfig.ScorpioActionPointToUsePerc;
            Scorpio.ChargesMax = ReaperVehicleConfig.ScorpioChargesMaxAmmo;
            Scorpio.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.ScorpioDamage;

            GroundVehicleWeaponDef PhoenixMT = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_Scarab_Missile_Turret_GroundVehicleWeaponDef"));
            PhoenixMT.APToUsePerc = ReaperVehicleConfig.GeminiActionPointToUsePerc;
            PhoenixMT.ChargesMax = ReaperVehicleConfig.GeminiChargesMaxAmmo;
            PhoenixMT.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.GeminiDamage;

            ShootAbilityDef ScorpioShoot100 = Vehiclereaperpointmod.Repo.GetAllDefs<ShootAbilityDef>().FirstOrDefault(a => a.name.Equals("LaunchMissiles_ShootAbilityDef"));
            ShootAbilityDef PhoenixMTShoot100 = Vehiclereaperpointmod.Repo.GetAllDefs<ShootAbilityDef>().FirstOrDefault(a => a.name.Equals("LaunchMissiles_ShootAbilityDef"));

            ScorpioShoot100.UsesPerTurn = ReaperVehicleConfig.LMSUsesPerTurn;
            PhoenixMTShoot100.UsesPerTurn = ReaperVehicleConfig.LMSUsesPerTurn;

            WeaponDef KaosChaosFullstop = Vehiclereaperpointmod.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Buggy_Fullstop_WeaponDef"));
            WeaponDef KaosChaosMinigunFullstop = Vehiclereaperpointmod.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Buggy_Minigun_Fullstop_WeaponDef"));
            KaosChaosFullstop.APToUsePerc = ReaperVehicleConfig.TheFullstopActionPointToUsePerc;
            KaosChaosFullstop.ChargesMax = ReaperVehicleConfig.TheFullstopChargesMaxAmmo;
            KaosChaosFullstop.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TheFullstopDamage;
            KaosChaosMinigunFullstop.APToUsePerc = ReaperVehicleConfig.TheFullstopminigunActionPointToUsePerc;
            KaosChaosMinigunFullstop.ChargesMax = ReaperVehicleConfig.TheFullstopminigunChargesMaxAmmo;
            KaosChaosMinigunFullstop.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TheFullstopminigunDamage;

            WeaponDef KaosChaosMinigunScreamer = Vehiclereaperpointmod.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Buggy_Minigun_Screamer_WeaponDef"));
            WeaponDef KaosChaosScreamer = Vehiclereaperpointmod.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Buggy_Screamer_WeaponDef"));
            KaosChaosMinigunScreamer.APToUsePerc = ReaperVehicleConfig.TheScreamerminigunActionPointToUsePerc;
            KaosChaosMinigunScreamer.ChargesMax = ReaperVehicleConfig.TheScreamerminigunChargesMaxAmmo;
            KaosChaosMinigunScreamer.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TheScreamerminigunDamage;
            KaosChaosScreamer.APToUsePerc = ReaperVehicleConfig.TheScreamerActionPointToUsePerc;
            KaosChaosScreamer.ChargesMax = ReaperVehicleConfig.TheScreamerChargesMaxAmmo;
            KaosChaosScreamer.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TheScreamerDamage;
            KaosChaosScreamer.DamagePayload.DamageKeywords[1].Value = ReaperVehicleConfig.TheScreamerSonic;

            WeaponDef KaosChaosMinigunVishnu = Vehiclereaperpointmod.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Buggy_Minigun_Vishnu_WeaponDef"));
            WeaponDef KaosChaosTheVishnuGunCannon = Vehiclereaperpointmod.Repo.GetAllDefs<WeaponDef>().FirstOrDefault(a => a.name.Equals("KS_Buggy_The_Vishnu_Gun_Cannon_WeaponDef"));
            KaosChaosMinigunVishnu.APToUsePerc = ReaperVehicleConfig.TheVishnuGunMinigunActionPointToUsePerc;
            KaosChaosMinigunVishnu.ChargesMax = ReaperVehicleConfig.TheVishnuGunMinigunChargesMaxAmmo;
            KaosChaosMinigunVishnu.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TheVishnuGunMinigunDamage;
            KaosChaosTheVishnuGunCannon.APToUsePerc = ReaperVehicleConfig.TheVishnuGunActionPointToUsePerc;
            KaosChaosTheVishnuGunCannon.ChargesMax = ReaperVehicleConfig.TheVishnuGunChargesMaxAmmo;
            KaosChaosTheVishnuGunCannon.DamagePayload.DamageKeywords[0].Value = ReaperVehicleConfig.TheVishnuGunDamage;

            GroundVehicleModuleDef CargoRacks = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("PX_Scarab_Reinforced_Cargo_Racks_GroundVehicleModuleDef"));
            CargoRacks.BodyPartAspectDef.StatModifications[0].Value = ReaperVehicleConfig.RCRValue;

            GroundVehicleModuleDef AEMM = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("PX_Scarab_Advanced_Engine_Mapping_Module_Engine_GroundVehicleModuleDef"));
            AEMM.BodyPartAspectDef.Speed = ReaperVehicleConfig.AEMMValue;

            GroundVehicleModuleDef EES = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("KS_Kaos_Buggy_Experimental_Exhaust_System_Engine_GroundVehicleModuleDef"));
            EES.BodyPartAspectDef.Speed = ReaperVehicleConfig.EESValue;

            GroundVehicleModuleDef JetBooster = Vehiclereaperpointmod.Repo.GetAllDefs<GroundVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("KS_Kaos_Buggy_Dog_Ring_Gearbox_Engine_GroundVehicleModuleDef"));
            JetBooster.BodyPartAspectDef.Speed = ReaperVehicleConfig.JBValue;
        }
    }
}
