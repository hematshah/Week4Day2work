﻿using System;
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
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        bool goingRight;
        bool goingLeft;
        
        Image imageCharacterLeft;
        Image imageCharacterRight;
        Image imageCharacterStandStill;

        Image tilesLeft;
        Image tilesRight;
        Image tilesSingle;
        Image spikes;
        // Image panelBackGround;

        double health = Math.Round(3.0, 2);
        int score = 0;
        int speed = 15;
        int gravity = 8;

        #region timer1_tick() variables 
        int force;
        //int index = 0;
        //int gravity = 12;
        //bool jump;
        #endregion

        public Form1()
        {
            InitializeComponent();
            GetImages();
            GetTileImages();
          
        }

        public void GetImages() 
        {
             imageCharacterLeft = Image.FromFile("MovingLeft.gif");
             imageCharacterRight = Image.FromFile("MovingRight.gif");
             imageCharacterStandStill = Image.FromFile("StandingStill.png");
        }

        public void GetTileImages()
        {

            tilesLeft = Image.FromFile("Tile_14_150x50.png");
            tilesRight = Image.FromFile("Tile_12_150x50.png");
            tilesSingle = Image.FromFile("Tile_15_150x50.png");
            spikes = Image.FromFile("Spike.png");
            //panelBackGround = Image.FromFile("Forerunner_Design_by_dark-veex_on_DeviantArt_580x600.jpg");

            blocksingle.BackgroundImage = tilesSingle; 
            blockrightshort.BackgroundImage = tilesRight;
            blockrightlong.BackgroundImage = tilesRight;
            blockleftlong.BackgroundImage = tilesLeft;
            blockleftshort.BackgroundImage = tilesLeft;
            Spikes.BackgroundImage = spikes;
            //screen.BackgroundImage = panelBackGround;

        }



      private void timer1_Tick(object sender, EventArgs e)
        {
            //index++;
            //// Gif replay
            //if (goingRight == true && index % 15 == 0) 
            //{
            //    Player.Image = Image.FromFile("MovingRight.gif");
            //}
            //if (goingLeft == true && index % 15 == 0) 
            //{
            //    Player.Image = Image.FromFile("MovingLeft.gif");
            //}


           #region collisions
            //foreach (Control x in screen.Controls)
            //// this for loop has a control called x and will be used to search for components
            //// in the panel 1
            //{
                //if (x is Panel && x.Tag == "platform")
                //{
                //    // rightside collison
                //    if (Player.Right > x.Left && Player.Left < x.Right - Player.Width && Player.Bottom < x.Bottom && x.Bottom > x.Top)
                //    {
                //        goingRight = false;
                //    }

                //    // leftside collision
                //    if (Player.Left < x.Right && Player.Right > x.Left + Player.Width && Player.Bottom < x.Bottom && Player.Bottom > x.Top)
                //    {
                //        goingLeft = false;
                //    }


                    //// top collision
                    //if (Player.Left + Player.Width - 1 > x.Left && Player.Left + Player.Width < x.Left + x.Width + Player.Width && Player.Top + Player.Height >= x.Top && Player.Top < x.Top)
                    //{

                    //    jump = false;
                    //    force = 0;
                    //    Player.Top = x.Location.Y - Player.Height;


                    //}

                    //// head collision
                    //if (Player.Left + Player.Width - 1 > x.Left && Player.Left + Player.Width < x.Left + x.Width + Player.Width && Player.Top - x.Bottom <= 10 && Player.Top - x.Top > -10)
                    //{
                    //    force = -1;
                    //}
                //}
            //} 
            #endregion  */


            //if (goingRight == true) { Player.Left += 3; }
            //if (goingLeft == true) { Player.Left -= 3; }

            //if (jump == true) 
            //{

            //    // falling if the player has jumped before
            //    Player.Top -= force;
            //    force -= 1;

            //}




            //if (Player.Top + Player.Height >= screen.Height)
            //{
            //    Player.Top = screen.Height - Player.Height; // stop falling at the bottom
            //    if (jump == true) 
            //    {
            //        Player.Image = Image.FromFile("StandingStill.png");
            //    }
            //    jump = false;
            //}
            //else 
            //{
            //    Player.Top += 5; // falling
            //}

           

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            {
                goingRight = true;
                
            }
            if (e.KeyCode == Keys.Left) 
            { 
                goingLeft = true;
              
            }
            if (e.KeyCode == Keys.Escape) 
            { 
                this.Close(); // esc --> exit the game
            } 

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            {
                goingRight = false ;

                Player.Image = imageCharacterStandStill;
            }
            if (e.KeyCode == Keys.Left) 
            { 
                goingLeft = false;
                Player.Image = imageCharacterStandStill;

            }
        }

        private void Collisionticker(object sender, EventArgs e)
        {
            foreach (Control x in screen.Controls)
            // this for loop has a control called x and will be used to search for components
            // in the panel 1
            {

                if (x is PictureBox && x.Tag == "platform" )
                {

                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    // if player collides with x
                    {
                        gravity = 0;

                        // change gravity value to 0 
                        Player.Top = x.Top - Player.Height;
                        // stop the player from going through the picture box and position it on top
                    }
                    else
                    {
                        gravity = 8;
                        // if not then change gravity to 8;
                    }
                }
            }

        }

        private void playtimer(object sender, EventArgs e)

        {
            Player.Top += gravity; // drop the player from the top
            label1.Text = "Score: " + score; // show the score on the label
            label2.Text = "Health: " + Math.Round(health,2); // show the score on the label

            if (goingLeft && Player.Left > 1)
            // if move left is true and player left is greater than 1
            {
                Player.Left -= speed; //move player to the left
                Player.Image = imageCharacterLeft;
                
            }
            if (goingRight && Player.Left + Player.Width < screen.Width)
            // if player right is true and player left plus player width is greater than screens width
            {
                Player.Left += speed; //move player to the right
                Player.Image = imageCharacterRight;
                
            }

            foreach (Control x in screen.Controls)
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

                    if (x.Top < screen.Top - x.Height)
                    // if x's top is less then panel 1 top minus x's height
                    {
                        x.Top = screen.Height + x.Height;
                        //  re-position x top to bottom of panel 1

                        x.Width = rnd.Next(100, 300);
                        // give x a random width

                        score++;
                        // increase score by one
                    }

                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    // if player collides with x
                    {
                        gravity = 0;

                        // change gravity value to 0 
                        Player.Top = x.Top - Player.Height + 1;
                        // stop the player from going through the picture box and position it on top
                    }
                    else
                    {
                        gravity = 8;
                        // if not then change gravity to 8;
                    }


                    if (Player.Bounds.IntersectsWith(x.Bounds) && health <= Math.Round(0.00, 2))
                    {
                        gameTimer.Stop(); // stop the timer
                        string message = "GAME OVER. Your final Score is ";
                        MessageBox.Show(message, label1.Text + " " + label2.Text);
                        MainForm startGame = new MainForm();
                        startGame.Show();

                        this.Close();
                       // Application.Exit();

                    }

                    if(Player.Bounds.IntersectsWith(x.Bounds) && score == 100)
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

                    if (x.Top < screen.Top - x.Height)
                    // if x's top is less then panel 1 top minus x's height
                    {
                        x.Top = screen.Height + x.Height;
                        //  re-position x top to bottom of panel 1

                        x.Width = rnd.Next(50, 50);
                        // give x a random width
                        

                    }
                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                       // gravity = 0;
                        //Player.Top = x.Top - Player.Height + 1;
                        health = health - 0.1;
                        gravity = 8;

                    }
                    if (Player.Bounds.IntersectsWith(x.Bounds) && health <= Math.Round(0.00, 2))
                    {
                        gameTimer.Stop(); // stop the timer
                        string message = "GAME OVER. Your final Score is ";
                        MessageBox.Show(message, label1.Text +" "+ label2.Text);
                        MainForm startGame = new MainForm();
                        startGame.Show();

                        this.Close();
                        //Application.Exit();

                    }

                    if (Player.Bounds.IntersectsWith(x.Bounds) && score == 100)
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

                }
            }

           if (Player.Top + Player.Height < 0 || Player.Top > screen.Height)
                          // if player top reaches top of the panel OR 
                        // player drops to the bottom of the panel
           {
                gameTimer.Stop(); // stop the timer
                string message ="YOU LOST. Your final Score is:  " + score;
                MessageBox.Show(message, label1.Text);
                MainForm startGame = new MainForm();
                startGame.Show();
                this.Close();
               // Application.Exit();
                
                          
                        
           }

         


            

        }

        

        #region old code for picturebox platform
        //if (x is PictureBox && x.Tag == "platform")
        //// if x is type of picturebox and has a tag strign platform
        //{
        //    x.Top -= 5;
        //    // move the x to the top by 5 pixels

        //    if (x.Top < screen.Top - x.Height)
        //    // if x's top is less then panel 1 top minus x's height
        //    {
        //        x.Top = screen.Height + x.Height;
        //        //  re-position x top to bottom of panel 1

        //        x.Width = rnd.Next(100, 400);
        //        // give x a random width

        //        score++;
        //        // increase score by one
        //    }

        //    if (Player.Bounds.IntersectsWith(x.Bounds))
        //    // if player collides with x
        //    {
        //        gravity = 0;
        //        // change gravity value to 0 
        //        Player.Top = x.Top - Player.Height;
        //        // stop the player from going through the picture box and position it on top
        //    }
        //    else
        //    {
        //        gravity = 100;
        //        // if not then change gravity to 8;
        //    }




        //}
        #endregion


    }
}
