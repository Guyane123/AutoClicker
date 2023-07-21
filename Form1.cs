using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Claims;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using static Click;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AutoClicker
{


    public partial class Form1 : Form, IMessageFilter
    {
        private KeyboardHook keyboardHook;
        private MouseHook mouseHook;

        private SoundPlayer clickSound = new SoundPlayer(@"assets/mouse1.wav");
        Bitmap goDown = new Bitmap(@"assets/downarrowimg.png");
        Bitmap goUp = new Bitmap(@"assets/uparrowimg.png");

        private Click c = new Click();

        private bool isMouseDown = false;

        private Point lastLocation;

        private Keys LeftClickerBindKey = Keys.F6;
        private Keys RightClickerBindKey = Keys.F7;

        private Random random = new Random();
        private double averageInterval = 1000.0;

        private bool isOpenPanel1 = true;
        private bool isOpenPanel2 = true;
        private bool isOpenPanel3 = true;

        private bool isChangingBound = false;
        private bool isChangingBoundRight = false;




        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void InitializeCustomVScrollBar()
        {
            // Add the custom scrollbar to the form or control
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           

            VerticalScroll.Visible = false;
            //keyboardHook = new KeyboardHook();
            KeyboardHook.Hook();
            KeyboardHook.KeyDown += HandleKeyDown;

            //mouseHook = new MouseHook();
            MouseHook.Hook();
            MouseHook.MouseDown += HandleMouseDown;
            MouseHook.MouseUp += HandleMouseUp;

            MouseHook.RightMouseDown += HandleRightMouseDown;
            MouseHook.RightMouseUp += HandleRightMouseUp;

            arrow1.Image = goDown;
            panel2.Height = 84;
            roundedPanel2.Height = 84;
            roundedPanel4.Height = 84;
            arrow1.SizeMode = PictureBoxSizeMode.StretchImage;


            this.label7.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.arrow1.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.arrow1.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.cPSTrackBar.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.ClickSoundCheckBox.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.AutoClickerOnOff.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.checkBox1.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.cps.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.LeftClickerLabel.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.label4.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.label5.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.label6.MouseEnter += new System.EventHandler(handleChildrenMouseOver);
            this.panel8.MouseEnter += new System.EventHandler(handleChildrenMouseOver);


            AutoClickerOnOff.ButtonImage = Image.FromFile(@"assets/autoclickerimg.png");
            RightClickerOnOff.ButtonImage = Image.FromFile(@"assets/rightautoclickerimg.png");



        }


        private void handleChildrenMouseOver(object sender, EventArgs e)
        {
            panel2.isMouseOver = true;
        }

        private void HandleKeyDown(int keyCode)
        {
            if (keyCode == (int)LeftClickerBindKey)
            {
                AutoClickerOnOff.IsOn = !AutoClickerOnOff.IsOn;
                if (!AutoClickerOnOff.IsOn)
                {
                    StopAutoclicker(click);
                }
            }
            else if (keyCode == (int)RightClickerBindKey)
            {
                RightClickerOnOff.IsOn = !RightClickerOnOff.IsOn;
                if (!RightClickerOnOff.IsOn)
                {
                    StopAutoclicker(rightClick);
                }
            }
        }

        private void HandleMouseDown()
        {
            if (AutoClickerOnOff.IsOn)
            {
                StartAutoclicker(click, cPSTrackBar);
            }
        }

        private void HandleMouseUp()
        {
            if (AutoClickerOnOff.IsOn)
            {
                StopAutoclicker(click);
            }
        }
        private void HandleRightMouseDown()
        {
            if (RightClickerOnOff.IsOn)
            {
                StartAutoclicker(rightClick, cPSTrackBarRight);
            }
        }

        private void HandleRightMouseUp()
        {
            if (RightClickerOnOff.IsOn)
            {
                StopAutoclicker(rightClick);
            }
        }


        private void cPSTrackBar_Scroll(object sender, EventArgs e)
        {
            cps.Text = "CPS: " + cPSTrackBar.Value.ToString();
        }


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

        private void rightClick_Tick(object sender, EventArgs e)
        {
            clicker(rightClick, MouseEventFlags.RIGHTDOWN, MouseEventFlags.RIGHTUP, cPSTrackBarRight);
        }
        private void clicker(System.Windows.Forms.Timer cl, MouseEventFlags leftOrRightDown, MouseEventFlags leftOrRightUp, TrackBar trackbar)
        {
            mouse_event((int)(leftOrRightDown), 0, 0, 0, 0);
            mouse_event((int)(leftOrRightUp), 0, 0, 0, 0);

            if (ClickSoundCheckBox.Checked)
            {
                clickSound.Play();
            }

            int randomInterval = GenerateRandomInterval();

            if (RandomizerCheckBox.Checked)
            {
                cl.Interval = randomInterval;
            }
            else
            {
                cl.Interval = 1000 / (int)trackbar.Value;
            }

            cl.Stop();
            cl.Start();
        }
        private void click_Tick(object sender, EventArgs e)
        {
            clicker(click, MouseEventFlags.LEFTDOWN, MouseEventFlags.LEFTUP, cPSTrackBar);

        }



        public void StartAutoclicker(System.Windows.Forms.Timer timer, System.Windows.Forms.TrackBar trackbar)
        {
            timer.Stop();
            if (trackbar.Value != 0)
            {
                timer.Enabled = true;
                timer.Interval = new Random().Next(900, 1100) / trackbar.Value;
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }
        public void StopAutoclicker(System.Windows.Forms.Timer timer)
        {
            timer.Stop();
        }

        public bool PreFilterMessage(ref Message m)
        {
            const int WM_KEYDOWN = 0x0100;
            const int WM_KEYUP = 0x0101;
            const int WM_LBUTTONUP = 0x0201;
            const int WM_LBUTTONDOWN = 0x0202;
            const int WM_RBUTTONDOWN =  0x0204;
            const int WM_RBUTTONUP = 0x0205;

            if (m.Msg == WM_KEYDOWN)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.F6)
                {
                    AutoClickerOnOff.IsOn = !AutoClickerOnOff.IsOn;
                }
                if ((Keys)m.WParam.ToInt32() == Keys.F7) {
                    RightClickerOnOff.IsOn = !RightClickerOnOff.IsOn;
                }
            }
            else if (m.Msg == WM_LBUTTONDOWN)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.LButton)
                {
                    StartAutoclicker(click, cPSTrackBar);
                }
            }
            else if (m.Msg == WM_LBUTTONUP)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.LButton)
                {
                    StopAutoclicker(click);
                }
            }
            else if (m.Msg == WM_RBUTTONDOWN)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.RButton)
                {
                    StartAutoclicker(rightClick, cPSTrackBarRight);
                }
            }
            else if (m.Msg == WM_RBUTTONUP)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.RButton)
                {
                    StopAutoclicker(rightClick);
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
        private void arrow1_Click(object sender, EventArgs e)
        {
            Point rd1 = new Point(23, 139);


            handleChildrenMouseOver(sender, e);
            if (isOpenPanel1)
            {
                panel2.Height = 465;
                arrow1.Image = goUp;
                arrow1.SizeMode = PictureBoxSizeMode.StretchImage;
                roundedPanel4.Location = new Point(roundedPanel4.Location.X, roundedPanel4.Location.Y + panel2.Height - 84);
             

            }
            else
            {
                panel2.Height = 84;
                arrow1.Image = goDown;
                arrow1.SizeMode = PictureBoxSizeMode.StretchImage;
                roundedPanel4.Location = rd1;

            }
            isOpenPanel1 = !isOpenPanel1;

        }

        private void arrow2_Click(object sender, EventArgs e)
        {
            handleChildrenMouseOver(sender, e);
            if (isOpenPanel2)
            {
                roundedPanel2.Height = 465;
                arrow2.Image = goUp;
                arrow2.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            else
            {
                roundedPanel2.Height = 84;
                arrow2.Image = goDown;
                arrow2.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            isOpenPanel2 = !isOpenPanel2;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (isOpenPanel1)
            {
                panel2.Height = 370;
                isOpenPanel1 = !isOpenPanel1;

            }
        }




        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            isMouseDown = false;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            {
                this.Location = new Point(
                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(26,26,27);
        }

        private void cPSTrackBarRight_Scroll(object sender, EventArgs e)
        {
            cpsRight.Text = "Clicks Per Seconds : " + cPSTrackBarRight.Value.ToString();
        }

        private void BlatantCheckboxRight_CheckedChanged(object sender, EventArgs e)
        {
            if(BlatantCheckboxRight.Checked)
            {
                cPSTrackBarRight.Maximum = 50;
            }else
            {
                cPSTrackBarRight.Maximum = 20;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(isChangingBound == true)
            {
                LeftClickerBindKey = (Keys)e.KeyCode;
                LeftClickerLabel.Text = "BOUND TO " + (Keys)e.KeyCode;
                isChangingBound = false;
            }
            if(isChangingBoundRight == true)
            {
                RightClickerBindKey = (Keys)e.KeyCode;
                RightClickerLabel.Text = "BOUND TO " + (Keys)e.KeyCode;
                isChangingBoundRight = false;
            }
        }

        private void roundedPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isChangingBound == false)
            {
                LeftClickerLabel.Text = "PRESS ANY KEY";
                isChangingBound = true;
            }
        }

        private void roundedPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (isChangingBoundRight == false)
            {
                RightClickerLabel.Text = "PRESS ANY KEY";
                isChangingBoundRight = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arrow3_Click(object sender, EventArgs e)
        {

            if(isOpenPanel3 == true)
            {
                roundedPanel4.Height = 370;
            }else
            {
                roundedPanel4.Height = 80;
            }

            isOpenPanel3 = !isOpenPanel3;

        }
    }

}
