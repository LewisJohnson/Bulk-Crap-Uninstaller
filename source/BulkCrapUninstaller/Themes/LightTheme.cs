using System.Drawing;

namespace BulkCrapUninstaller.Themes
{
    public class LightTheme : Theme
    {
        public override Color Background => SystemColors.Control;
        public override Color ButtonBackground => SystemColors.ButtonFace;
        public override Color Text => SystemColors.ControlText;
        public override Color Link => Color.FromArgb(255, 0, 0, 255);
    }
}
