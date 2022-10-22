using BepInEx;

namespace GemPower
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("org.bepinex.plugins.jewelcrafting", BepInDependency.DependencyFlags.SoftDependency)]
    public class GemPower : BaseUnityPlugin
    {
    private const string PluginGuid = "com.comoyi.valheim.GemPower";
    private const string PluginName = "GemPower";
    private const string PluginVersion = "1.0.1";
    
        private void Awake()
        {
            Logger.LogInfo($"Plugin {PluginName}-{PluginVersion} is loaded!");
        }
    }
}
