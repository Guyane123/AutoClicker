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
            this.label4 = new System.Windows.Forms.Label();
            this.doubleClickTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.DoubleClickCheckBox = new System.Windows.Forms.CheckBox();
            this.ClickSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoclickerCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mousePos = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClickTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // cPSTrackBar
            // 
            this.cPSTrackBar.AllowDrop = true;
            this.cPSTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cPSTrackBar.CausesValidation = false;
            this.cPSTrackBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.cPSTrackBar.Location = new System.Drawing.Point(12, 102);
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
            this.cps.Location = new System.Drawing.Point(24, 129);
            this.cps.Name = "cps";
            this.cps.Size = new System.Drawing.Size(140, 18);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.doubleClickTrackBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DoubleClickCheckBox);
            this.panel1.Controls.Add(this.ClickSoundCheckBox);
            this.panel1.Controls.Add(this.AutoclickerCheckBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.cps);
            this.panel1.Controls.Add(this.cPSTrackBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 461);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chance : 0%";
            // 
            // doubleClickTrackBar
            // 
            this.doubleClickTrackBar.Location = new System.Drawing.Point(17, 240);
            this.doubleClickTrackBar.Name = "doubleClickTrackBar";
            this.doubleClickTrackBar.Size = new System.Drawing.Size(555, 45);
            this.doubleClickTrackBar.TabIndex = 13;
            this.doubleClickTrackBar.Scroll += new System.EventHandler(this.doubleClickTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Press F6 to toggle";
            // 
            // DoubleClickCheckBox
            // 
            this.DoubleClickCheckBox.AutoSize = true;
            this.DoubleClickCheckBox.Location = new System.Drawing.Point(17, 204);
            this.DoubleClickCheckBox.Name = "DoubleClickCheckBox";
            this.DoubleClickCheckBox.Size = new System.Drawing.Size(162, 30);
            this.DoubleClickCheckBox.TabIndex = 11;
            this.DoubleClickCheckBox.Text = "Double Click";
            this.DoubleClickCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClickSoundCheckBox
            // 
            this.ClickSoundCheckBox.AutoSize = true;
            this.ClickSoundCheckBox.Checked = true;
            this.ClickSoundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ClickSoundCheckBox.Location = new System.Drawing.Point(282, 51);
            this.ClickSoundCheckBox.Name = "ClickSoundCheckBox";
            this.ClickSoundCheckBox.Size = new System.Drawing.Size(151, 30);
            this.ClickSoundCheckBox.TabIndex = 10;
            this.ClickSoundCheckBox.Text = "Click sound";
            this.ClickSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoclickerCheckBox
            // 
            this.AutoclickerCheckBox.AutoSize = true;
            this.AutoclickerCheckBox.Checked = true;
            this.AutoclickerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoclickerCheckBox.Location = new System.Drawing.Point(17, 51);
            this.AutoclickerCheckBox.Name = "AutoclickerCheckBox";
            this.AutoclickerCheckBox.Size = new System.Drawing.Size(147, 30);
            this.AutoclickerCheckBox.TabIndex = 9;
            this.AutoclickerCheckBox.Text = "Autoclicker";
            this.AutoclickerCheckBox.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(170, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Blatant";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doubleClickTrackBar)).EndInit();
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
        private System.Windows.Forms.CheckBox DoubleClickCheckBox;
        private System.Windows.Forms.CheckBox ClickSoundCheckBox;
        private System.Windows.Forms.CheckBox AutoclickerCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar doubleClickTrackBar;
        private System.Windows.Forms.Timer mousePos;
    }
}

