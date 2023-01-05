using Klocman.Extensions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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

            var children = form.GetAllChildren();

            foreach (Control child in children)
            {
                child.SetTheme();

                if (child.GetType() == typeof(MenuStrip))
                {
                    var menuStrip = (MenuStrip)child;
                    menuStrip.SetDropdownTheme();
                }
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

            if (control.GetType() == typeof(Button))
            {
                control.BackColor = ThemeManager.CurrentTheme.ButtonBackground;
            }
        }

        public static void SetTheme(this ToolStripItem control)
        {
            control.BackColor = ThemeManager.CurrentTheme.Background;
            control.ForeColor = ThemeManager.CurrentTheme.Text;
        }

        public static void SetDropdownTheme(this MenuStrip menuStrip)
        {
            foreach (ToolStripMenuItem strip in menuStrip.Items)
            {
                foreach (ToolStripItem dropDownItem in strip.DropDownItems)
                {
                    dropDownItem.SetTheme();
                }
            }
        }
    }
}
