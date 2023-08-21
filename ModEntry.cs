using System;
using System.Reflection;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using HarmonyLib;

namespace SouthernShores
{
    public class ModEntry : Mod
    {
        internal static IModHelper Helper;

        public override void Entry(IModHelper helper)
        {
            Helper = helper;

            var harmony = new Harmony(ModManifest.UniqueID);

                harmony.Patch(
                    original: AccessTools.Method(typeof(StardewValley.NPC), nameof(StardewValley.NPC.parseMasterSchedule)),
                    prefix: new HarmonyMethod(typeof(Patches), nameof(Patches.parseMasterSchedule_postfix))
                );

            Monitor.Log("Debug message after patching.", LogLevel.Debug);
        }
    }
}
