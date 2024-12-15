using BepInEx;
using LEWD.Patches;

namespace LEWD
{
    [BepInPlugin("LEWD.settings", "LEWD", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new ColorPatch().Enable();
        }
    };
}
