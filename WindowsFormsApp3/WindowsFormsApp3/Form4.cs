using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            lbl_over.Hide();
        }

        bool right, left, space;
        int score;

        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.explosion;
                                score++;
                                lbl_score.Text = "Score :" + score;
                            }
                        }
                    }
                }
            }
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds) || player.Bounds.IntersectsWith(AI3.Bounds))
            {
                timer1.Stop();
                lbl_over.Show();
                lbl_over.BringToFront();
            }
        }

        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 33;
            bullet.Top = player.Top + -20;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        void Bullet_Movement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        void Enemy_Movement()
        {
            Random rnd = new Random();
            int x, y, a;
            if (AI1.Top >= 500)
            {
                x = rnd.Next(0, 300);
                AI1.Location = new Point(x, 0);
            }
            if (AI2.Top >= 500)
            {
                y = rnd.Next(0, 300);
                AI2.Location = new Point(y, 0);
            }
            if (AI3.Top >= 500)
            {
                a = rnd.Next(0, 300);
                AI3.Location = new Point(a, 0);
            }
            else
            {
                AI1.Top += 15;
                AI2.Top += 10;
                AI3.Top += 20;
            }
        }

        void Arrow_key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 425)
                {
                    player.Left += 20;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_key_Movement();
            Enemy_Movement();
            Bullet_Movement();
            Game_Result();
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }
    }
}
