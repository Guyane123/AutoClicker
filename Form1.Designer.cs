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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mousePos = new System.Windows.Forms.Timer(this.components);
            this.rightClick = new System.Windows.Forms.Timer(this.components);
            this.roundedPanel4 = new AutoClicker.RoundedPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.roundedPanel5 = new AutoClicker.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new AutoClicker.RoundedPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.BlatantCheckboxRight = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClickSoundCheckBoxRight = new System.Windows.Forms.CheckBox();
            this.RandomizerCheckBoxRight = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cpsRight = new System.Windows.Forms.Label();
            this.cPSTrackBarRight = new System.Windows.Forms.TrackBar();
            this.panel9 = new System.Windows.Forms.Panel();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.RightClickerOnOff = new AutoClicker.CustomOnOffButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.roundedPanel3 = new AutoClicker.RoundedPanel();
            this.RightClickerLabel = new System.Windows.Forms.Label();
            this.panel2 = new AutoClicker.RoundedPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ClickSoundCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomizerCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cps = new System.Windows.Forms.Label();
            this.cPSTrackBar = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.AutoClickerOnOff = new AutoClicker.CustomOnOffButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new AutoClicker.RoundedPanel();
            this.LeftClickerLabel = new System.Windows.Forms.Label();
            this.Minimize = new AutoClicker.Arrow();
            this.button1 = new AutoClicker.Arrow();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel4.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            this.panel16.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBarRight)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            this.panel12.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Noto Sans Cond", 15.75F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 550);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.roundedPanel4);
            this.panel7.Controls.Add(this.roundedPanel2);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 42);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(20);
            this.panel7.Size = new System.Drawing.Size(898, 506);
            this.panel7.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.Minimize);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(898, 42);
            this.panel6.TabIndex = 16;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licker";
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
            // rightClick
            // 
            this.rightClick.Interval = 1000;
            this.rightClick.Tick += new System.EventHandler(this.rightClick_Tick);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roundedPanel4.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel4.Controls.Add(this.panel15);
            this.roundedPanel4.Controls.Add(this.panel16);
            this.roundedPanel4.CornerRadius = 15;
            this.roundedPanel4.DrawBorder = true;
            this.roundedPanel4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.roundedPanel4.isMouseOver = false;
            this.roundedPanel4.Location = new System.Drawing.Point(23, 139);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(400, 84);
            this.roundedPanel4.TabIndex = 24;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.Controls.Add(this.arrow3);
            this.panel15.Controls.Add(this.label17);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(16);
            this.panel15.Size = new System.Drawing.Size(400, 84);
            this.panel15.TabIndex = 20;
            this.panel15.Click += new System.EventHandler(this.arrow3_Click);
            // 
            // arrow3
            // 
            this.arrow3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrow3.Image = ((System.Drawing.Image)(resources.GetObject("arrow3.Image")));
            this.arrow3.Location = new System.Drawing.Point(347, 33);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(25, 25);
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow3.TabIndex = 22;
            this.arrow3.TabStop = false;
            this.arrow3.Click += new System.EventHandler(this.arrow3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 33);
            this.label17.TabIndex = 21;
            this.label17.Text = "Global";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.Controls.Add(this.roundedPanel5);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 18);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(400, 66);
            this.panel16.TabIndex = 23;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(146)))));
            this.roundedPanel5.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel5.Controls.Add(this.label3);
            this.roundedPanel5.CornerRadius = 10;
            this.roundedPanel5.DrawBorder = true;
            this.roundedPanel5.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.roundedPanel5.isMouseOver = false;
            this.roundedPanel5.Location = new System.Drawing.Point(6, 7);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(384, 45);
            this.roundedPanel5.TabIndex = 18;
            this.roundedPanel5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "DESTRUCT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel2.Controls.Add(this.panel10);
            this.roundedPanel2.Controls.Add(this.panel9);
            this.roundedPanel2.Controls.Add(this.panel12);
            this.roundedPanel2.CornerRadius = 15;
            this.roundedPanel2.DrawBorder = true;
            this.roundedPanel2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.roundedPanel2.isMouseOver = false;
            this.roundedPanel2.Location = new System.Drawing.Point(475, 23);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(400, 84);
            this.roundedPanel2.TabIndex = 16;
            // 
            // panel10
            // 
            this.panel10.AutoScroll = true;
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.cpsRight);
            this.panel10.Controls.Add(this.cPSTrackBarRight);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 84);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(400, 0);
            this.panel10.TabIndex = 22;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.BlatantCheckboxRight);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.ClickSoundCheckBoxRight);
            this.panel11.Controls.Add(this.RandomizerCheckBoxRight);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(20, 84);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(195, 184);
            this.panel11.TabIndex = 18;
            // 
            // BlatantCheckboxRight
            // 
            this.BlatantCheckboxRight.AutoSize = true;
            this.BlatantCheckboxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlatantCheckboxRight.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.BlatantCheckboxRight.Location = new System.Drawing.Point(6, 0);
            this.BlatantCheckboxRight.Name = "BlatantCheckboxRight";
            this.BlatantCheckboxRight.Size = new System.Drawing.Size(103, 32);
            this.BlatantCheckboxRight.TabIndex = 6;
            this.BlatantCheckboxRight.Text = "Blatant";
            this.BlatantCheckboxRight.UseVisualStyleBackColor = true;
            this.BlatantCheckboxRight.CheckedChanged += new System.EventHandler(this.BlatantCheckboxRight_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label9.Location = new System.Drawing.Point(17, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Click like human";
            // 
            // ClickSoundCheckBoxRight
            // 
            this.ClickSoundCheckBoxRight.AutoSize = true;
            this.ClickSoundCheckBoxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickSoundCheckBoxRight.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.ClickSoundCheckBoxRight.Location = new System.Drawing.Point(6, 63);
            this.ClickSoundCheckBoxRight.Name = "ClickSoundCheckBoxRight";
            this.ClickSoundCheckBoxRight.Size = new System.Drawing.Size(142, 32);
            this.ClickSoundCheckBoxRight.TabIndex = 10;
            this.ClickSoundCheckBoxRight.Text = "Click sound";
            this.ClickSoundCheckBoxRight.UseVisualStyleBackColor = true;
            // 
            // RandomizerCheckBoxRight
            // 
            this.RandomizerCheckBoxRight.AutoSize = true;
            this.RandomizerCheckBoxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomizerCheckBoxRight.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.RandomizerCheckBoxRight.Location = new System.Drawing.Point(6, 119);
            this.RandomizerCheckBoxRight.Name = "RandomizerCheckBoxRight";
            this.RandomizerCheckBoxRight.Size = new System.Drawing.Size(151, 32);
            this.RandomizerCheckBoxRight.TabIndex = 16;
            this.RandomizerCheckBoxRight.Text = "Randomizer";
            this.RandomizerCheckBoxRight.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label10.Location = new System.Drawing.Point(17, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Allows clicking 20CPS+";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label11.Location = new System.Drawing.Point(18, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Play fake click sound";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "CPS";
            // 
            // cpsRight
            // 
            this.cpsRight.AutoSize = true;
            this.cpsRight.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.cpsRight.Location = new System.Drawing.Point(23, 51);
            this.cpsRight.Name = "cpsRight";
            this.cpsRight.Size = new System.Drawing.Size(133, 18);
            this.cpsRight.TabIndex = 2;
            this.cpsRight.Text = "Clicks Per Seconds : 0";
            // 
            // cPSTrackBarRight
            // 
            this.cPSTrackBarRight.AllowDrop = true;
            this.cPSTrackBarRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cPSTrackBarRight.CausesValidation = false;
            this.cPSTrackBarRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cPSTrackBarRight.LargeChange = 1;
            this.cPSTrackBarRight.Location = new System.Drawing.Point(16, 24);
            this.cPSTrackBarRight.Maximum = 20;
            this.cPSTrackBarRight.Name = "cPSTrackBarRight";
            this.cPSTrackBarRight.Size = new System.Drawing.Size(356, 45);
            this.cPSTrackBarRight.TabIndex = 1;
            this.cPSTrackBarRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cPSTrackBarRight.Scroll += new System.EventHandler(this.cPSTrackBarRight_Scroll);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.arrow2);
            this.panel9.Controls.Add(this.RightClickerOnOff);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(16);
            this.panel9.Size = new System.Drawing.Size(400, 84);
            this.panel9.TabIndex = 20;
            this.panel9.Click += new System.EventHandler(this.arrow2_Click);
            // 
            // arrow2
            // 
            this.arrow2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrow2.Image = ((System.Drawing.Image)(resources.GetObject("arrow2.Image")));
            this.arrow2.Location = new System.Drawing.Point(347, 33);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(25, 25);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 22;
            this.arrow2.TabStop = false;
            this.arrow2.Click += new System.EventHandler(this.arrow2_Click);
            // 
            // RightClickerOnOff
            // 
            this.RightClickerOnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RightClickerOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RightClickerOnOff.ButtonImage = null;
            this.RightClickerOnOff.IsOn = false;
            this.RightClickerOnOff.Location = new System.Drawing.Point(26, 17);
            this.RightClickerOnOff.Name = "RightClickerOnOff";
            this.RightClickerOnOff.Size = new System.Drawing.Size(48, 48);
            this.RightClickerOnOff.TabIndex = 20;
            this.RightClickerOnOff.Text = "customOnOffButton1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Right Clicker";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.roundedPanel3);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 18);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(400, 66);
            this.panel12.TabIndex = 23;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedPanel3.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel3.Controls.Add(this.RightClickerLabel);
            this.roundedPanel3.CornerRadius = 10;
            this.roundedPanel3.DrawBorder = true;
            this.roundedPanel3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.roundedPanel3.isMouseOver = false;
            this.roundedPanel3.Location = new System.Drawing.Point(6, 7);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(384, 45);
            this.roundedPanel3.TabIndex = 18;
            this.roundedPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedPanel3_MouseDown);
            // 
            // RightClickerLabel
            // 
            this.RightClickerLabel.AutoSize = true;
            this.RightClickerLabel.BackColor = System.Drawing.Color.Transparent;
            this.RightClickerLabel.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.RightClickerLabel.ForeColor = System.Drawing.Color.White;
            this.RightClickerLabel.Location = new System.Drawing.Point(90, 8);
            this.RightClickerLabel.Name = "RightClickerLabel";
            this.RightClickerLabel.Size = new System.Drawing.Size(198, 37);
            this.RightClickerLabel.TabIndex = 0;
            this.RightClickerLabel.Text = "BOUND TO F7";
            this.RightClickerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedPanel3_MouseDown);
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
            this.panel2.Location = new System.Drawing.Point(23, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 84);
            this.panel2.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cps);
            this.panel5.Controls.Add(this.cPSTrackBar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 0);
            this.panel5.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.checkBox1);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.ClickSoundCheckBox);
            this.panel8.Controls.Add(this.RandomizerCheckBox);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(20, 84);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(195, 184);
            this.panel8.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.checkBox1.Location = new System.Drawing.Point(6, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 32);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Blatant";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label8.Location = new System.Drawing.Point(17, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Click like human";
            // 
            // ClickSoundCheckBox
            // 
            this.ClickSoundCheckBox.AutoSize = true;
            this.ClickSoundCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClickSoundCheckBox.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.ClickSoundCheckBox.Location = new System.Drawing.Point(6, 63);
            this.ClickSoundCheckBox.Name = "ClickSoundCheckBox";
            this.ClickSoundCheckBox.Size = new System.Drawing.Size(142, 32);
            this.ClickSoundCheckBox.TabIndex = 10;
            this.ClickSoundCheckBox.Text = "Click sound";
            this.ClickSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomizerCheckBox
            // 
            this.RandomizerCheckBox.AutoSize = true;
            this.RandomizerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RandomizerCheckBox.Font = new System.Drawing.Font("Noto Sans", 15.75F);
            this.RandomizerCheckBox.Location = new System.Drawing.Point(6, 119);
            this.RandomizerCheckBox.Name = "RandomizerCheckBox";
            this.RandomizerCheckBox.Size = new System.Drawing.Size(151, 32);
            this.RandomizerCheckBox.TabIndex = 16;
            this.RandomizerCheckBox.Text = "Randomizer";
            this.RandomizerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Allows clicking 20CPS+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 9.75F);
            this.label6.Location = new System.Drawing.Point(18, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Play fake click sound";
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
            this.cPSTrackBar.Size = new System.Drawing.Size(356, 45);
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
            this.panel3.Padding = new System.Windows.Forms.Padding(16);
            this.panel3.Size = new System.Drawing.Size(400, 84);
            this.panel3.TabIndex = 19;
            this.panel3.Click += new System.EventHandler(this.arrow1_Click);
            // 
            // arrow1
            // 
            this.arrow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrow1.Image = ((System.Drawing.Image)(resources.GetObject("arrow1.Image")));
            this.arrow1.Location = new System.Drawing.Point(347, 33);
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
            this.AutoClickerOnOff.Location = new System.Drawing.Point(26, 17);
            this.AutoClickerOnOff.Name = "AutoClickerOnOff";
            this.AutoClickerOnOff.Size = new System.Drawing.Size(48, 48);
            this.AutoClickerOnOff.TabIndex = 20;
            this.AutoClickerOnOff.Text = "customOnOffButton1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(80, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 33);
            this.label7.TabIndex = 21;
            this.label7.Text = "Left Clicker";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.roundedPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 66);
            this.panel4.TabIndex = 20;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.Controls.Add(this.LeftClickerLabel);
            this.roundedPanel1.CornerRadius = 10;
            this.roundedPanel1.DrawBorder = true;
            this.roundedPanel1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(110)))), ((int)(((byte)(227)))));
            this.roundedPanel1.isMouseOver = false;
            this.roundedPanel1.Location = new System.Drawing.Point(6, 7);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(384, 45);
            this.roundedPanel1.TabIndex = 18;
            this.roundedPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedPanel1_MouseDown);
            // 
            // LeftClickerLabel
            // 
            this.LeftClickerLabel.AutoSize = true;
            this.LeftClickerLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeftClickerLabel.Font = new System.Drawing.Font("Noto Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.LeftClickerLabel.ForeColor = System.Drawing.Color.White;
            this.LeftClickerLabel.Location = new System.Drawing.Point(90, 8);
            this.LeftClickerLabel.Name = "LeftClickerLabel";
            this.LeftClickerLabel.Size = new System.Drawing.Size(198, 37);
            this.LeftClickerLabel.TabIndex = 0;
            this.LeftClickerLabel.Text = "BOUND TO F6";
            this.LeftClickerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundedPanel1_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(825, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 30);
            this.Minimize.TabIndex = 5;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(856, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "Form1";
            this.Text = "Ligma Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel4.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            this.panel16.ResumeLayout(false);
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPSTrackBarRight)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            this.panel12.ResumeLayout(false);
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private System.Windows.Forms.Timer click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer mousePos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private Arrow button1;
        private Arrow Minimize;
        private System.Windows.Forms.Panel panel7;
        private RoundedPanel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox RandomizerCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label cps;
        private System.Windows.Forms.CheckBox ClickSoundCheckBox;
        private System.Windows.Forms.TrackBar cPSTrackBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox arrow1;
        private CustomOnOffButton AutoClickerOnOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label LeftClickerLabel;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.CheckBox BlatantCheckboxRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ClickSoundCheckBoxRight;
        private System.Windows.Forms.CheckBox RandomizerCheckBoxRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cpsRight;
        private System.Windows.Forms.TrackBar cPSTrackBarRight;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox arrow2;
        private CustomOnOffButton RightClickerOnOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel12;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label RightClickerLabel;
        private System.Windows.Forms.Timer rightClick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox arrow3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel16;
        private RoundedPanel roundedPanel5;
        private System.Windows.Forms.Label label3;
    }
}

