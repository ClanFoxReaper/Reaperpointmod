using Base.Core;
using Base.Defs;
using Base.Levels;
using PhoenixPoint.Common.Game;
using PhoenixPoint.Modding;
using PhoenixPoint.Geoscape.Core;
using PhoenixPoint.Geoscape.Entities.Interception.Equipments;
using System.Linq;
using UnityEngine;
using PhoenixPoint.Geoscape.Entities;

namespace Reaperpointmod
{
    internal class FireFoxAirWolf
    {
        private static readonly DefRepository Repo = ReaperpointmodMain.Repo;

        public static void FireFoxAirWolfReaper()
        {
            ReaperpointmodConfig FireFoxAirWolfConfig = ReaperpointmodMain.Main.Config;
            GeoVehicleWeaponDamageDef NomadRegular = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Regular_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef NomadShred = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Shred_GeoVehicleWeaponDamageDef")); //Поки не використовуємо!
            GeoVehicleWeaponDamageDef OrochiRegular = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Regular_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef OrochiShock = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Shock_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef TyrRegular = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Regular_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef TyrShock = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Shock_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef ThunderboltRegular = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Regular_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef ThunderboltShred = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Shred_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef FenrirRegular = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Regular_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef FenrirVirophage = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Virophage_GeoVehicleWeaponDamageDef"));
            GeoVehicleWeaponDamageDef BrokkrRegular = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDamageDef>().FirstOrDefault(gvs => gvs.name.Equals("Regular_GeoVehicleWeaponDamageDef"));
            
            GeoVehicleWeaponDef Nomad = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_BasicMissileNomadAAM_VehicleWeaponDef"));
            Nomad.AmmoCount = FireFoxAirWolfConfig.NomadAmmoCount;
            Nomad.DamagePayloads[0] = new GeoWeaponDamagePayload { Damage = NomadRegular, Amount = FireFoxAirWolfConfig.NomadDamageRegular };

            GeoVehicleWeaponDef Orochi = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HeavyCannonOrochiHC1_VehicleWeaponDef"));
            Orochi.AmmoCount = FireFoxAirWolfConfig.OrochiAmmoCount;
            Orochi.DamagePayloads[0] = new GeoWeaponDamagePayload { Damage = OrochiRegular, Amount = FireFoxAirWolfConfig.OrochiDamageRegular };
            Orochi.DamagePayloads[1] = new GeoWeaponDamagePayload { Damage = OrochiShock, Amount = FireFoxAirWolfConfig.OrochiDamageShock };
            

            GeoVehicleWeaponDef HandofTyr = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_HypersonicMissileHandOfTyr_VehicleWeaponDef"));
            HandofTyr.AmmoCount = FireFoxAirWolfConfig.HandofTyrAmmoCount;
            HandofTyr.DamagePayloads[0] = new GeoWeaponDamagePayload { Damage = TyrRegular, Amount = FireFoxAirWolfConfig.HandofTyrDamageRegular };
            HandofTyr.DamagePayloads[1] = new GeoWeaponDamagePayload { Damage = TyrShock, Amount = FireFoxAirWolfConfig.HandofTyrDamageShock };

            GeoVehicleWeaponDef Thunderbolt = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_ElectrolaserThunderboltHC9_VehicleWeaponDef"));
            Thunderbolt.AmmoCount = FireFoxAirWolfConfig.ThunderboltAmmoCount;
            Thunderbolt.DamagePayloads[0] = new GeoWeaponDamagePayload { Damage = ThunderboltRegular, Amount = FireFoxAirWolfConfig.ThunderboltDamageRegular };

            GeoVehicleWeaponDef Fenrir = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_VirophageGunFenrirRC7_VehicleWeaponDef"));
            Fenrir.AmmoCount = FireFoxAirWolfConfig.FenrirAmmoCount;
            Fenrir.DamagePayloads[0] = new GeoWeaponDamagePayload { Damage = FenrirRegular, Amount = FireFoxAirWolfConfig.FenrirDamageRegular };
            Fenrir.DamagePayloads[1] = new GeoWeaponDamagePayload { Damage = FenrirVirophage, Amount = FireFoxAirWolfConfig.FenrirDamageVirophage };

            GeoVehicleWeaponDef Brokkr = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleWeaponDef>().FirstOrDefault(a => a.name.Equals("PX_AutocannonBrokkrAC3_VehicleWeaponDef"));
            Brokkr.AmmoCount = FireFoxAirWolfConfig.BrokkrAmmoCount;
            Brokkr.DamagePayloads[0] = new GeoWeaponDamagePayload { Damage = BrokkrRegular, Amount = FireFoxAirWolfConfig.BrokkrDamageRegular };

            GeoVehicleModuleDef Flares = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("PX_Flares_GeoVehicleModuleDef"));
            Flares.AmmoCount = FireFoxAirWolfConfig.FlaresAmmoCount;

            GeoVehicleModuleDef AfterBurner = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("PX_Afterburner_GeoVehicleModuleDef"));
            AfterBurner.AmmoCount = FireFoxAirWolfConfig.AfterburnerAmmoCount;

            GeoVehicleModuleDef CruiseControl = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("NJ_CruiseControl_GeoVehicleModuleDef"));
            CruiseControl.GeoVehicleModuleBonusValue = FireFoxAirWolfConfig.CruiseControlSpeed;

            GeoVehicleModuleDef FuelTank = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleModuleDef>().FirstOrDefault(a => a.name.Equals("NJ_FuelTanks_GeoVehicleModuleDef"));
            FuelTank.GeoVehicleModuleBonusValue = FireFoxAirWolfConfig.FuelTankSpeed;

            GeoVehicleDef ManticoreMask = FireFoxAirWolf.Repo.GetAllDefs<GeoVehicleDef>().FirstOrDefault(a => a.name.Equals("PP_MaskedManticore_Def"));
            ManticoreMask.BaseStats.SpaceForUnits = FireFoxAirWolfConfig.ManticoreMaskSpaceForUnits;

        }
    }
}
