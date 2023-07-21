using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace AutoClicker
{
    public class ControlButton : Control
    {

        private Color borderColor = Color.FromArgb(26,25,28);

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);

            this.BackColor = borderColor;
            this.ForeColor = Color.White;
            this.Text = this.Text;


            using (var borderPen = new Pen(borderColor, 0))
            {
                e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, Width - 0, Height - 0));
            }
        }
    }
}
