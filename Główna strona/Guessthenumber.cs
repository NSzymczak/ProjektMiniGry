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
    public partial class Guessthenumber : Form
    {
        public Guessthenumber()
        {
            InitializeComponent();
            
        }
        bool odp1, odp2, odp3, odp4, odp5;

        private void Form1_Load(object sender, EventArgs e) //widoczność przycisków na poczatku
        {   
            Pytanie.Visible = false;
            przyciskTAK.Visible = false;
            przyciskNIE.Visible = false;
            Nrpytania.Visible = false;
           
        }

        private void PrzyciskStart_Click(object sender, EventArgs e) //początek
        {
            Nrpytania.Text = "1";
            Pytanie.Text = "Czy twoja liczba jest liczbą pierwszą?";
            Liczba.Visible = false;
            label1.Visible = false;
            Pytanie.Visible = true;
            PrzyciskStart.Visible = false;
            przyciskTAK.Visible = true;
            przyciskNIE.Visible = true;
            Nrpytania.Visible = true;
            wyjscie.Visible = false;
        }

        private void zmiananumerupytania()
        {
            if (Nrpytania.Text == "1") Nrpytania.Text = "2";
            else if (Nrpytania.Text == "2") Nrpytania.Text = "3";
            else if (Nrpytania.Text == "3") Nrpytania.Text = "4";
            else if (Nrpytania.Text == "4") Nrpytania.Text = "5";
        }
        
        private void przyciskTAK_Click(object sender, EventArgs e)
        {
            odpowiedznaTak();
            zmiananumerupytania();
        }

        private void przyciskNIE_Click(object sender, EventArgs e)
        {
            odpowiedznaNie();
            zmiananumerupytania();

        }

        private void odpowiedznaTak() //zapis odpowiedzi i zmiana pytania po kliknięci TAK
        {
            if (Nrpytania.Text == "1")
            {
                odp1 = true;
                Pytanie.Text = "Czy twoja liczba jest parzysta?";
            }
            else if (Nrpytania.Text == "2")
            {
                odp2 = true;
                Pytanie.Text = "Czy twoja liczba jest podzielna przez 3?";
            }
            else if (Nrpytania.Text == "3")
            {
                odp3 = true;
                Pytanie.Text = "Czy twoja liczba jest wieksza od 5?";
            }
            else if (Nrpytania.Text == "4")
            {
                odp4 = true;
                Pytanie.Text = "Czy twoja liczba jest podzielna przez 5?";
            }
            else if (Nrpytania.Text == "5")
            {
                odp5 = true;
                Odpowiedz();
            }
        }

        private void odpowiedznaNie() //zapis odpowiedzi i zmiana pytania po kliknięci NIE
        {
            if (Nrpytania.Text == "1")
            {
                odp1 = false;
                Pytanie.Text = "Czy twoja liczba jest parzysta?";
            }
            else if (Nrpytania.Text == "2")
            {
                odp2 = false;
                Pytanie.Text = "Czy twoja liczba jest podzielna przez 3?";
            }
            else if (Nrpytania.Text == "3")
            {
                odp3 = false;
                Pytanie.Text = "Czy twoja liczba jest wieksza od 5?";
            }
            else if (Nrpytania.Text == "4")
            {
                odp4 = false;
                Pytanie.Text = "Czy twoja liczba jest podzielna przez 5?";
            }
            else if (Nrpytania.Text == "5")
            {
                odp5 = false;
                Odpowiedz();
            }
        }
        
        private void Odpowiedz() //Sprawdzenie co to za liczba
        {
            Nrpytania.Visible = false;
            przyciskNIE.Visible = false;
            przyciskTAK.Visible = false;
            Liczba.Visible = true;
            Pytanie.Text = "Twoja liczba to ";
            if (odp1 == false && odp2 == false && odp3 == false && odp4 == false && odp5 == false) Liczba.Text = "1";
            else if (odp1 == true && odp2 == true && odp3 == false && odp4 == false && odp5 == false) Liczba.Text = "2";
            else if (odp1 == true && odp2 == false && odp3 == true && odp4 == false && odp5 == false) Liczba.Text = "3";
            else if (odp1 == false && odp2 == true && odp3 == false && odp4 == false && odp5 == false) Liczba.Text = "4";
            else if (odp1 == true && odp2 == false && odp3 == false && odp4 == false && odp5 == true) Liczba.Text = "5";
            else if (odp1 == false && odp2 == true && odp3 == true && odp4 == true && odp5 == false) Liczba.Text = "6";
            else if (odp1 == true && odp2 == false && odp3 == false && odp4 == true && odp5 == false) Liczba.Text = "7";
            else if (odp1 == false && odp2 == true && odp3 == false && odp4 == true && odp5 == false) Liczba.Text = "8";
            else if (odp1 == false && odp2 == false && odp3 == true && odp4 == true && odp5 == false) Liczba.Text = "9";
            else if (odp1 == false && odp2 == true && odp3 == false && odp4 == true && odp5 == true) Liczba.Text = "10";
            else
            {
                Liczba.Visible = false;
                Pytanie.Text = "Czy napewno pamiętasz swoją liczbę?";
            }
            PrzyciskStart.Text = "Zagraj jeszcze raz";
            PrzyciskStart.Visible = true;
            wyjscie.Visible = true;

        }
        
        private void wyjscie_Click(object sender, EventArgs e)
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
