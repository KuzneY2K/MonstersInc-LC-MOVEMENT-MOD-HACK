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
    public class ClimbSpeedPatch
    {
        [HarmonyPostfix]
        static void FasterSprint(ref float ___climbSpeed)
        {
            ___climbSpeed = 15f;
            UnityEngine.Debug.Log(___climbSpeed);
        }
    }
}