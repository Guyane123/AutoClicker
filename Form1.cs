using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Click;

namespace AutoClicker
{
    public partial class Form1 : Form, IMessageFilter
    {
        private KeyboardHook keyboardHook;
        private MouseHook mouseHook;
        private SoundPlayer clickSound = new SoundPlayer(@"assets/mouse1.wav");
        private Click c = new Click();

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keyboardHook = new KeyboardHook();
            KeyboardHook.Hook();
            KeyboardHook.KeyDown += HandleKeyUp;

            mouseHook = new MouseHook();
            MouseHook.Hook();
            MouseHook.MouseDown += HandleMouseDown;
            MouseHook.MouseUp += HandleMouseUp;

            arrow1.BackgroundImage = goDown;
        }

        private void HandleKeyUp(int keyCode)
        {
            if (keyCode == (int)Keys.F6)
            {
                AutoclickerCheckBox.Checked = !AutoclickerCheckBox.Checked;
                if (!AutoclickerCheckBox.Checked)
                {
                    StopAutoclicker();
                }
            }
        }

        private void HandleMouseDown()
        {
            if (AutoclickerCheckBox.Checked)
            {
                StartAutoclicker();
            }
        }

        private void HandleMouseUp()
        {
            if (AutoclickerCheckBox.Checked)
            {
                StopAutoclicker();
            }
        }

        private void cPSTrackBar_Scroll(object sender, EventArgs e)
        {
            cps.Text = "CPS: " + cPSTrackBar.Value.ToString();
        }

        private Random random = new Random();
        private double averageInterval = 1000.0;

        private int GenerateRandomInterval()
        {
            double minCPS = (int)cPSTrackBar.Value - random.NextDouble() * 0.5; // Adjust the range here as needed
            double maxCPS = (int)cPSTrackBar.Value + random.NextDouble() * 0.5; // Adjust the range here as needed

            double randomCPS = random.NextDouble() * (maxCPS - minCPS) + minCPS;
            averageInterval = (1000.0 / randomCPS) * 0.9 + averageInterval * 0.1; // Gradual adaptation of average interval

            // Introduce a probability of click clustering (20% chance of cluster)
            int clusterSize = random.Next(2, 6); // You can adjust the cluster size range as needed
            if (random.NextDouble() < 0.2 && randomCPS > 2)
            {
                averageInterval /= clusterSize;
            }

            // Introduce a small hesitation before some clicks (5% chance of hesitation)
            if (random.NextDouble() < 0.05)
            {
                int hesitationDuration = random.Next(50, 200); // You can adjust the hesitation duration range as needed
                averageInterval += hesitationDuration;
            }

            // Use a Gaussian distribution to randomize intervals (adjust the standard deviation as needed)
            double variation = averageInterval * 0.1; // You can adjust the standard deviation as needed
            double randomizedInterval = Math.Max(0, NextGaussian(averageInterval, variation));

            // Introduce a probability of click interruption (10% chance of interruption)
            if (random.NextDouble() < 0.1)
            {
                int interruptionDuration = random.Next(20, 200); // You can adjust the interruption duration range as needed
                randomizedInterval += interruptionDuration;
            }

            return (int)randomizedInterval;
        }

        private double NextGaussian(double mean, double stdDev)
        {
            double u1 = 1.0 - random.NextDouble();
            double u2 = 1.0 - random.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
            return mean + stdDev * randStdNormal;
        }



        private void click_Tick(object sender, EventArgs e)
        {

            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);

            if (ClickSoundCheckBox.Checked)
            {
                clickSound.Play();
            }



            int randomInterval = GenerateRandomInterval();
            label1.Text = randomInterval.ToString();
            click.Interval = randomInterval;
            click.Stop();
            click.Start();
        }



        public void StartAutoclicker()
        {
            click.Stop();
            if (cPSTrackBar.Value != 0)
            {
                click.Enabled = true;
                click.Interval = new Random().Next(900, 1100) / cPSTrackBar.Value;



                click.Start();
            }
            else
            {
                click.Stop();
            }
        }

        public void StopAutoclicker()
        {
            click.Stop();


        }

        public bool PreFilterMessage(ref Message m)
        {
            const int WM_KEYDOWN = 0x0100;
            const int WM_KEYUP = 0x0101;
            const int WM_LBUTTONUP = 0x0201;
            const int WM_LBUTTONDOWN = 0x0202;

            if (m.Msg == WM_KEYDOWN)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.F6)
                {
                    AutoclickerCheckBox.Checked = !AutoclickerCheckBox.Checked;
                }
            }
            else if (m.Msg == WM_LBUTTONDOWN)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.LButton)
                {
                    StartAutoclicker();
                }
            }
            else if (m.Msg == WM_LBUTTONUP)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.LButton)
                {
                    StopAutoclicker();
                }
            }

            return false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cPSTrackBar.Maximum = 50;
            }
            else
            {
                cPSTrackBar.Maximum = 20;
            }
        }
        private bool isOpen = true;

        Bitmap goDown = new Bitmap(@"assets/downarrowimg.png");
        Bitmap goUp = new Bitmap(@"assets/uparrowimg.png");
        private void arrow1_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                panel2.Height = 370;
                arrow1.BackgroundImage = goUp;
            }
            else
            {
                panel2.Height = 50;
                arrow1.BackgroundImage = goDown;
            }
            isOpen = !isOpen;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (isOpen)
            {
                panel2.Height = 370;
                isOpen = !isOpen;
            }
        }
    }



    public class Arrow : Button
    {
        private Color borderColor = Color.FromArgb(30,30,30); 

        public Arrow()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = borderColor;
            this.Height = 50;
            this.Width = 50;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
        }
    }
}
