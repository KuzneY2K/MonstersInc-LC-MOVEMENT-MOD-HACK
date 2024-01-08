using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersInc.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    [HarmonyPatch("Update")]
    public class CarryWeightPatch
    {
        [HarmonyPostfix]
        static void FasterSprint(ref float ___carryWeight)
        {
            ___carryWeight = 0.5f;
            UnityEngine.Debug.Log(___carryWeight);
        }
    }
}
