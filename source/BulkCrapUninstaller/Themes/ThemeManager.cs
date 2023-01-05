using System;

namespace BulkCrapUninstaller.Themes
{
    public static class ThemeManager
    {
        private static bool _isDarkMode = true;
        public static readonly Theme CurrentTheme = new DarkTheme();
    }
}
