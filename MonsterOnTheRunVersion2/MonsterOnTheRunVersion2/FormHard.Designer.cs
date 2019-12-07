namespace MonsterOnTheRunVersion2
{
    partial class FormHard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Door = new System.Windows.Forms.PictureBox();
            this.blockrightshort = new System.Windows.Forms.PictureBox();
            this.blockleftlong = new System.Windows.Forms.PictureBox();
            this.blockrightlong = new System.Windows.Forms.PictureBox();
            this.blockleftshort = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Spike = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightshort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftlong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightlong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftshort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spike)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Spike);
            this.panel1.Controls.Add(this.Door);
            this.panel1.Controls.Add(this.blockrightshort);
            this.panel1.Controls.Add(this.blockleftlong);
            this.panel1.Controls.Add(this.blockrightlong);
            this.panel1.Controls.Add(this.blockleftshort);
            this.panel1.Controls.Add(this.player);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 550);
            this.panel1.TabIndex = 0;
            // 
            // Door
            // 
            this.Door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door.BackgroundImage")));
            this.Door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Door.Location = new System.Drawing.Point(0, 21);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(111, 172);
            this.Door.TabIndex = 10;
            this.Door.TabStop = false;
            this.Door.Tag = "platform";
            // 
            // blockrightshort
            // 
            this.blockrightshort.BackColor = System.Drawing.Color.Transparent;
            this.blockrightshort.Location = new System.Drawing.Point(0, 476);
            this.blockrightshort.Name = "blockrightshort";
            this.blockrightshort.Size = new System.Drawing.Size(227, 50);
            this.blockrightshort.TabIndex = 1;
            this.blockrightshort.TabStop = false;
            this.blockrightshort.Tag = "platform";
            // 
            // blockleftlong
            // 
            this.blockleftlong.BackColor = System.Drawing.Color.Transparent;
            this.blockleftlong.Location = new System.Drawing.Point(280, 331);
            this.blockleftlong.Name = "blockleftlong";
            this.blockleftlong.Size = new System.Drawing.Size(300, 50);
            this.blockleftlong.TabIndex = 9;
            this.blockleftlong.TabStop = false;
            this.blockleftlong.Tag = "platform";
            // 
            // blockrightlong
            // 
            this.blockrightlong.BackColor = System.Drawing.Color.Transparent;
            this.blockrightlong.Location = new System.Drawing.Point(0, 190);
            this.blockrightlong.Name = "blockrightlong";
            this.blockrightlong.Size = new System.Drawing.Size(227, 50);
            this.blockrightlong.TabIndex = 8;
            this.blockrightlong.TabStop = false;
            this.blockrightlong.Tag = "platform";
            // 
            // blockleftshort
            // 
            this.blockleftshort.BackColor = System.Drawing.Color.Transparent;
            this.blockleftshort.Location = new System.Drawing.Point(401, 33);
            this.blockleftshort.Name = "blockleftshort";
            this.blockleftshort.Size = new System.Drawing.Size(179, 50);
            this.blockleftshort.TabIndex = 0;
            this.blockleftshort.TabStop = false;
            this.blockleftshort.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(117, 144);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(64, 48);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: 0 ";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.playtimer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(294, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Health: 3 ";
            // 
            // Spike
            // 
            this.Spike.BackColor = System.Drawing.Color.Transparent;
            this.Spike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spike.Location = new System.Drawing.Point(340, 144);
            this.Spike.Name = "Spike";
            this.Spike.Size = new System.Drawing.Size(50, 50);
            this.Spike.TabIndex = 11;
            this.Spike.TabStop = false;
            this.Spike.Tag = "spiky";
            // 
            // FormHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormHard";
            this.Text = "Forms";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightshort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftlong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockrightlong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockleftshort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox blockrightshort;
        private System.Windows.Forms.PictureBox blockleftlong;
        private System.Windows.Forms.PictureBox blockrightlong;
        private System.Windows.Forms.PictureBox blockleftshort;
        private System.Windows.Forms.PictureBox Door;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Spike;
    }
}