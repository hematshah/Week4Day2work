using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MonsterOnTheRunVersion2
{
    

    public partial class MainForm : Form
    {
        int gravity =8;
        Image gif = Image.FromFile("JumpStanding.gif");
       private SoundPlayer sound = new SoundPlayer("Hearts of Stone Main Menu Animation in Witcher 3 Wild Hunt.wav");


        public MainForm()
        {
            InitializeComponent();
            sound.Play(); // running the sound playing
            pictureBox3.Image = gif;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChooseLevelForm startGame = new ChooseLevelForm();
            startGame.Show();
            this.Hide();

            
           // sound.Stop(); // stopping the sound.

        }

       

       


    }
}
