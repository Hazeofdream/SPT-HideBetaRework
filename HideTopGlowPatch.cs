using HarmonyLib;
using System.Reflection;
using EFT.UI;
using UnityEngine;
using UnityEngine.UI;
using SPT.Reflection.Patching;

namespace HideBetaRework.Patches
{
    internal class HideTopGlowPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(EnvironmentUI), nameof(EnvironmentUI.SwitchGlows));
        }

        [PatchPostfix]
        static void Postfix(Image imageToFadeIn)
        {
            imageToFadeIn.color = new Color(0f, 0f, 0f, 1f);
        }
    }
}
