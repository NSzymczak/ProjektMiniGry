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
    public partial class Galaxy : Form
    {
        public Galaxy()
        {
            InitializeComponent();
            
        }

        bool lewo, prawo, gora, dol;
        int ruch = 10;

        private void Form1_Load(object sender, EventArgs e) //start timerów
        {
            ruchprzeciwników.Start();
            move.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) //ruchy przeciwników
        {
            int granica = this.Width;
            foreach (Control enemy in this.Controls)
            {
                if (enemy is PictureBox && Convert.ToString(enemy.Tag) == "enemy")
                {
                    if (enemy.Location.X > granica - enemy.Width) // gdy ucieknie poza okienko przenosi sie spowrotem na początek
                    {
                        enemy.Location = new Point(1, enemy.Location.Y);
                    }
                    else //ruch po 10 
                    {
                        enemy.Location = new Point(enemy.Location.X + 10, enemy.Location.Y);
                    }
                }
            }
        }

        private void Kolizja() //kolizja z przeciwnikiem = koniec gry
        {
            foreach (Control e in this.Controls)
            {
                if (e is PictureBox && Convert.ToString(e.Tag) == "enemy")
                {
                    if (player.Bounds.IntersectsWith(e.Bounds))
                    {
                        player.Location = new Point(190, 400);
                        ResetPunktów();
                    }
                }
            }
        }

        private void Punkty() //zbieranie punktów
        {
            foreach (Control coin in this.Controls)
            {
                if (coin is PictureBox && Convert.ToString(coin.Tag) == "coin")
                {
                    if (player.Bounds.IntersectsWith(coin.Bounds))
                    {
                        coin.Visible = false;
                    }
                }
            }
        }

        private void move_Tick(object sender, EventArgs e) //ruch gracza
        {
            
            if (lewo == true && player.Left>0)
            {
                player.Left -= ruch;
                
            }
            if (prawo == true && player.Right < 450)
            {
                player.Left += ruch;
            }
            if (gora == true && player.Top > 0)
            {
                player.Top -= ruch;
            }
            if (dol == true && player.Top < 600)
            {
                player.Top += ruch;
            }
            Kolizja();
            Punkty();
            Wygrana();
          
        }

        private void Wygrana() //wygrana = dojscie do końca i zebranie wszystkich punktów
        {
            if (player.Bounds.IntersectsWith(Koniec.Bounds) && 
                coin1.Visible == false && 
                coin2.Visible == false && 
                coin3.Visible == false && 
                coin4.Visible == false && 
                coin5.Visible == false && 
                coin6.Visible == false && 
                coin7.Visible == false && 
                coin8.Visible == false && 
                coin9.Visible == false && 
                coin10.Visible == false && 
                coin11.Visible == false)
            {
                move.Stop();
                ruchprzeciwników.Stop();
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

        private void ResetPunktów()
        {
           
            foreach (Control coin in this.Controls)
            {
                if (coin is PictureBox && Convert.ToString(coin.Tag) == "coin")
                {
                   coin.Visible = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Restartuj()
        {
            ruchprzeciwników.Start();
            player.Location = new Point(190, 400);
            ResetPunktów();
            move.Start();
            lewo = false;
            prawo = false;
            gora = false;
            dol = false;
        }
        private void keydown(object sender, KeyEventArgs e)
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

        private void keyup(object sender, KeyEventArgs e)
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
    }
}
