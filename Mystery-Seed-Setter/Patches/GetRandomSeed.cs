using BepInEx.Harmony;
using UnityEngine;
using Unity;
using BepInEx;
using HarmonyLib;
using System;
using System.IO;
using BepInEx.Configuration;

namespace MysterySeedSetter.Patches
{
    [HarmonyPatch(typeof(MainManager), "GetRandomMedal", new Type[] {typeof(bool), typeof(bool)})]

   public class PatchGetRandomMedalUpdate
    {
        static UnityEngine.Random.State rngHold;
        static bool taken = false;
        static int editedSeed;
        private static ConfigEntry<uint> takenSeed;
        private static ConfigEntry<bool> useSeed;
        static uint seedVal = 0;
        private static ConfigFile seedConfig = new ConfigFile(Path.Combine(Paths.ConfigPath, "seedConfig.cfg"), true);
        static void Prefix(bool dontremove, bool random)
        {
            if (!random)
                return;
            useSeed = seedConfig.Bind("General", "UseSeed", false, "Whether or not to use seeds when playing MYSTERY?");
            takenSeed = seedConfig.Bind("General", "SeedNum", defaultValue: seedVal, "This is the seed used to play MYSTERY?. Please insert numbers between 0 and 4,294,967,295 into this field.");
            rngHold = UnityEngine.Random.state;
            if (useSeed.Value)
            {
                taken = true;
                editedSeed = unchecked((int)takenSeed.Value);
                UnityEngine.Random.InitState(editedSeed);
                System.Diagnostics.Debug.WriteLine("Initialized! The seed number is " + editedSeed);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("You didn't use seeds this run! (or the config file broke tremendously lol)");
            }
        }
        static void Postfix(ref int __result)
        {
            if (taken)
            {
                UnityEngine.Random.state = rngHold;
                System.Diagnostics.Debug.WriteLine("All should be good!");
                System.Diagnostics.Debug.WriteLine(MainManager.instance.flagstring[13]);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Help");
            }
        }
    }
}
