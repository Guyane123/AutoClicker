using System.Drawing;
using System.Windows.Forms;



namespace AutoClicker
{
    public class CustomTrackBar : TrackBar
    {
        private int minimum = 0;
        private int maximum = 100;
        private int value = 0;

        public int Minimum
        {
            get { return minimum; }
            set
            {
                minimum = value;
                Invalidate();
            }
        }

        public int Maximum
        {
            get { return maximum; }
            set
            {
                maximum = value;
                Invalidate();
            }
        }

        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the trackbar
            Rectangle trackRect = new Rectangle(4, Height / 2 - 4, Width - 8, 8);
            using (var brush = new SolidBrush(Color.Blue)) // Custom trackbar color
            {
                e.Graphics.FillRectangle(brush, trackRect);
            }

            // Draw a circle to represent the thumb of the trackbar
            Rectangle thumbRect = GetThumbRect();
            using (var thumbBrush = new SolidBrush(Color.Blue)) // Custom thumb color (blue)
            using (var thumbPen = new Pen(Color.Salmon))
            {
                e.Graphics.FillEllipse(thumbBrush, thumbRect);
                e.Graphics.DrawEllipse(thumbPen, thumbRect);
            }
        }

        private Rectangle GetThumbRect()
        {
            // Calculate the position and size of the thumb (circle) based on the current value
            int thumbSize = 20; // Adjust the size of the thumb as needed
            int trackRange = Maximum - Minimum;
            int thumbPos = (int)(((float)(Value - Minimum) / trackRange) * (Width - thumbSize));
            int yPos = Height / 2 - thumbSize / 2;

            return new Rectangle(thumbPos, yPos, thumbSize, thumbSize);
        }
    }

}