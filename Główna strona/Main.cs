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
    public partial class glownyprogram : Form
    {
        public glownyprogram()
        {
            InitializeComponent();
            kolkokrzyzyk.Visible = false;
            pomysloliczbie.Visible = false;
            ClickGame.Visible = false;
            Hell.Visible = false;
            Galaxy.Visible = false;
            Breakout.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e) //pokazuje date i godzine
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)//odlicza czas od czasu uruchomienia programu 
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text;
            label1.Text ="Witaj, "+ imie;
            label4.Visible = false;
            button1.Visible = false;
            textBox1.Visible = false;
            kolkokrzyzyk.Visible = true;
            pomysloliczbie.Visible = true;
            ClickGame.Visible = true;
            Hell.Visible = true;
            Galaxy.Visible = true;
            Breakout.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e) //Napis witaj osobo
        {

        }

        private void kolkokrzyzyk_Click(object sender, EventArgs e) 
        {
            ((Button)sender).BackColor = Color.Gray; //zmiana koloru na szary 
            var m = new CrossandCircle(); 
            m.Show();                               //otwiera nowe okienko z gra
        }

        private void pomysloliczbie_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gray; 
            var m = new Guessthenumber();
            m.Show();
        }

        private void ClickGame_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gray;
            var m = new ClickGame();
            m.Show();
        }

        private void Galaxy_Click(object sender, EventArgs e)
        {
            
            ((Button)sender).BackColor = Color.Gray;
            var m = new Galaxy();
            m.Show(); 
        }

        private void Hell_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gray;
            var m = new Hell();
            m.Show();
        }
       
        private void Breakout_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gray;
            var m = new Breakout();
            m.Show();
        }
        private void Close_Click(object sender, EventArgs e) //przycisk wyjscia
        {
            DialogResult odp = MessageBox.Show("Czy na pewno chcesz wyjść z programu?", "Uwaga!", MessageBoxButtons.YesNo);
            if (odp == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
