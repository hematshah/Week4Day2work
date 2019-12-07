namespace MonsterOnTheRunVersion2
{
    partial class ChooseLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevelForm));
            this.easymodebutton = new System.Windows.Forms.Button();
            this.hardmodebutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // easymodebutton
            // 
            this.easymodebutton.BackColor = System.Drawing.Color.Transparent;
            this.easymodebutton.FlatAppearance.BorderSize = 0;
            this.easymodebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easymodebutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easymodebutton.ForeColor = System.Drawing.Color.Transparent;
            this.easymodebutton.Image = ((System.Drawing.Image)(resources.GetObject("easymodebutton.Image")));
            this.easymodebutton.Location = new System.Drawing.Point(12, 112);
            this.easymodebutton.Name = "easymodebutton";
            this.easymodebutton.Size = new System.Drawing.Size(292, 54);
            this.easymodebutton.TabIndex = 2;
            this.easymodebutton.UseVisualStyleBackColor = false;
            this.easymodebutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // hardmodebutton
            // 
            this.hardmodebutton.BackColor = System.Drawing.Color.Transparent;
            this.hardmodebutton.FlatAppearance.BorderSize = 0;
            this.hardmodebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hardmodebutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardmodebutton.ForeColor = System.Drawing.Color.Transparent;
            this.hardmodebutton.Image = ((System.Drawing.Image)(resources.GetObject("hardmodebutton.Image")));
            this.hardmodebutton.Location = new System.Drawing.Point(243, 240);
            this.hardmodebutton.Name = "hardmodebutton";
            this.hardmodebutton.Size = new System.Drawing.Size(329, 51);
            this.hardmodebutton.TabIndex = 3;
            this.hardmodebutton.UseVisualStyleBackColor = false;
            this.hardmodebutton.Click += new System.EventHandler(this.hardmodebutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 81);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.Location = new System.Drawing.Point(147, 415);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(66, 51);
            this.Character.TabIndex = 5;
            this.Character.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(457, 326);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 81);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // ChooseLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 611);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hardmodebutton);
            this.Controls.Add(this.easymodebutton);
            this.Name = "ChooseLevelForm";
            this.Text = "ChooseLevelForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button easymodebutton;
        private System.Windows.Forms.Button hardmodebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}