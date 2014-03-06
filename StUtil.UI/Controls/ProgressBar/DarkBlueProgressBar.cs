﻿using StUtil.Extensions;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace StUtil.UI.Controls
{
    public class DarkBlueProgressBar : CustomProgressBar
    {
        private System.Drawing.Image barImage = (System.Drawing.Image)Properties.Resources.pgbbg;

        public System.Drawing.Image BarImage
        {
            get
            {
                return this.barImage;
            }
            set
            {
                this.barImage = value;
                tb = new TextureBrush(value);
            }
        }

        private TextureBrush tb;

        public Color GradientTopColor { get; set; }

        public Color GradientBottomColor { get; set; }

        public sbyte GradientInnerModifier { get; set; }

        public DarkBlueProgressBar()
        {
            tb = new TextureBrush(barImage);
            GradientTopColor = Color.FromArgb(18, 19, 21);
            GradientBottomColor = Color.FromArgb(77, 75, 78);
            this.BackColor = Color.FromArgb(38, 43, 47);
        }

        public override void DrawEmptyBar(Graphics g)
        {
            g.Clear(this.BackColor);
            Rectangle pgb = new Rectangle(this.BarMargins.Left, this.BarMargins.Top, this.Width - this.BarMargins.Left - this.BarMargins.Right, this.Height - this.BarMargins.Top - this.BarMargins.Bottom);
            if (pgb.Width <= 0 || pgb.Height <= 0)
                return;
            LinearGradientBrush brush = new LinearGradientBrush(pgb, GradientTopColor, GradientBottomColor, 90, false);
            g.FillRoundedRectangle(brush, pgb, 10);
            pgb.Inflate(-2, -2);
            if (pgb.Width <= 0 || pgb.Height <= 0)
                return;
            brush = new LinearGradientBrush(pgb, GradientTopColor.Add(GradientInnerModifier), GradientBottomColor.Add(GradientInnerModifier), 90, false);
            g.FillRoundedRectangle(brush, pgb, 10);
        }

        public override void DrawBarFill(Graphics g)
        {
            Rectangle pgb = new Rectangle(this.BarMargins.Left + 5, this.BarMargins.Top + 5, this.Width - this.BarMargins.Left - this.BarMargins.Right - 10, this.Height - this.BarMargins.Top - this.BarMargins.Bottom - 10);
            pgb.Width = (int)(this.Percent * pgb.Width);
            if (pgb.Width > 0)
            {
                g.FillRoundedRectangle(tb, pgb, 10);
            }
        }

        private int marqueeIndex = 0;
        public override void DrawBarMarquee(Graphics g)
        {
            //int width = this.Width / 8;

            //int right = this.BarMargins.Left + (width * marqueeIndex++);

            int speed = 24;

            int width = this.Width / 8;
            int left = (marqueeIndex++ * (width / speed));
            int maxR = this.Width - this.BarMargins.Left - this.BarMargins.Right - 10;
            if (left + width > maxR)
            {
                width = maxR - left;
            }
            if (left > maxR)
            {
                marqueeIndex = -1;
                width = 0;
                left = (marqueeIndex * (width / speed));
            }
            if (left < this.BarMargins.Left)
            {
                int l = left;
                left = this.BarMargins.Left;
            }
            int x = this.BarMargins.Left + left + 5;
            Rectangle pgb = new Rectangle(x, this.BarMargins.Top + 5, width, this.Height - this.BarMargins.Top - this.BarMargins.Bottom - 10);
            g.FillRoundedRectangle(tb, pgb, 10);
        }
    }
}