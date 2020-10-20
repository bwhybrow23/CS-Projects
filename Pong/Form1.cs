using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class PongGame : Form
    {
        bool goup; //Detect player up position
        bool godown; //Detect player down position
        int speed = 7; //Speed value
        int ballx = 5; //X pos of the ball
        int bally = 5; //Y pos of the ball
        int score = 0; //Score for the player
        int cpuPoint = 0; // CPU Score

        public PongGame()
        {
            InitializeComponent();
        }

        //Timer to wait a certain amount of time
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //Change bool value for up key
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                //Change bool value for down key
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //Change bool value for up key
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                //Change bool value for down key
                godown = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score; // Show player score
            cpuLabel.Text = "" + cpuPoint; // Show CPU score

            ball.Top -= bally;
            ball.Left -= ballx;

            cpu.Top += speed;
            cpu.Top = ball.Top + 30;

            if (score < 5)
            {
                //Score less than 5
                if(cpu.Top < 0 || cpu.Top > 455)
                {
                    //Check if CPU has gone out of bounds and reverse direction
                    speed = -speed;
                }
            } else
            {
                // Allow the CPU to follow the ball more easier if score above 5
                cpu.Top = ball.Top + 20;
            }

            if(score >= 5 && cpuPoint >= 8)
            {
                //Give some free space to allow the user to catch up
                cpu.Top = ball.Top + 25;
                speed = speed + 2;
            }
            if(score >= 8 && cpuPoint >= 8)
            {
                cpu.Top = ball.Top = 23;
            }

            //Check score
            //If CPU scores
            if (ball.Left < 0)
            {
                ball.Left = 434; // reset the ball
                ballx = -ballx; // change direction
                ballx -= 2; // increase speed
                cpuPoint++; // add point to CPU
                wait(2000); //wait a second for player to get ready
            }

            //If Player scores
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434; // reset the ball
                ballx = -ballx; // change direction
                ballx += 2; // increase speed
                score++; // add point to player
                wait(2000); //wait a second for player to get ready
            }

            //Controlling the Ball
            //If the ball reaches the top or bottom of the screen
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                //reverse speed
                bally = -bally;
            }

            //Bounce off player or CPU's pad
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }

            // Controlling the pad
            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }
            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }

            //Final score and ending game
            if(score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You win this game!");
            }
            if(cpuPoint > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins, you lose! Better luck next time!");
            }
        }

    }
}
