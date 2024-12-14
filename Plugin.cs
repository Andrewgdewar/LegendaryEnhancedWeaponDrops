using BepInEx;
using BepInEx.Logging;
using LegendaryEnhancedWeaponDrops.Helpers;
using LegendaryEnhancedWeaponDrops.Patches;

namespace LegendaryEnhancedWeaponDrops
{
    [BepInPlugin("LegendaryEnhancedWeaponDrops.settings", "LegendaryEnhancedWeaponDrops", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;

        private void Awake()
        {
            LogSource = Logger;
            new ColorPatch().Enable();
        }
    };
}
