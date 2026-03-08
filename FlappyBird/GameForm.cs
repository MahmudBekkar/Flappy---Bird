using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class GameForm : Form
    {
        int gravity = 8;
        int pipeSpeed = 8;
        int score = 0;

        public GameForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void bird_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;

            pipeTop.Left -= pipeSpeed;
            pipeBottom.Left -= pipeSpeed;

            scoreText.Text = "Score: " + score;

            if (pipeTop.Left < -150)
            {
                pipeTop.Left = 800;
                score++;
            }

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if (bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                bird.Top < 0 ||
                bird.Bottom > this.ClientSize.Height)
            {
                endGame();
            }
        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over! Score: " + score;
        }
    }
}