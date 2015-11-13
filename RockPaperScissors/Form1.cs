using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int playerCount, computerCount;
            playerCount = 0;
            computerCount = 0;

            InitializeComponent();
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            int playerCount, computerCount;
            playerCount = 0;
            computerCount = 0;

            Random option = new Random();
            int a = option.Next(1, 4);

            if (a == 1)
            {
                scoreText.Text = String.Format("I chose Rock aswell, Draw!");
            }
            else if (a == 2)
            {
                scoreText.Text = String.Format("I chose Paper, you Lose!");
                ++computerCount;
            }
            else if (a == 3)
            {
                scoreText.Text = String.Format("I chose Scissors, you Win!");
                ++playerCount;
            }
            scorePlayer.Text = String.Format(" {0}", playerCount);
            scoreComputer.Text = String.Format("{0} ", computerCount);
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            int playerCount, computerCount;
            playerCount = 0;
            computerCount = 0;

            Random option = new Random();
            int b = option.Next(1, 4);

            if (b == 1)
            {
                scoreText.Text = String.Format("I chose Rock, you Win!");
                ++playerCount;
                
            }
            else if (b == 2)
            {
                scoreText.Text = String.Format("I chose Paper aswell, Draw!");
            }
            else if (b == 3)
            {
                scoreText.Text = String.Format("I chose Scissors, you Lose!");
                ++computerCount;
            }
            scorePlayer.Text = String.Format(" {0}", playerCount);
            scoreComputer.Text = String.Format("{0} ", computerCount);

        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            int playerCount, computerCount;
            playerCount = 0;
            computerCount = 0;

            Random option = new Random();
            int c = option.Next(1, 4);

            if (c == 1)
            {
                scoreText.Text = String.Format("I chose Rock, you Lose!");
                ++playerCount;
            }
            else if (c == 2)
            {
                scoreText.Text = String.Format("I chose Paper, you Win!");
            }
            else if (c == 3)
            {
                scoreText.Text = String.Format("I chose Scissors aswell, Draw!");
                ++computerCount;
            }
            scorePlayer.Text = String.Format(" {0}", playerCount);
            scoreComputer.Text = String.Format("{0} ", computerCount);

        }
    }
}
