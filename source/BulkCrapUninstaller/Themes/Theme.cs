using System.Drawing;

namespace BulkCrapUninstaller.Themes
{
    public abstract class Theme
    {
        public abstract Color Background { get; }
        public abstract Color ButtonBackground { get; }
        public abstract Color Text { get; }
        public abstract Color Link { get; }
    }
}
