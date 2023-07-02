using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Click c = new Click();
        int locationX;
        int locationY;
        private void Form1_Load(object sender, EventArgs e)
        {
            stopBtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click.Stop();
            if(cPSTrackBar.Value != 0)
            {
                click.Enabled = true;
                click.Interval = 1000 / (int)cPSTrackBar.Value;
                click.Start();
            }
            else
            {
                click.Stop();
            }

            startBtn.Enabled = false;
            stopBtn.Enabled = true;
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

        private void click_Tick(object sender, EventArgs e)
        {
            Point Pos = new Point(locationX, locationY);
            c.leftClick(Pos);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            click.Stop();
            stopBtn.Enabled = false;
            startBtn.Enabled = true;
        }





        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
