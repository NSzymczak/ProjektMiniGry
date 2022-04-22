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
    public partial class Breakout : Form
    {
        public Breakout()
        {
            InitializeComponent();
            
        }
        bool lewo, prawo;

        int ruch = 10;
        int ruchup = 5, ruchside = 2, los, block;

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void KeyIsUp(object sender, KeyEventArgs e) //co gdy klawisz nie jest wciścięty
        {
            if (e.KeyCode == Keys.Left)
            {
                lewo = false;                              
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e) //co gdy klawisz jest wciśnięty
        {
            if (e.KeyCode == Keys.Left)
            {
                lewo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = true;
            }
        }

        private void platformmove_Tick(object sender, EventArgs e) // timer od ruchu platformą
        {
            if (lewo == true && Platform.Left > 0)
            {
                Platform.Left -= ruch;

            }
            if (prawo == true && Platform.Right < 580)
            {
                Platform.Left += ruch;
            }
        }
       
        private void ballmove_Tick(object sender, EventArgs e) //timer od ruchu piłki
        {

            Ball.Location = new Point(Ball.Location.X+ruchside+los%3, Ball.Location.Y + ruchup); //zmienna los mod 3 zapewnia różne kąty poruszania się piłki 
            
            Kolizja(); //sprawdzamy czy nie doszło do kolizji
        }
        private void Kolizja()
        {
            if (Ball.Bounds.IntersectsWith(Platform.Bounds)) //kolizja z paltforma
            {
                ruchup = -ruchup;
                ruchside = -ruchside;
                los = -los;
                los++;
            }
            if (Ball.Bounds.IntersectsWith(wall3.Bounds)) // kolizja z sufitem
            {
                ruchup = -ruchup;
            }
            if (Ball.Bounds.IntersectsWith(wall1.Bounds)) //kolizja ze ścianą
            {
                ruchside = -ruchside;
                los = -los;
            }
            if (Ball.Bounds.IntersectsWith(wall2.Bounds)) //kolizja ze ścianą 
            {
                ruchside = -ruchside;
                los = -los;
            }

            foreach (Control e in this.Controls) // zmiana ruchu po kolizji z blokami 
            {
                if (e is PictureBox && Convert.ToString(e.Tag) =="block")
                {
                    if (Ball.Bounds.IntersectsWith(e.Bounds) && e.Visible==true)
                    {
                        if(los%3==0)ruchside = -ruchside;
                        ruchup = -ruchup;
                        
                    }
                }
                
            }
            foreach (Control e in this.Controls) // znikanie bloków po kolizji
            {
                if (e is PictureBox && Convert.ToString(e.Tag) == "block")
                {
                    if (Ball.Bounds.IntersectsWith(e.Bounds) && e.Visible == true)
                    {
                        e.Visible = false;
                        block++;
                    }
                }

            }
            End();
            if (block==6*21) Wygrana();
          
        }
        private void Wygrana()
        {
            block--;
            DialogResult odp = MessageBox.Show("Wygrana! Chcesz zagrać ponownie?", "Uwaga!", MessageBoxButtons.YesNo); //okienko z pytaniem
                if (odp == DialogResult.Yes)
                {
                     End();
                }
                else
                {
                this.Close();
                }
           
        }
        private void StartButton_Click(object sender, EventArgs e) //Start
        {
            platformmove.Start();
            ballmove.Start();
            StartButton.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e) //Koniec
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void End() //Reset gierki
        {
            if (Ball.Bounds.IntersectsWith(fall.Bounds))
            {
                Ball.Location = new Point(250, 300); 
                Platform.Location = new Point(220,320);
                platformmove.Stop();
                ballmove.Stop();
                StartButton.Visible=true;
                block = 0;
               
                foreach (Control e in this.Controls) //widoczność bloków
                {
                    if (e is PictureBox && Convert.ToString(e.Tag) == "block")
                    {
                        e.Visible = true;
                    }

                }
            }
        }
    }
}
