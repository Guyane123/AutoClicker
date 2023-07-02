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
            this.startBtn = new System.Windows.Forms.Button();
            this.cPSTrackBar = new System.Windows.Forms.TrackBar();
            this.cps = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.click = new System.Windows.Forms.Timer(this.components);
            this.mousePos = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 355);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(560, 44);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start (F7)";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cPSTrackBar
            // 
            this.cPSTrackBar.Location = new System.Drawing.Point(12, 223);
            this.cPSTrackBar.Name = "cPSTrackBar";
            this.cPSTrackBar.Size = new System.Drawing.Size(560, 45);
            this.cPSTrackBar.TabIndex = 1;
            this.cPSTrackBar.Scroll += new System.EventHandler(this.cPSTrackBar_Scroll);
            // 
            // cps
            // 
            this.cps.AutoSize = true;
            this.cps.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cps.Location = new System.Drawing.Point(221, 289);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(144, 40);
            this.cps.TabIndex = 2;
            this.cps.Text = "CPS : 0";
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(12, 405);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(560, 44);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop (F8)";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // click
            // 
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
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.cps);
            this.panel1.Controls.Add(this.cPSTrackBar);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 461);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TrackBar cPSTrackBar;
        private System.Windows.Forms.Label cps;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Timer click;
        private System.Windows.Forms.Timer mousePos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}

