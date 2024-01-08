using BepInEx;
using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MonstersInc.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    [HarmonyPatch("Update")]
    public class HelmetLightPatch
    {
        [HarmonyBefore]
        static void HelmetLight(ref Light ___helmetLight)
        {
            ___helmetLight.enabled = true;
            UnityEngine.Debug.Log(___helmetLight);
        }
    }
}
