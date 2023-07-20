namespace AutoClicker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.click = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new AutoClicker.RoundedPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.RandomizerCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cps = new System.Windows.Forms.Label();
            this.ClickSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.cPSTrackBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.AutoClickerOnOff = new AutoClicker.CustomOnOffButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new AutoClicker.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mousePos = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            this.panel4.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Interval = 1000;
            this.click.Tick += new System.EventHandler(this.click_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(11)))), ((int)(((byte)(13)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 461);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Minimize);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(682, 42);
            this.panel6.TabIndex = 16;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Location = new System.Drawing.Point(616, 7);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(647, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "🫦label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.CornerRadius = 10;
            this.panel2.DrawBorder = true;
            this.panel2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.panel2.isMouseOver = false;
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 268);
            this.panel2.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.RandomizerCheckBox);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.cps);
            this.panel5.Controls.Add(this.ClickSoundCheckBox);
            this.panel5.Controls.Add(this.cPSTrackBar);
            this.panel5.Location = new System.Drawing.Point(0, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(660, 140);
            this.panel5.TabIndex = 21;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label8.Location = new System.Drawing.Point(22, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Click like human";
            // 
            // RandomizerCheckBox
            // 
            this.RandomizerCheckBox.AutoSize = true;
            this.RandomizerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomizerCheckBox.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.RandomizerCheckBox.Location = new System.Drawing.Point(20, 162);
            this.RandomizerCheckBox.Name = "RandomizerCheckBox";
            this.RandomizerCheckBox.Size = new System.Drawing.Size(151, 32);
            this.RandomizerCheckBox.TabIndex = 16;
            this.RandomizerCheckBox.Text = "Randomizer";
            this.RandomizerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label6.Location = new System.Drawing.Point(23, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Play fake click sound";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label5.Location = new System.Drawing.Point(23, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Allows clicking 20CPS+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "CPS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.checkBox1.Location = new System.Drawing.Point(20, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 32);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Blatant";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cps
            // 
            this.cps.AutoSize = true;
            this.cps.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.cps.Location = new System.Drawing.Point(23, 51);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(133, 18);
            this.cps.TabIndex = 2;
            this.cps.Text = "Clicks Per Seconds : 0";
            // 
            // ClickSoundCheckBox
            // 
            this.ClickSoundCheckBox.AutoSize = true;
            this.ClickSoundCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickSoundCheckBox.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.ClickSoundCheckBox.Location = new System.Drawing.Point(21, 121);
            this.ClickSoundCheckBox.Name = "ClickSoundCheckBox";
            this.ClickSoundCheckBox.Size = new System.Drawing.Size(142, 32);
            this.ClickSoundCheckBox.TabIndex = 10;
            this.ClickSoundCheckBox.Text = "Click sound";
            this.ClickSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // cPSTrackBar
            // 
            this.cPSTrackBar.AllowDrop = true;
            this.cPSTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cPSTrackBar.CausesValidation = false;
            this.cPSTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cPSTrackBar.LargeChange = 1;
            this.cPSTrackBar.Location = new System.Drawing.Point(16, 24);
            this.cPSTrackBar.Maximum = 20;
            this.cPSTrackBar.Name = "cPSTrackBar";
            this.cPSTrackBar.Size = new System.Drawing.Size(619, 45);
            this.cPSTrackBar.TabIndex = 1;
            this.cPSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cPSTrackBar.Scroll += new System.EventHandler(this.cPSTrackBar_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.arrow1);
            this.panel3.Controls.Add(this.AutoClickerOnOff);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 71);
            this.panel3.TabIndex = 19;
            this.panel3.Click += new System.EventHandler(this.arrow1_Click);
            // 
            // arrow1
            // 
            this.arrow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrow1.Image = ((System.Drawing.Image)(resources.GetObject("arrow1.Image")));
            this.arrow1.Location = new System.Drawing.Point(626, 25);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(25, 25);
            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow1.TabIndex = 22;
            this.arrow1.TabStop = false;
            this.arrow1.Click += new System.EventHandler(this.arrow1_Click);
            // 
            // AutoClickerOnOff
            // 
            this.AutoClickerOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AutoClickerOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AutoClickerOnOff.ButtonImage = null;
            this.AutoClickerOnOff.IsOn = false;
            this.AutoClickerOnOff.Location = new System.Drawing.Point(13, 10);
            this.AutoClickerOnOff.Name = "AutoClickerOnOff";
            this.AutoClickerOnOff.Size = new System.Drawing.Size(40, 40);
            this.AutoClickerOnOff.TabIndex = 20;
            this.AutoClickerOnOff.Text = "customOnOffButton1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(59, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 33);
            this.label7.TabIndex = 21;
            this.label7.Text = "Clicker";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.roundedPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 66);
            this.panel4.TabIndex = 20;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.DrawBorder = true;
            this.roundedPanel1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.roundedPanel1.isMouseOver = false;
            this.roundedPanel1.Location = new System.Drawing.Point(13, 15);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(631, 45);
            this.roundedPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(219, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOUND TO F6";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mousePos
            // 
            this.mousePos.Enabled = true;
            this.mousePos.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ligma Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cps;
        private System.Windows.Forms.Timer click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar cPSTrackBar;
        private System.Windows.Forms.CheckBox ClickSoundCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer mousePos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private RoundedPanel panel2;
        private System.Windows.Forms.Label label3;
        private CustomOnOffButton AutoClickerOnOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RandomizerCheckBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Minimize;
    }
}

