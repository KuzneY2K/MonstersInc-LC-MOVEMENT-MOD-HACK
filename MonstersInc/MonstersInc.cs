using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using MonstersInc.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersInc
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MonstersIncBase : BaseUnityPlugin
    {
        private const string modGUID = "BeerMilk.MonstersInc";
        private const string modName = "MonstersInc";
        private const string modVersion ="1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static MonstersIncBase Instance;

        internal ManualLogSource logger;

        void Awake()
        {
            if(Instance == null)
            {
                Instance = this; 
            }

            logger = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            logger.LogInfo("MonstersInc v" + modVersion + " has been booted.");

            harmony.PatchAll(typeof(MonstersIncBase));
            harmony.PatchAll(typeof(SprintPatch));
            harmony.PatchAll(typeof(TargetFOVPatch));
            harmony.PatchAll(typeof(GrabDistancePatch));
            harmony.PatchAll(typeof(CarryWeightPatch));
            harmony.PatchAll(typeof(ClimbSpeedPatch));
            // harmony.PatchAll(typeof(HelmetLightPatch));
        }
    }
}
