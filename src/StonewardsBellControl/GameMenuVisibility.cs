using System.Reflection;
using UnityEngine.UIElements;

namespace StonewardsBellControl
{
    /// <summary>
    /// Mirrors Party HUD's detection of the full-screen game menus that
    /// should hide passive gameplay overlays. Check actual UI state, not
    /// component existence, key presses, or the cursor lock state.
    /// </summary>
    internal static class GameMenuVisibility
    {
        // InventoryScreen is not a BaseMenu. Its UI Toolkit root uses
        // DisplayStyle.None while closed, even if the component exists.
        private static readonly FieldInfo InventoryRootField =
            typeof(InventoryScreen).GetField("inventoryScreen",
                BindingFlags.Instance | BindingFlags.NonPublic);

        // The loading screen is not one of the BaseMenu windows.
        private static readonly FieldInfo LoadingScreenInstanceField =
            typeof(LoadingScreen).GetField("Instance",
                BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        private static readonly FieldInfo LoadingScreenElementField =
            typeof(LoadingScreen).GetField("_loadingScreenElement",
                BindingFlags.Instance | BindingFlags.NonPublic);

        internal static bool IsBlockingGameMenuOpen()
        {
            if (IsLoadingScreenVisible())
                return true;

            var shop = ShopMenu.Instance;
            if (shop != null && shop.IsOpen)
                return true;

            var selection = CharacterSelectionScreen.Instance;
            if (selection != null && selection.IsOpen)
                return true;

            var missions = GlobalMissionMenu.Instance;
            if (missions != null && missions.IsOpen)
                return true;

            var inventory = InventoryScreen.Instance;
            if (inventory != null && InventoryRootField != null)
            {
                var root = InventoryRootField.GetValue(inventory) as VisualElement;
                if (root != null && root.resolvedStyle.display != DisplayStyle.None)
                    return true;
            }

            // Includes upgrade and ring-choice screens between waves.
            var upgrades = RogueLikeUpgradeMenu.Instance;
            return upgrades != null && upgrades.IsOpen;
        }

        private static bool IsLoadingScreenVisible()
        {
            if (LoadingScreenInstanceField == null ||
                LoadingScreenElementField == null)
                return false;

            try
            {
                var instance = LoadingScreenInstanceField.GetValue(null);
                if (instance == null)
                    return false;

                var element = LoadingScreenElementField.GetValue(instance) as VisualElement;
                if (element == null || element.panel == null)
                    return false;

                // A hidden ancestor must hide the whole loading screen.
                for (VisualElement node = element; node != null; node = node.parent)
                {
                    var style = node.resolvedStyle;
                    if (style.display == DisplayStyle.None ||
                        style.visibility == Visibility.Hidden ||
                        style.opacity <= 0.01f)
                        return false;
                }

                return true;
            }
            catch
            {
                // Never interrupt the bell rules if a game update changes
                // a private loading-screen field.
                return false;
            }
        }
    }
}
