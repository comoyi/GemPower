using BepInEx;

namespace GemPower
{
    [BepInPlugin(pluginGUID, pluginName, pluginVersion)]
    [BepInDependency("org.bepinex.plugins.jewelcrafting", BepInDependency.DependencyFlags.SoftDependency)]
    public class GemPower : BaseUnityPlugin
    {
    private const string pluginGUID = "com.comoyi.valheim.GemPower";
    private const string pluginName = "GemPower";
    private const string pluginVersion = "1.0.1";
    
        private void Awake()
        {
            Logger.LogInfo($"Plugin {pluginName}-{pluginVersion} is loaded!");
        }
    }
}
