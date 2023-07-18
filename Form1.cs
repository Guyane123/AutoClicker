using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoClicker
{
    public partial class Form1 : Form, IMessageFilter
    {
        private KeyboardHook keyboardHook;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        Click c = new Click();
        int locationX;
        int locationY;
        private void Form1_Load(object sender, EventArgs e)
        {
            keyboardHook = new KeyboardHook();
            KeyboardHook.Hook();

            KeyboardHook.KeyDown += HandleKeyDown;

        }

        private void HandleKeyDown(int keyCode)
        {
            label2.Text = keyCode.ToString();
            if (keyCode == (int)Keys.F8)
            {
                StopAutoclicker();
            }if(keyCode == (int)Keys.F7)
            {
                StartAutoclicker();
            }
        }
        private void cPSTrackBar_Scroll(object sender, EventArgs e)
        {
            cps.Text = "CPS: " + cPSTrackBar.Value.ToString();
        }

        private void mousePos_Tick(object sender, EventArgs e)
        {
            locationX = Cursor.Position.X;
            locationY = Cursor.Position.Y;
        }

        private int GenerateRandomInterval()
        {
            double minCPS = (int)cPSTrackBar.Value - new Random().NextDouble() * new Random().Next(0,2);
            double maxCPS = (int)cPSTrackBar.Value + new Random().NextDouble() * new Random().Next(0, 2);

            Random random = new Random();
            double randomCPS = random.NextDouble() * (maxCPS - minCPS) + minCPS;
            int randomInterval = (int)(random.Next(new Random().Next(800, 1000), new Random().Next(1000, 1200)) / randomCPS);

            return randomInterval;
        }

        private void click_Tick(object sender, EventArgs e)
        {
            Point Pos = new Point(locationX, locationY);
            c.leftClick(Pos);

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
                click.Interval = new Random().Next(0, 1000) / cPSTrackBar.Value;
                click.Start();

            }
            else
            {
                click.Stop();
            }

            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        public void StopAutoclicker()
        {
            click.Stop();
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
        }


        public bool PreFilterMessage(ref Message m)
        {
            const int WM_KEYDOWN = 0x0100;
            const int WM_KEYUP = 0x0101;

            if (m.Msg == WM_KEYDOWN)
            {
                if ((Keys)m.WParam.ToInt32() == Keys.F8)
                {
                    StopAutoclicker();
                }
            }

            return false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            StartAutoclicker();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            StopAutoclicker();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                cPSTrackBar.Maximum = 50;
            }else
            {
                cPSTrackBar.Maximum = 20;
            }
        }

        private void randomizer_Tick(object sender, EventArgs e)
        {

        }

    }

}
