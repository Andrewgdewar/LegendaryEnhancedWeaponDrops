using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using JsonType;
using SPT.Reflection.Patching;
using UnityEngine;

namespace LEWD.Patches
{
    public class ColorPatch : ModulePatch
    {
        private static Dictionary<TaxonomyColor, Color> ColorDictionary = new Dictionary<
            TaxonomyColor,
            Color
        >
        {
            { TaxonomyColor.blue, new Color32(28, 65, 86, byte.MaxValue) },
            { TaxonomyColor.yellow, new Color32(104, 102, 40, byte.MaxValue) },
            { TaxonomyColor.green, new Color32(21, 45, 0, byte.MaxValue) },
            { TaxonomyColor.red, new Color32(109, 36, 24, byte.MaxValue) },
            { TaxonomyColor.tracerYellow, new Color32(0, 96, 200, byte.MaxValue) },
            { TaxonomyColor.tracerGreen, new Color32(47, 200, 80, byte.MaxValue) },
            { TaxonomyColor.tracerRed, new Color32(137, 58, 183, byte.MaxValue) },
            { TaxonomyColor.black, new Color32(0, 0, 0, byte.MaxValue) },
            { TaxonomyColor.grey, new Color32(29, 29, 29, byte.MaxValue) },
            { TaxonomyColor.violet, new Color32(76, 42, 85, byte.MaxValue) },
            { TaxonomyColor.orange, new Color32(60, 25, 0, byte.MaxValue) },
            { TaxonomyColor.@default, new Color32(127, 127, 127, byte.MaxValue) },
        };

        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(GClass1320), nameof(GClass1320.ToColor));
        }

        [PatchPrefix]
        static bool Prefix(ref Color __result, TaxonomyColor taxonomyColor)
        {
            __result = ColorDictionary[taxonomyColor];
            return false; // make sure you only skip if really necessary
        }
    }
}
