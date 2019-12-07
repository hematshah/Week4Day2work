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
    public partial class ChooseLevelForm : Form
    {

        Image gif = Image.FromFile("JumpStanding.gif");
        public ChooseLevelForm()
        {
            InitializeComponent();
            Character.Image = gif;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Form1 easyMode = new Form1();
            easyMode.Show();
            this.Hide();
        }

        private void hardmodebutton_Click(object sender, EventArgs e)
        {
            FormHard hardMode = new FormHard();
            hardMode.Show();
            this.Hide();
        }

        
    }
}
