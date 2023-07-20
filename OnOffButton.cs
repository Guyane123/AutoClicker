using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AutoClicker
{
    public class CustomOnOffButton : Control
    {
        private bool isOn = false;
        private readonly Color onColor = Color.FromArgb(90, 110, 227);
        private readonly Color offColor = Color.FromArgb(37, 37, 37);
        private readonly int borderWidth = 2;
        private bool isMouseOver;

        public bool IsOn
        {
            get { return isOn; }
            set
            {
                isOn = value;
                Invalidate();
            }
        }

        private Image buttonImage; // Private backing field for the ButtonImage property

        public Image ButtonImage
        {
            get { return buttonImage; }
            set
            {
                // Set the private backing field and resize the image to 25x25 pixels
                buttonImage = value?.GetThumbnailImage(25, 25, null, IntPtr.Zero);
                Invalidate();
            }
        }

        public CustomOnOffButton()
        {
            this.Size = new Size(40, 40);
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the button background
            Color bgColor = IsOn ? onColor : offColor;
            using (var bgBrush = new SolidBrush(bgColor))
            {
                e.Graphics.FillEllipse(bgBrush, ClientRectangle);
            }

            // Draw the border
            Color currentBorderColor = isMouseOver ? onColor : Color.Transparent;
            using (var borderPen = new Pen(currentBorderColor, borderWidth))
            {
                e.Graphics.DrawEllipse(borderPen, new Rectangle(borderWidth / 2, borderWidth / 2, Width - borderWidth, Height - borderWidth));
            }

            // Draw the image in the center of the button
            if (ButtonImage != null)
            {
                int imageX = (Width - ButtonImage.Width) / 2;
                int imageY = (Height - ButtonImage.Height) / 2;
                e.Graphics.DrawImage(ButtonImage, imageX, imageY);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            // Toggle the state when the button is clicked
            IsOn = !IsOn;
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
    }
}
