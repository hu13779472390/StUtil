﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StUtil.UI.Controls.Theme
{
    public class ThemePanel : Panel, IThemeControl
    {
        private ThemeControlHelper themeHelper;

        private ThemeManager.Style style;
        public ThemeManager.Style Style
        {
            get
            {
                return style;
            }
            set
            {
                style = value;
                themeHelper.ApplyStyles();
            }
        }

        public override System.Drawing.Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                Color? themeColor = ThemeManager.GetThemeColor(Style);
                if (!themeColor.HasValue || themeColor.Value != value)
                {
                    if (Style != ThemeManager.Style.Custom)
                    {
                        Style = ThemeManager.Style.Custom;
                    }
                }
                base.BackColor = value;
            }
        }

        public override System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                Color? themeColor = ThemeManager.GetThemeColor(Style);
                if (!themeColor.HasValue || ThemeManager.GetContrasting(themeColor.Value) != value)
                {
                    if (Style != ThemeManager.Style.Custom)
                    {
                        Style = ThemeManager.Style.Custom;
                    }
                }
                base.ForeColor = value;
            }
        }

        public ThemePanel()
        {
            this.themeHelper = new ThemeControlHelper(this);
            this.Style = ThemeManager.Style.Darker;
        }


        public Color MainColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color SecondaryColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
    }
}
