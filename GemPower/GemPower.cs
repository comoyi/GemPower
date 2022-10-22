using System.Text;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Jewelcrafting;
using GemPower.Gem;
using GemPower.Gem.GemEffect;

namespace GemPower
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("org.bepinex.plugins.jewelcrafting", BepInDependency.DependencyFlags.SoftDependency)]
    public class GemPower : BaseUnityPlugin
    {
        private const string PluginGuid = "com.comoyi.valheim.GemPower";
        private const string PluginName = "GemPower";
        private const string PluginVersion = "1.0.1";

        private readonly Harmony harmony = new Harmony(PluginGuid);

        private static ManualLogSource Log = BepInEx.Logging.Logger.CreateLogSource("GemPower");

        private void Awake()
        {
            API.AddGems(GemDefendPercent.Type, GemDefendPercent.ColorName, GemDefendPercent.Color);
            API.AddGemEffect<GpEffectDefendPercent.Config>(GemDefendPercent.EffectName, "Increase defend by percent", "Increase defend by percent $1.");
            StringBuilder sb = new();
            sb.AppendLine($"{GemDefendPercent.EffectName}:");
            sb.AppendLine("  slot: chest");
            sb.AppendLine($"  gem: {GemDefendPercent.ColorName}");
            sb.AppendLine("  power: [50, 100, 200]");
            API.AddGemConfig(sb.ToString());

            harmony.PatchAll();
            Log.LogInfo($"Plugin {PluginName} loaded");
        }
    }
}
