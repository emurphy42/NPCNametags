using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace NPCNametags
{
    class ModConfig
    {
        public KeybindList ToggleKey = KeybindList.Parse("None");
        public string TextColor = "#FFFFFF";
        public string BackgroundColor = "#000000";
        public float BackgroundOpacity = 0.6f;
        public bool AlsoApplyOpacityToText = false;
    }
}
