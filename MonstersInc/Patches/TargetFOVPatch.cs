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
    public class TargetFOVPatch
    {
        [HarmonyPostfix]
        static void TargetFOV(ref float ___targetFOV)
        {
            ___targetFOV = 120f;
            UnityEngine.Debug.Log(___targetFOV);
        }
    }
}