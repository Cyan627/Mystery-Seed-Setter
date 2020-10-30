using BepInEx;
using HarmonyLib;

namespace MysterySeedSetter
{
    [BepInPlugin("com.cyan627.BugFables.plugins.MysterySeedSetter", "Mystery Seed Setter", "1.0.0.0")]
    [BepInProcess("Bug Fables.exe")]
    public class MysterySeedSetterPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            var harmony = new Harmony("com.cyan627.BugFables.harmony.MysterySeedSetter");
            harmony.PatchAll();
            System.Diagnostics.Debug.WriteLine("I'm alive!!");
        }
    }
}
