using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Główna_strona
{
    public partial class Hell : Form
    {
        public Hell()
        {
            InitializeComponent();
        }

        int ruch = 1;
        bool lewo, prawo, gora, dol;

        private void Form2_Load(object sender, EventArgs e)
        {
            PlayerMove.Start(); //timer odpowidajacy z aruch przeciwnika 
        }

        private void PlayerMove_Tick(object sender, EventArgs e) //ruch gracza 
        {
            if (lewo == true)
            {
                Player.Left -= ruch;
            }
            if (prawo == true)
            {
                Player.Left += ruch;
            }
            if (gora == true)
            {
                Player.Top -= ruch;
            }
            if (dol == true)
            {
                Player.Top += ruch;
            }
             Kolizja();
             Wygrana();
        }

        private void EnemyMove_Tick(object sender, EventArgs e) //ruch punktów
        {
            foreach (Control enemy in this.Controls)
            {
                if (enemy is PictureBox && Convert.ToString(enemy.Tag) == "enemy1") //przeciwnicy z środkowego bloku
                {
                    if (enemy.Location.Y > 180) //jak wyleci poza obszar to przenoszą się spowrotem na góre
                    {
                        enemy.Location = new Point(enemy.Location.X, 100);
                    }
                    else
                    {
                        enemy.Location = new Point(enemy.Location.X, enemy.Location.Y+1); //ruch o 1 do przodu
                    }
                }
                if (enemy is PictureBox && Convert.ToString(enemy.Tag) == "enemy2") //przeciwnicy z górnego bloku
                {
                    if (enemy.Location.Y <0)  //jak wyleci poza obszar to przenoszą się spowrotem na góre
                    {
                        enemy.Location = new Point(enemy.Location.X, 100);  
                    }
                    else
                    {
                        enemy.Location = new Point(enemy.Location.X, enemy.Location.Y - 1); //ruch o 1 do przodu
                    }
                }
            }
        }

        private void Klawiszwcisniety(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Left)
            {
                lewo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                gora = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                dol = true;
            }
        }

        private void Klawiszniewcisniety(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                lewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                gora = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                dol = false;
            }
        }

        private void Player_Click(object sender, EventArgs e) //nie potrzebne
        {

        }

        private void Kolizja() //Kolzija = gra od nowa
        {
            foreach (Control wall in this.Controls) //Kolizja ze ścianą 
            {
                if (wall is PictureBox && Convert.ToString(wall.Tag) == "wall")
                {
                    if (Player.Bounds.IntersectsWith(wall.Bounds))
                    {
                        Restartuj();
                    }
                }
            }
            foreach (Control enemy1 in this.Controls) //kolizja z punktami po środku
            {
                if (enemy1 is PictureBox && Convert.ToString(enemy1.Tag) == "enemy1")
                {
                    if (Player.Bounds.IntersectsWith(enemy1.Bounds))
                    {
                        Restartuj();
                    }
                }
            }
            foreach (Control enemy2 in this.Controls) //kolizja z punktami na górze
            {
                if (enemy2 is PictureBox && Convert.ToString(enemy2.Tag) == "enemy2")
                {
                    if (Player.Bounds.IntersectsWith(enemy2.Bounds))
                    {
                        Restartuj();
                    }
                }
            }

        }

        private void Wygrana()
        {
            if (Player.Bounds.IntersectsWith(Win.Bounds))
            {
                PlayerMove.Stop();
                DialogResult odp = MessageBox.Show("Wygrana! Czy chcesz zagrać jeszcze raz?", "Wygrana!", MessageBoxButtons.YesNo);
                if (odp == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    Restartuj();
                }
            }
        }

        private void Restartuj() //Gra od nowa
        {
            Player.Location = new Point(30, 330);
            PlayerMove.Start();
            lewo = false;
            prawo = false;
            gora = false;
            dol = false;

        }

        private void CloseGame_Click(object sender, EventArgs e)
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
