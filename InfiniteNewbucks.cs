using Il2Cpp;
using MelonLoader;

namespace InfiniteNewbucks
{
    internal class Entry : MelonMod
    {
        public const int _maxCurrency = 999999999;
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {

            switch (sceneName)
            {
                case "PlayerCore":
                    var playerModel = Utility.Get<PlayerState>("SceneContext")._model;
                    playerModel.AddCurrency(_maxCurrency);
                    playerModel.SetCurrency(_maxCurrency);
                    playerModel.SetCurrencyEverCollected(_maxCurrency);
                    break;
                default:
                    if (!sceneName.Contains("Zone"))
                        break;
                    Utility.Get<PlayerState>("SceneContext")._model.SetCurrency(_maxCurrency);
                    break;
            }
        }
    }
}
