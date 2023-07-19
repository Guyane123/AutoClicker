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
            this.cPSTrackBar = new System.Windows.Forms.TrackBar();
            this.cps = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new RoundedPanel();
            this.roundedPanel1 = new RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arrow1 = new AutoClicker.Arrow();
            this.label5 = new System.Windows.Forms.Label();
            this.AutoclickerCheckBox = new System.Windows.Forms.CheckBox();
            this.ClickSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mousePos = new System.Windows.Forms.Timer(this.components);
            this.customTrackBar1 = new CustomTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // cPSTrackBar
            // 
            this.cPSTrackBar.AllowDrop = true;
            this.cPSTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cPSTrackBar.CausesValidation = false;
            this.cPSTrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cPSTrackBar.Location = new System.Drawing.Point(3, 94);
            this.cPSTrackBar.Maximum = 20;
            this.cPSTrackBar.Name = "cPSTrackBar";
            this.cPSTrackBar.Size = new System.Drawing.Size(619, 45);
            this.cPSTrackBar.TabIndex = 1;
            this.cPSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cPSTrackBar.Scroll += new System.EventHandler(this.cPSTrackBar_Scroll);
            // 
            // cps
            // 
            this.cps.AutoSize = true;
            this.cps.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.cps.Location = new System.Drawing.Point(20, 121);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(133, 18);
            this.cps.TabIndex = 2;
            this.cps.Text = "Clicks Per Seconds : 0";
            // 
            // click
            // 
            this.click.Interval = 1000;
            this.click.Tick += new System.EventHandler(this.click_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 461);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.customTrackBar1);
            this.panel2.Controls.Add(this.roundedPanel1);
            this.panel2.Controls.Add(this.cps);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.arrow1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.AutoclickerCheckBox);
            this.panel2.Controls.Add(this.cPSTrackBar);
            this.panel2.Controls.Add(this.ClickSoundCheckBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.CornerRadius = 10;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 367);
            this.panel2.TabIndex = 15;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.Location = new System.Drawing.Point(15, 310);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(631, 40);
            this.roundedPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(218, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOUND TO F6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label6.Location = new System.Drawing.Point(13, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Play fake click sound";
            // 
            // arrow1
            // 
            this.arrow1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.arrow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrow1.Location = new System.Drawing.Point(607, 3);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(50, 50);
            this.arrow1.TabIndex = 17;
            this.arrow1.UseVisualStyleBackColor = true;
            this.arrow1.Click += new System.EventHandler(this.arrow1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Allows clicking 20CPS+";
            // 
            // AutoclickerCheckBox
            // 
            this.AutoclickerCheckBox.AutoSize = true;
            this.AutoclickerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AutoclickerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoclickerCheckBox.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.AutoclickerCheckBox.ForeColor = System.Drawing.Color.White;
            this.AutoclickerCheckBox.Location = new System.Drawing.Point(13, 10);
            this.AutoclickerCheckBox.Name = "AutoclickerCheckBox";
            this.AutoclickerCheckBox.Size = new System.Drawing.Size(170, 37);
            this.AutoclickerCheckBox.TabIndex = 9;
            this.AutoclickerCheckBox.Text = "Autoclicker";
            this.AutoclickerCheckBox.UseVisualStyleBackColor = false;
            // 
            // ClickSoundCheckBox
            // 
            this.ClickSoundCheckBox.AutoSize = true;
            this.ClickSoundCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickSoundCheckBox.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.ClickSoundCheckBox.Location = new System.Drawing.Point(13, 237);
            this.ClickSoundCheckBox.Name = "ClickSoundCheckBox";
            this.ClickSoundCheckBox.Size = new System.Drawing.Size(142, 32);
            this.ClickSoundCheckBox.TabIndex = 10;
            this.ClickSoundCheckBox.Text = "Click sound";
            this.ClickSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 71);
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
            this.checkBox1.Location = new System.Drawing.Point(13, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 32);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Blatant";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
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
            // customTrackBar1
            // 
            this.customTrackBar1.Location = new System.Drawing.Point(348, 170);
            this.customTrackBar1.Name = "customTrackBar1";
            this.customTrackBar1.Size = new System.Drawing.Size(104, 45);
            this.customTrackBar1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ligma Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customTrackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cps;
        private System.Windows.Forms.Timer click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar cPSTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ClickSoundCheckBox;
        private System.Windows.Forms.CheckBox AutoclickerCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer mousePos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Arrow arrow1;
        private RoundedPanel panel2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private CustomTrackBar customTrackBar1;
    }
}

