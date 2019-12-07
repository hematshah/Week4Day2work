using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterOnTheRunVersion2
{
    public partial class FormHard : Form
    {

        Random rnd = new Random();
        double health = Math.Round(3.0, 2);
        int gravity = 8;
        int score = 0;
        int speed = 12;
        bool moveLeft;
        bool moveRight;

        Image imageCharacterLeft;
        Image imageCharacterRight;
        Image imageCharacterStandStill;

        Image tilesLeft;
        Image tilesRight;
        Image tilesSingle;
        Image spikes;

        public FormHard()
        {
            InitializeComponent();
            GetImages();
            TilesImages();
        }

        public void GetImages()
        {
            imageCharacterLeft = Image.FromFile("MovingLeft.gif");
            imageCharacterRight = Image.FromFile("MovingRight.gif");
            imageCharacterStandStill = Image.FromFile("StandingStill.png");
            spikes = Image.FromFile("Spike.png");
        }

        public void TilesImages() 
        {
             tilesLeft = Image.FromFile("Tile_14_150x50.png");
             tilesRight = Image.FromFile("Tile_12_150x50.png");
             tilesSingle = Image.FromFile("Tile_15_150x50.png");

            blockrightshort.BackgroundImage = tilesSingle ;
            blockrightlong.BackgroundImage = tilesRight ;
            blockleftlong.BackgroundImage = tilesLeft ;
            blockleftshort.BackgroundImage = tilesLeft;
            Spike.BackgroundImage = spikes;


        }

        private void playtimer(object sender, EventArgs e)
        {
            player.Top += gravity; // drop the player from the top
            label1.Text = "Score: " + score; // show the score on the label
            label2.Text = "Health: " + Math.Round(health, 2); // show the score on the label

            if (moveLeft && player.Left > 1) 
            // if move left is true and player left is greater than 1
            {
                player.Left -= speed; //move player to the left
                player.Image = imageCharacterLeft;
            }
            if(moveRight && player.Left + player.Width < panel1.Width)
            // if player right is true and player left plus player width is greater than panel1s width
            {
                player.Left += speed; //move player to the right
                player.Image = imageCharacterRight;

            }

            foreach (Control x in panel1.Controls)
            // this for loop has a control called x and will be used to search for components
            // in the panel 1

            {
                if (x is PictureBox && x.Tag == "platform")
                {

                    if (x.Top <= -150)
                    {
                        Door.Dispose();

                    }

                    x.Top -= 5;
                    // move the x to the top by 5 pixels

                    if (x.Top < panel1.Top - x.Height)
                     // if x's top is less then panel 1 top minus x's height
                    {
                        x.Top = panel1.Height + x.Height;
                        //  re-position x top to bottom of panel 1

                        x.Width = rnd.Next(100, 400);
                        // give x a random width
                       
                        score++;
                        // increase score by one
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    // if player collides with x
                    {
                        gravity = 0;
                        // change gravity value to 0 
                        player.Top = x.Top - player.Height;
                        // stop the player from going through the picture box and position it on top
                    }
                    else 
                    {
                        gravity = 15;
                        // if not then change gravity to 8;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds) && health <= Math.Round(0.00, 2))
                    {
                        gameTimer.Stop(); // stop the timer
                        string message = "GAME OVER. Your final Score is ";
                        MessageBox.Show(message, label1.Text + " " + label2.Text);
                        MainForm startGame = new MainForm();
                        startGame.Show();
                        this.Close();
                       // Application.Exit();

                    }

                    if (player.Bounds.IntersectsWith(x.Bounds) && score == 50)
                    {
                        gameTimer.Stop(); // stop the timer
                        string message = "Congratiolations YOU WIN . Your final Score is ";
                        string message2 = " And your Health is ";
                        MessageBox.Show(message, label1.Text + "  " + message2 + label2.Text);
                        MainForm startGame = new MainForm();
                        startGame.Show();
                        this.Close();
                       // Application.Exit();

                    }
                }

                if (x is PictureBox && x.Tag == "spiky")
                {
                    x.Top -= 5;
                    // move the x to the top by 5 pixels

                    if (x.Top < panel1.Top - x.Height)
                    // if x's top is less then panel 1 top minus x's height
                    {
                        x.Top = panel1.Height + x.Height;
                        //  re-position x top to bottom of panel 1

                        x.Width = rnd.Next(50, 50);
                        // give x a random width


                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        // gravity = 0;
                        //Player.Top = x.Top - Player.Height + 1;
                        health = health - 0.1;
                        gravity = 8;

                    }

                    if (player.Bounds.IntersectsWith(x.Bounds) && score == 50)
                    {
                        gameTimer.Stop(); // stop the timer
                        string message = "Congratiolations YOU WIN . Your final Score is ";
                        string message2 = " And your Health is ";
                        MessageBox.Show(message, label1.Text + "  " + message2 + label2.Text);
                        MainForm startGame = new MainForm();
                        startGame.Show();
                        this.Close();
                        //Application.Exit();

                    }

                    if (player.Bounds.IntersectsWith(x.Bounds) && health <= Math.Round(0.00, 2))
                    {
                        gameTimer.Stop(); // stop the timer
                        string message = "GAME OVER. Your final Score is ";
                        MessageBox.Show(message, label1.Text + " " + label2.Text);
                        MainForm startGame = new MainForm();
                        startGame.Show();
                        this.Close();
                       // Application.Exit();

                    }

                }
            }

            if (player.Top + player.Height < 0 || player.Top > panel1.Height)
            // if player top reaches top of the panel OR 
            // player drops to the bottom of the panel
            {
                gameTimer.Stop(); // stop the timer
                string message = "YOU LOST. Your final Score is:  " + score;
                MessageBox.Show(message, label1.Text);
                MainForm startGame = new MainForm();
                startGame.Show();
                this.Close();
               // Application.Exit();
            }

            
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) 
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right) 
            {
                moveRight = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
                player.Image = imageCharacterStandStill;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
                player.Image = imageCharacterStandStill;
            }

        }

       
    }
}
