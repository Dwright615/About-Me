// David Wright
// Phong Game
// Description: This app demonstrates how we can use a Windows Form to creat a pong game.
// The game is a one player game and the goal is for the player to defend the bottom
// border of the window and keep the bouncing ball (square) from touching the bottom.
// All other sides of the window should bounce the ball around and if the ball
// hits the players paddle then it will speed up by an increment of one each time.
// if the ball gets past the players paddle then the ball will reset to the center of the screen and 
// its speed will reset back to 1.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phong_Game
{
    public partial class gameArea : Form
    {
        PictureBox picBoxPlayer, picBoxBall;
        Timer gameTime;

        const int SCREEN_WIDTH = 800;
        const int SCREEN_HEIGHT = 600;
    
        Size sizePlayer = new Size(100, 25);
        Size sizeBall = new Size(20, 20);

        int ballSpeedX = 1;
        int ballSpeedY = 1;
        int gameTimeInterval = 1;

        public gameArea()
        {
            InitializeComponent();

            picBoxPlayer = new PictureBox();
            picBoxBall = new PictureBox();

            gameTime = new Timer();

            gameTime.Enabled = true;
            gameTime.Interval = gameTimeInterval;

            gameTime.Tick += new EventHandler(gameTime_Tick);

            this.Width = SCREEN_WIDTH;
            this.Height = SCREEN_HEIGHT;
            this.StartPosition = FormStartPosition.CenterScreen;

            picBoxPlayer.Size = sizePlayer;
            picBoxPlayer.Location = new Point(ClientSize.Width / 2 - picBoxPlayer.Width / 2, ClientSize.Height - picBoxPlayer.Height * 2);
            picBoxPlayer.BackColor = Color.Blue;
            this.Controls.Add(picBoxPlayer);

            picBoxBall.Size = sizeBall;
            picBoxBall.Location = new Point(ClientSize.Width / 2 - picBoxBall.Width / 2, ClientSize.Height / 2 - picBoxBall.Height / 2);
            picBoxBall.BackColor = Color.Green;
            this.Controls.Add(picBoxBall);
        }

        void gameTime_Tick(object sender, EventArgs e)
        {
            picBoxBall.Location = new Point(picBoxBall.Location.X + ballSpeedX, picBoxBall.Location.Y + ballSpeedY);
            gameAreaCollisions();
            paddleCollision();
            playerMovement();
        }

        private void gameAreaCollisions()
        {
            if (picBoxBall.Location.Y < 0)
            {
                ballSpeedY = -ballSpeedY;
            }
            else if (picBoxBall.Location.X > ClientSize.Width - picBoxBall.Width || picBoxBall.Location.X < 0)
            {
                ballSpeedX = -ballSpeedX;
            }
            else if (picBoxBall.Location.Y > ClientSize.Height)
            {
                resetBall();
            }
        }

        private void resetBall()
        {
            picBoxBall.Location = new Point(ClientSize.Width / 2 - picBoxBall.Width / 2, ClientSize.Height / 2 - picBoxBall.Height / 2);
            ballSpeedY = 1;
        }

        private void playerMovement()
        {
            if (this.PointToClient(MousePosition).Y >= picBoxPlayer.Height / 2 && this.PointToClient(MousePosition).Y <= ClientSize.Height - picBoxPlayer.Height / 2)
            {
                int playerX = this.PointToClient(MousePosition).X - picBoxPlayer.Height / 2; 
                int playerY = ClientSize.Height - picBoxPlayer.Height * 2;

                picBoxPlayer.Location = new Point(playerX, playerY);
            }
        }

        private void paddleCollision()
        {
            if (picBoxBall.Bounds.IntersectsWith(picBoxPlayer.Bounds))
            {
                ballSpeedY = -(ballSpeedY+1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
