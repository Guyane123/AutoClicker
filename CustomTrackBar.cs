using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomTrackBar : TrackBar
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw the trackbar
        Rectangle trackRect = new Rectangle(4, Height / 2 - 4, Width - 8, 8);
        using (var brush = new SolidBrush(Color.FromArgb(43, 43, 43))) // Custom trackbar color
        {
            e.Graphics.FillRectangle(brush, trackRect);
        }

        // Draw a circle to represent the thumb of the trackbar
        Rectangle thumbRect = GetThumbRect();
        using (var thumbBrush = new SolidBrush(ColorTranslator.FromHtml("#506ee3"))) // Custom thumb color
        using (var thumbPen = new Pen(Color.Black))
        {
            e.Graphics.FillEllipse(thumbBrush, thumbRect);
            e.Graphics.DrawEllipse(thumbPen, thumbRect);
        }
    }

    private Rectangle GetThumbRect()
    {
        // Calculate the position and size of the thumb (circle) based on the current value
        int thumbSize = 16; // Adjust the size of the thumb as needed
        int trackRange = Maximum - Minimum;
        int thumbPos = (int)(((float)(Value - Minimum) / trackRange) * (Width - thumbSize));
        int yPos = Height / 2 - thumbSize / 2;

        return new Rectangle(thumbPos, yPos, thumbSize, thumbSize);
    }
}
