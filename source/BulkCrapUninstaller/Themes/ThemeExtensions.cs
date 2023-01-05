using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BulkCrapUninstaller.Themes
{
    public static class ThemeExtensions
    {
        public static void SetTheme(this Form form)
        {
            form.BackColor = ThemeManager.CurrentTheme.Background;
            form.ForeColor = ThemeManager.CurrentTheme.Text;

            foreach (Control child in form.GetDescendants())
            {
                child.SetTheme();
            }
        }

        public static void SetTheme(this UserControl control)
        {
            control.BackColor = ThemeManager.CurrentTheme.Background;
            control.ForeColor = ThemeManager.CurrentTheme.Text;
        }

        public static void SetTheme(this Control control)
        {
            control.BackColor = ThemeManager.CurrentTheme.Background;
            control.ForeColor = ThemeManager.CurrentTheme.Text;

            if (control.GetType() == typeof(LinkLabel))
            {
                var label = (LinkLabel)control;
                label.LinkColor = ThemeManager.CurrentTheme.Link;
            }
        }

        public static IEnumerable<Control> GetDescendants(this Control control)
        {
            IEnumerable<Control> children = control.Controls.Cast<Control>();
            return children.Concat(children.SelectMany(c => GetDescendants(c)));
        }
    }
}
