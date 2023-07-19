using System;
using System.Drawing;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int CornerRadius { get; set; } = 10; // Change this value to adjust the corner radius

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var path = new System.Drawing.Drawing2D.GraphicsPath())
        {
            int radius = CornerRadius * 2;
            Rectangle bounds = new Rectangle(0, 0, Width, Height);

            // Top-left corner
            path.AddArc(bounds.Left, bounds.Top, radius, radius, 180, 90);

            // Top-right corner
            path.AddArc(bounds.Right - radius, bounds.Top, radius, radius, 270, 90);

            // Bottom-right corner
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);

            // Bottom-left corner
            path.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}