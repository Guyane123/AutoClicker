using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AutoClicker
{
 

    public class RoundedPanel : Panel


    {

        private bool drawBorder = true;

        public bool DrawBorder
        {
            get { return drawBorder; }
            set
            {
                drawBorder = value;
                Invalidate(); // Invalidate the control to trigger a repaint when the border state changes
            }
        }
        public int CornerRadius { get; set; } = 15;
        public Color BorderColor { get; set; } = Color.Black;
        public Color HoverBorderColor { get; set; } = Color.FromArgb(80, 110, 227);
        public bool isMouseOver { get; set; }

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = CreateRoundedRectanglePath(ClientRectangle, CornerRadius))
            {
                // Set the region to the custom rounded rectangle path
                this.Region = new Region(path);

                // Draw the border
                Color currentBorderColor = isMouseOver ? HoverBorderColor : BorderColor;

                if (drawBorder)
                {
                    // Draw a custom border using the desired color and width
                    using (var borderPen = new Pen(currentBorderColor, 2))
                    {
                        // Increase the width of the border by 1 to ensure a consistent width for the entire border
                        Rectangle borderRectangle = new Rectangle(ClientRectangle.X + 1, ClientRectangle.Y + 1, ClientRectangle.Width - 2, ClientRectangle.Height - 2);
                        e.Graphics.DrawPath(borderPen, CreateRoundedRectanglePath(borderRectangle, CornerRadius));
                    }
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isMouseOver = true;
            Invalidate(); // Redraw the control to update the border color
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isMouseOver = false;
            Invalidate(); // Redraw the control to update the border color
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.MouseEnter += ChildControl_MouseEnter;
            e.Control.MouseLeave += ChildControl_MouseLeave;
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
            e.Control.MouseEnter -= ChildControl_MouseEnter;
            e.Control.MouseLeave -= ChildControl_MouseLeave;
        }

        private void ChildControl_MouseEnter(object sender, EventArgs e)
        {
            isMouseOver = true;
            Invalidate(); // Redraw the control to update the border color
        }

        private void ChildControl_MouseLeave(object sender, EventArgs e)
        {
            isMouseOver = false;
            Invalidate(); // Redraw the control to update the border color
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int cornerRadius)
        {
            int diameter = cornerRadius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
