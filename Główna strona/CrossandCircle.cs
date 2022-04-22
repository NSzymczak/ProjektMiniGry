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
    public partial class CrossandCircle : Form
    {
        public CrossandCircle()
        {
            InitializeComponent();
        }
       
        bool graczO = true;
        int ruch = 0;

        private void ButtonClick(object sender) //kliknięcie któregoś z przycisków 
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false; //wyłączamy przycisk
            ButtonColor(sender);
            if (ruch >= 5) //sprawdzamy czy nie doszło do końca gry
            {
                Sprawdz();
            }
            graczO = !graczO;
            Kto.Text = graczO ? "O" : "X";
        }
        private void ButtonColor(object sender) //zmiana koloru przycisku 
        {
            if (graczO)
            {
                ((Button)sender).BackColor = Color.LightBlue;
            }
            else
            {
                ((Button)sender).BackColor = Color.LightGreen;
            }

        } 
        private void B1_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B4_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B5_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B6_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B7_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B8_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void B9_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void Sprawdz() //warunki wygranej bądź remisu
        {
            if (B1.Text != "" && B1.Text == B2.Text && B3.Text == B2.Text)
            {
                Wygrana();
            }
            else if (B4.Text != "" && B4.Text == B5.Text && B5.Text == B6.Text)
            {
                Wygrana();
            }
            else if (B7.Text != "" && B7.Text == B8.Text && B8.Text == B9.Text)
            {
                Wygrana();
            }
            else if (B1.Text != "" && B4.Text == B1.Text && B4.Text == B7.Text)
            {
                Wygrana();
            }
            else if (B2.Text != "" && B2.Text == B5.Text && B5.Text == B8.Text)
            {
                Wygrana();
            }
            else if (B3.Text != "" && B3.Text == B6.Text && B6.Text == B9.Text)
            {
                Wygrana();
            }
            else if (B1.Text != "" && B1.Text == B5.Text && B5.Text == B9.Text)
            {
                Wygrana();
            }
            else if (B3.Text != "" && B3.Text == B5.Text && B5.Text == B7.Text)
            {
                Wygrana();
            }
            else if (ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }

        private void nowagra_Click(object sender, EventArgs e) //przycisk nowa gra
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz rozpocząć grę od nowa?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.No)
            {
                return;
            }
            Restartuj();
            WynikO.Text = "0";
            WynikX.Text = "0";
            Kto.Text = "O";
            graczO = true;
        }

        private void Restartuj() //reset przycisków 
        {
            ruch = 0;
            foreach (Control button in this.Controls)
            {
                if (button is Button && Convert.ToString(button.Tag) == "button")
                {
                    button.Enabled = true; //włączenie przycisków 
                    button.BackColor = Color.White;  //zmiana koloru na biały
                    button.Text = ""; //ustawienie w nich pustego napisu
                }
            }
        }

        private void Wygrana() //komunikat o wygranej + dopisanie pounktów i rozpoczęcie nowej tury
        {
            MessageBox.Show("Wygrywa Gracz " + (graczO ? "O" : "X"), "Koniec Gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (graczO)
            {
                WynikO.Text = ((Convert.ToInt32(WynikO.Text)) + 1).ToString();
            }
            else
            {
                WynikX.Text = ((Convert.ToInt32(WynikO.Text)) + 1).ToString();
            }
            Restartuj();
        }

        private void wyjście_Click(object sender, EventArgs e)
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z gry?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void kolkokrzyzyk_Load(object sender, EventArgs e)
        {

        }

       
    }
}
