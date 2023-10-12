using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += Form1_KeyUp;
        }

        string direction;
        int snakeHeight, snakeWidth, appleHeight, appleWidth;
        PictureBox snake, apple;
        Random rnd = new Random();
        
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            buttonStart.Visible = false;
            buttonStart.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snake = pictureBoxSnake;
            snakeHeight = snake.Height;
            snakeWidth = snake.Width;

            apple = pictureBoxApple;
            appleHeight = apple.Height;
            appleWidth = apple.Width;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Snake's movement.
            if (direction == "up")
            {
                pictureBoxSnake.Top -= 3; //Speed of the snake
            }
            else if (direction == "down")
            {
                pictureBoxSnake.Top += 3;
            }
            else if (direction == "left")
            {
                pictureBoxSnake.Left -= 3;
            }
            else if (direction == "right")
            {
                pictureBoxSnake.Left += 3;
            }

            //When Snake reaches the Apple.
            if(snake.Bounds.IntersectsWith(apple.Bounds))
            {
                eat();
            }
        }

        private void eat()
        {
            apple.Location = new Point(rnd.Next(1,500), rnd.Next(1,400));
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                direction = "up";
            }else if (e.KeyCode == Keys.Down)
            {
                direction = "down";
            }else if (e.KeyCode == Keys.Left)
            {
                direction = "left";
            }else if (e.KeyCode == Keys.Right)
            {
                direction = "right";
            }else if (e.KeyCode == Keys.Escape)
            {
                timer.Stop();
                buttonStart.Visible = true;
                buttonStart.Enabled = true;
            }
        }
    }
}
