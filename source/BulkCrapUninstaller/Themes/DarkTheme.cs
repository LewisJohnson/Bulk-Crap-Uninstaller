using System.Drawing;

namespace BulkCrapUninstaller.Themes
{
    public class DarkTheme : Theme
    {
        public override Color Background => Color.FromArgb(255, 34, 39, 46);
        public override Color Text => Color.FromArgb(255, 173, 186, 199);
        public override Color Link => Color.FromArgb(255, 83, 155, 245);
    }
}
