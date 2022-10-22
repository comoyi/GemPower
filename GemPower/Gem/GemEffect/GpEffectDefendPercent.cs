using System;
using HarmonyLib;
using JetBrains.Annotations;
using Jewelcrafting;

namespace GemPower.Gem.GemEffect;

public class GpEffectDefendPercent
{
    [PublicAPI]
    public struct Config
    {
        [InverseMultiplicativePercentagePower] public float Power;
    }

    [HarmonyPatch(typeof(Player), "GetBodyArmor")]
    private class IncreaseArmor
    {
        [HarmonyPostfix]
        private static void Postfix(Player __instance, ref float __result)
        {
            __result += Convert.ToInt64(__result * __instance.GetEffectPower<Config>($"{GemDefendPercent.EffectName}").Power / 100f) ;
        }
    }
}
