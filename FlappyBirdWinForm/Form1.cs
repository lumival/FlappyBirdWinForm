using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdWinForm
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gameGravity = 15;
        int scoreLabelText = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gameGravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + scoreLabelText;


            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                scoreLabelText++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                scoreLabelText++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(groundBox.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }

            if (scoreLabelText > 5)
            {
                pipeSpeed = 10;
            }

            if (scoreLabelText > 15)
            {
                pipeSpeed = 15;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gameGravity = -15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gameGravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
        }
    }
}
