using HarmonyLib;
using Il2Cpp;
using Il2CppMonomiPark.SlimeRancher.DataModel;
using Il2CppMonomiPark.SlimeRancher.UI;

namespace InfiniteNewbucks
{
    [HarmonyPatch(typeof(RanchHouseUI), nameof(RanchHouseUI.Close))]
    internal class RanchClosePatch : Entry
    {
        public static void Postfix(RanchHouseUI __instance) =>
            Utility.Get<PlayerState>("SceneContext")._model.SetCurrency(_maxCurrency);
    }

    [HarmonyPatch(typeof(PlayerState), nameof(PlayerState.SpendCurrency))]
    internal class AddCurrencyPatch : Entry
    {
        public static void Postfix(PlayerModel __instance) =>
            Utility.Get<PlayerState>("SceneContext")._model.SetCurrency(_maxCurrency);
    }
}