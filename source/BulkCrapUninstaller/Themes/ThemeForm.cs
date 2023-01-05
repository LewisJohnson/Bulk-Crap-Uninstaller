using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BulkCrapUninstaller.Themes
{
    public static class ThemeForm
    {
        public static void SetTheme(this Form form)
        {
            form.BackColor = ThemeManager.CurrentTheme.Background;
            form.ForeColor = ThemeManager.CurrentTheme.Font;
        }
    }
}
