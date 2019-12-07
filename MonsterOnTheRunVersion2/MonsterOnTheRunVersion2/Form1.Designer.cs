namespace MonsterOnTheRunVersion2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.Panel();
            this.Spikes = new System.Windows.Forms.PictureBox();
            this.Door = new System.Windows.Forms.PictureBox();
            this.blocksingle = new System.Windows.Forms.PictureBox();
            this.blockrightshort = new System.Windows.Forms.PictureBox();
            this.blockleftshort = new System.Windows.Forms.PictureBox();
            this.blockrightlong = new System.Windows.Forms.PictureBox();
            this.blockleftlong = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.timerCollision = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksingle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightshort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftshort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightlong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftlong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.playtimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: 0";
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Transparent;
            this.screen.Controls.Add(this.Spikes);
            this.screen.Controls.Add(this.Door);
            this.screen.Controls.Add(this.blocksingle);
            this.screen.Controls.Add(this.blockrightshort);
            this.screen.Controls.Add(this.blockleftshort);
            this.screen.Controls.Add(this.blockrightlong);
            this.screen.Controls.Add(this.blockleftlong);
            this.screen.Controls.Add(this.Player);
            this.screen.Location = new System.Drawing.Point(0, 1);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(580, 550);
            this.screen.TabIndex = 0;
            // 
            // Spikes
            // 
            this.Spikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spikes.Location = new System.Drawing.Point(295, 447);
            this.Spikes.Name = "Spikes";
            this.Spikes.Size = new System.Drawing.Size(50, 50);
            this.Spikes.TabIndex = 10;
            this.Spikes.TabStop = false;
            this.Spikes.Tag = "spiky";
            // 
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.Transparent;
            this.Door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door.BackgroundImage")));
            this.Door.Location = new System.Drawing.Point(471, 56);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(109, 167);
            this.Door.TabIndex = 9;
            this.Door.TabStop = false;
            this.Door.Tag = "platform";
            // 
            // blocksingle
            // 
            this.blocksingle.BackColor = System.Drawing.Color.Transparent;
            this.blocksingle.Location = new System.Drawing.Point(39, 327);
            this.blocksingle.Name = "blocksingle";
            this.blocksingle.Size = new System.Drawing.Size(148, 50);
            this.blocksingle.TabIndex = 8;
            this.blocksingle.TabStop = false;
            this.blocksingle.Tag = "platform";
            // 
            // blockrightshort
            // 
            this.blockrightshort.BackColor = System.Drawing.Color.Transparent;
            this.blockrightshort.Location = new System.Drawing.Point(432, 419);
            this.blockrightshort.Name = "blockrightshort";
            this.blockrightshort.Size = new System.Drawing.Size(148, 50);
            this.blockrightshort.TabIndex = 7;
            this.blockrightshort.TabStop = false;
            this.blockrightshort.Tag = "platform";
            // 
            // blockleftshort
            // 
            this.blockleftshort.BackColor = System.Drawing.Color.Transparent;
            this.blockleftshort.Location = new System.Drawing.Point(0, 499);
            this.blockleftshort.Name = "blockleftshort";
            this.blockleftshort.Size = new System.Drawing.Size(149, 50);
            this.blockleftshort.TabIndex = 6;
            this.blockleftshort.TabStop = false;
            this.blockleftshort.Tag = "platform";
            // 
            // blockrightlong
            // 
            this.blockrightlong.BackColor = System.Drawing.Color.Transparent;
            this.blockrightlong.Location = new System.Drawing.Point(183, 221);
            this.blockrightlong.Name = "blockrightlong";
            this.blockrightlong.Size = new System.Drawing.Size(397, 48);
            this.blockrightlong.TabIndex = 5;
            this.blockrightlong.TabStop = false;
            this.blockrightlong.Tag = "platform";
            // 
            // blockleftlong
            // 
            this.blockleftlong.BackColor = System.Drawing.Color.Transparent;
            this.blockleftlong.Location = new System.Drawing.Point(0, 66);
            this.blockleftlong.Name = "blockleftlong";
            this.blockleftlong.Size = new System.Drawing.Size(300, 50);
            this.blockleftlong.TabIndex = 1;
            this.blockleftlong.TabStop = false;
            this.blockleftlong.Tag = "platform";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player.Location = new System.Drawing.Point(384, 164);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(63, 51);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // timerCollision
            // 
            this.timerCollision.Enabled = true;
            this.timerCollision.Interval = 1500;
            this.timerCollision.Tick += new System.EventHandler(this.Collisionticker);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health: 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.screen);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "PlatformGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksingle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightshort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftshort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightlong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftlong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox blocksingle;
        private System.Windows.Forms.PictureBox blockrightshort;
        private System.Windows.Forms.PictureBox blockleftshort;
        private System.Windows.Forms.PictureBox blockrightlong;
        private System.Windows.Forms.PictureBox blockleftlong;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.Timer timerCollision;
        private System.Windows.Forms.PictureBox Spikes;
        private System.Windows.Forms.Label label2;
    }
}

