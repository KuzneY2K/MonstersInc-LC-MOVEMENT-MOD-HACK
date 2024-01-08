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
    public class SprintPatch
    {
        [HarmonyPostfix]
        static void FasterSprint(ref float ___movementSpeed)
        {
            ___movementSpeed = 15f;
            UnityEngine.Debug.Log(___movementSpeed);
        }
    }
}
