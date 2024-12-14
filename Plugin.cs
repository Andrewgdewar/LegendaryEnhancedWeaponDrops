using BepInEx;
using LegendaryEnhancedWeaponDrops.Patches;

namespace LegendaryEnhancedWeaponDrops
{
    [BepInPlugin("LegendaryEnhancedWeaponDrops.settings", "LegendaryEnhancedWeaponDrops", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new ColorPatch().Enable();
        }
    };
}
