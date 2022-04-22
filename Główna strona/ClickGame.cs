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
    public partial class ClickGame : Form
    {
        public ClickGame()
        {
            InitializeComponent();
            Uciekacz.Enabled = false;
            Uciekacz.Visible = false;

        }

        int wynik = 0;
        int timeLeft = 120;

        private void PrzyciskStart_Click(object sender, EventArgs e) 
        {
           
            PrzyciskStart.Visible = false;
            Naglowek.Visible = false;
            Uciekacz.Enabled = true;
            Uciekacz.Visible = true;
            Koniec.Visible = false;
            wynik = 0;
            Wynik.Text = Convert.ToString(wynik);
            timer1.Start();
            
        }

        private void Uciekacz_Click_1(object sender, EventArgs e) //po klknieciu punktu
        {
            wynik++;
            Wynik.Text = Convert.ToString(wynik);
            Random rnd = new Random();  //losowy punkt w ktory ma się przenieść nasz punkt
            int x = rnd.Next(100, 500);  //losujemy x
            int y = rnd.Next(100, 200); //losujemy y 
            ((Button)sender).Location = new Point(x, y); //przenosimy punkt
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            if (Uciekacz.Enabled == true)
            {
                if (timeLeft > 0) //póki trwa gra
                { 
                    timeLeft = timeLeft - 1;
                    Czasdokonca.Text = timeLeft + " sekund";
                }
                else //koniec gry
                {
                    timer1.Stop();
                    Uciekacz.Enabled = false;
                    Uciekacz.Visible= false;
                    Naglowek.Visible = true;
                    Naglowek.Text = "                  Twój wynik to " + wynik +" punktów" ;
                    Koniec.Visible = true;
                    PrzyciskStart.Visible = Enabled;
                    timeLeft = 120;
                }
            }
        }

        private void Koniec_Click(object sender, EventArgs e)
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                this.Close();
            }
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
