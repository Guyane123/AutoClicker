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
            this.startBtn = new System.Windows.Forms.Button();
            this.cPSTrackBar = new System.Windows.Forms.TrackBar();
            this.cps = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.click = new System.Windows.Forms.Timer(this.components);
            this.mousePos = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.randomizer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(12, 355);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(560, 44);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start (F7)";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // cPSTrackBar
            // 
            this.cPSTrackBar.AllowDrop = true;
            this.cPSTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cPSTrackBar.CausesValidation = false;
            this.cPSTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cPSTrackBar.Location = new System.Drawing.Point(12, 223);
            this.cPSTrackBar.Maximum = 20;
            this.cPSTrackBar.Name = "cPSTrackBar";
            this.cPSTrackBar.Size = new System.Drawing.Size(560, 45);
            this.cPSTrackBar.TabIndex = 1;
            this.cPSTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cPSTrackBar.Scroll += new System.EventHandler(this.cPSTrackBar_Scroll);
            // 
            // cps
            // 
            this.cps.AutoSize = true;
            this.cps.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cps.Location = new System.Drawing.Point(21, 250);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(140, 18);
            this.cps.TabIndex = 2;
            this.cps.Text = "Clicks Per Seconds : 0";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(12, 405);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(560, 44);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop (F8)";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // click
            // 
            this.click.Interval = 1000;
            this.click.Tick += new System.EventHandler(this.click_Tick);
            // 
            // mousePos
            // 
            this.mousePos.Enabled = true;
            this.mousePos.Interval = 1;
            this.mousePos.Tick += new System.EventHandler(this.mousePos_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.cps);
            this.panel1.Controls.Add(this.cPSTrackBar);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 461);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 175);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Blatant";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // randomizer
            // 
            this.randomizer.Interval = 1000;
            this.randomizer.Tick += new System.EventHandler(this.randomizer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label cps;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer click;
        private System.Windows.Forms.Timer mousePos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar cPSTrackBar;
        private System.Windows.Forms.Timer randomizer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

