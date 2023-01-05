using System.Drawing;

namespace BulkCrapUninstaller.Themes
{
    public abstract class Theme
    {
        public abstract Color Background { get; }
        public abstract Color Font { get; }
    }
}
