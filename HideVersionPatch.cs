using HarmonyLib;
using System.Reflection;
using EFT.UI;
using SPT.Reflection.Patching;

namespace HideBetaRework.Patches
{
    internal class HideVersionPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(PreloaderUI), nameof(PreloaderUI.Awake));
        }

        [PatchPostfix]
        static void Postfix(PreloaderUI __instance)
        {
            __instance._alphaVersionLabel.gameObject.SetActive(false);
        }
    }
}
