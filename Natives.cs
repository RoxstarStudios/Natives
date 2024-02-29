using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace GTAV.Natives.Client
{
    public class b3095
    {
        public static int GetCurrentTVShowPlayTime() // GET_CURRENT_TV_SHOW_PLAY_TIME
        {
            return Function.Call<int>((Hash)0xDD3AA743AB7D4D75);
        }
        public static void EnableDragRaceStationaryWarningSounds(int vehicle, bool enable) // _ENABLE_DRAG_RACE_STATIONARY_WARNING_SOUNDS
        {
            Function.Call<int>((Hash)0xBEFB80290414FD4F, vehicle, enable);
            return; 
        }
        public static float GetThirdPersonCamMinOrbitDistanceSpring() // _GET_THIRD_PERSON_CAM_MIN_ORBIT_DISTANCE_SPRING
        {
            return Function.Call<float>((Hash)0xBC456FB703431785);
        }
        public static float GetThirdPersonCamMaxOrbitDistanceSpring() // _GET_THIRD_PERSON_CAM_MAX_ORBIT_DISTANCE_SPRING
        {
            return Function.Call<float>((Hash)0xD4592A16D36673ED);
        }
        public static void SetParticleFXLoopedCameraBias(int ptfxHandle, float p1) // _SET_PARTICLE_FX_LOOPED_CAMERA_BIAS
        {
            Function.Call<int>((Hash)0x4100BF0346A8D2C3, ptfxHandle, p1);
            return; 
        }
        public static int StartVehicleParticleFXLooped(int vehicle, ref string effectName, bool frontBack, bool leftRight, bool localOnly) // _START_VEHICLE_PARTICLE_FX_LOOPED
        {
            return Function.Call<int>((Hash)0xDF269BE2909E181A, vehicle, effectName, frontBack, leftRight, localOnly);
        }
        public static void ForceAllowSnowFootVFXOnIce(bool toggle) // _FORCE_ALLOW_SNOW_FOOT_VFX_ON_ICE
        {
            Function.Call<int>((Hash)0xA342A3763B3AFB6C, toggle);
            return; 
        }
        public static void ForceGroundSnowPass(bool toggle) // _FORCE_GROUND_SNOW_PASS
        {
            Function.Call<int>((Hash)0x6E9EF3A33C8899F8, toggle);
            return; 
        }
        public static void SetTVChannelPlaylistDirty(int tvChannel, bool p1) // _SET_TV_CHANNEL_PLAYLIST_DIRTY
        {
            Function.Call<int>((Hash)0xEE831F15A8D0D94A, tvChannel, p1);
            return; 
        }
        public static void UseVehicleTargetingReticuleOnVehicles(bool enable) // _USE_VEHICLE_TARGETING_RETICULE_ON_VEHICLES
        {
            Function.Call<int>((Hash)0x1BC0EA2912708625, enable);
            return; 
        }
        public static void SetTextLineHeightMult(float lineHeightMult) // SET_TEXT_LINE_HEIGHT_MULT
        {
            Function.Call<int>((Hash)0x9F4624F76E6953D1, lineHeightMult);
            return; 
        }
        public static void SetBlipGpsRouteDisplayDistance(Blip blip, int blipChangeParam46, bool blipChangeParam47) //_SET_BLIP_GPS_ROUTE_DISPLAY_DISTANCE
        {
            Function.Call<int>((Hash)0x25D984CFB64ED6DE, blip, blipChangeParam46, blipChangeParam47); 
            return;
        }
        public static void SetContentPropType(uint model, int type) //_SET_CONTENT_PROP_TYPE
        {
            Function.Call<int>((Hash)0xBA4583AF4C678A9B, model, type); 
            return;
        }
        public static void SetVehicleMaxLaunchEngineRevs(int vehicle, float modifier) //_SET_VEHICLE_MAX_LAUNCH_ENGINE_REVS
        {
            Function.Call<int>((Hash)0x5AE614ECA5FDD423, vehicle, modifier); 
            return;
        }
        public static void SetAttachedVehicleToTowTruckArm(int towTruck, int vehicle) //_SET_ATTACHED_VEHICLE_TO_TOW_TRUCK_ARM
        {
            Function.Call<int>((Hash)0x48BD57D0DD17786A, towTruck, vehicle); 
            return;
        }
        public static void SetTransmissionReducedGearRatio(int vehicle, bool toggle) //_SET_TRANSMISSION_REDUCED_GEAR_RATIO
        {
            Function.Call<int>((Hash)0x337EF33DA3DDB990, vehicle, toggle); 
            return;
        }
        public static void SetVehicleUseHornButtonForNitrous(bool toggle) //_SET_VEHICLE_USE_HORN_BUTTON_FOR_NITROUS
        {
            Function.Call<int>((Hash)0x1980F68872CC2C3D, toggle); 
            return;
        }
        public static void SetNitrousIsActive(int vehicle, bool enabled) //_NITROUS_IS_ACTIVE
        {
            Function.Call<int>((Hash)0x465EEA70AF251045, vehicle, enabled); 
            return;
        }
        public static void SetOverrideTractionLossMultiplier(int vehicle, float modifier) //_SET_OVERRIDE_TRACTION_LOSS_MULTIPLIER
        {
            Function.Call<int>((Hash)0xAFD262ACCA64479A, vehicle, modifier); 
            return;
        }
        public static void SetDriftSlipAngleLimits(int vehicle, float durationScalar, float amplitudeScalar, float slipAngleLimit) //_SET_DRIFT_SLIP_ANGLE_LIMITS
        {
            Function.Call<int>((Hash)0xDAF4C98C18AC6F06, vehicle, durationScalar, amplitudeScalar, slipAngleLimit); 
            return;
        }
        public static void SetMinimumTimeBetweenGearShifts(int vehicle, int time) //_SET_MINIMUM_TIME_BETWEEN_GEAR_SHIFTS
        {
            Function.Call<int>((Hash)0x16CFBC5E7EB32861, vehicle, time); 
            return;
        }
        public static void FullyChargeNitrous(int vehicle) //_CHARGE_NITROUS
        {
            Function.Call<int>((Hash)0x1A2BCC8C636F9226, vehicle); 
            return;
        }
        public static void ClearNitrous(int vehicle) //_NITROUS
        {
            Function.Call<int>((Hash)0xC889AE921400E1ED, vehicle); 
            return;
        }
        public static void ApplyEmpEffect(int vehicle) //_EMP_EFFECT
        {
            Function.Call<int>((Hash)0x249249D74F813EB2, vehicle); 
            return;
        }
        public static void SetAllowCollisionWhenInVehicle(int vehicle, bool toggle) //_SET_ALLOW_COLLISION_WHEN_IN_VEHICLE
        {
            Function.Call<int>((Hash)0x27D27223E8EF22ED, vehicle, toggle); 
            return;
        }
        public static void SetWeaponPedDamageModifier(uint weapon, float damageModifier) //_SET_WEAPON_PED_DAMAGE_MODIFIER
        {
            Function.Call<int>((Hash)0x1091922715B68DF0, weapon, damageModifier); 
            return;
        }
        public static int GetContentPropType(uint model) //_GET_CONTENT_PROP_TYPE
        {
            return Function.Call<int>((Hash)0x8BAF8AD59F47AAFC, model); 
        }
        public static bool HasPedClearLosToEntity(int ped, int entity, float x, float y, float z, int p5, bool p6, bool p7) //_HAS_PED_CLEAR_LOS_TO_ENTITY
        {
            return Function.Call<bool>((Hash)0xA32ABFEB2A03B306, ped, entity, x, y, z, p5, p6, p7); 
        }
        public static int GetPlayerTargetingMode() //_PLAYER_TARGETING_MODE
        {
            return Function.Call<int>((Hash)0x875BDD898B99C8CE); 
        }
        public static float GetVehicleThrottle(int vehicle) //_GET_VEHICLE_THROTTLE
        {
            return Function.Call<float>((Hash)0x92D96892FC06AF22, vehicle); 
        }
        public static int GetVehicleModelNumDriveGears(uint vehicleModel) //_GET_VEHICLE_MODEL_NUM_DRIVE_GEARS
        {
            return Function.Call<int>((Hash)0x61F02E4E9A7A61EA, vehicleModel); 
        }
        public static int GetVehicleMaxDriveGearCount(int vehicle) //_GET_VEHICLE_MAX_DRIVE_GEAR_COUNT
        {
            return Function.Call<int>((Hash)0x24910C3D66BA770D, vehicle); 
        }
        public static int GetVehicleCurrentDriveGear(int vehicle) //_GET_VEHICLE_CURRENT_DRIVE_GEAR
        {
            return Function.Call<int>((Hash)0x56185A25D45A0DCD, vehicle); 
        }
        public static float GetVehicleCurrentRevRatio(int vehicle) //_GET_VEHICLE_CURRENT_REV_RATIO
        {
            return Function.Call<float>((Hash)0xF9DDA40BC293A61E, vehicle); 
        }
        public static int GetVehicleDesiredDriveGear(int vehicle) //_GET_VEHICLE_DESIRED_DRIVE_GEAR
        {
            return Function.Call<int>((Hash)0xFD8CE53356B5D745, vehicle); 
        }
        public static float GetRemainingNitrousDuration(int vehicle) //_GET_REMAINING_NITROUS_DURATION
        {
            return Function.Call<float>((Hash)0xBEC4B8653462450E, vehicle); 
        }
        public static bool IsNitrousActive(int vehicle) //_NITROUS_ACTIVE
        {
            return Function.Call<bool>((Hash)0x491E822B2C464FE4, vehicle); 
        }
        public static bool IsVehicleGen9ExclusiveModel(uint vehicleModel) //_IS_VEHICLE_GEN9_EXCLUSIVE_MODEL
        {
            return Function.Call<bool>((Hash)0x6638C0F19DE692FE, vehicleModel); 
        }
        public static int GetVehicleMaxExhaustBoneCount() //_GET_VEHICLE_MAX_EXHAUST_BONE_COUNT
        {
            return Function.Call<int>((Hash)0x3EE18B00CD86C54F); 
        }
        public static bool GetVehicleExhaustBone(int vehicle, int index, ref int boneIndex, ref bool axisX) // GET_CURRENT_TV_SHOW_PLAY_TIME
        {
            return Function.Call<bool>((Hash)0xE728F090D538CB18, vehicle, index, boneIndex, axisX); // i have no fucking clue how this works
        }
    }
    public class b2944
    {
    }
}