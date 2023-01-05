using System;

namespace BulkCrapUninstaller.Themes
{
    public static class ThemeManager
    {
        private static readonly LightTheme _lightTheme = new LightTheme();
        private static readonly DarkTheme _darkTheme = new DarkTheme();

        private static bool _isDarkMode = true;
        public static readonly Theme CurrentTheme = new DarkTheme();
    }
}
