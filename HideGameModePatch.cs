using HarmonyLib;
using System.Reflection;
using EFT.UI;
using SPT.Reflection.Patching;

namespace HideBetaRework.Patches
{
    internal class HideGameModePatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(MenuScreen), nameof(MenuScreen.ChangeToReconnectionAvailable));
        }

        [PatchPostfix]
        static void Postfix(MenuScreen __instance)
        {
            __instance._toggleGameModeButton.gameObject.SetActive(false);
        }
    }
}
