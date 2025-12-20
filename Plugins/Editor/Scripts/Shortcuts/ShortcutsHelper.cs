using System;

namespace RealtimeCSG.Plugins.Editor.Scripts.Shortcuts {
    public static class ShortcutsHelper {
        public static void RunShortcutIfActive(Action action) {
            if (CSGSettings.EnableRealtimeCSG) {
                action();
            }
        }
    }
}