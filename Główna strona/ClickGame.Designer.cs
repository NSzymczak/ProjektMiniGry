
namespace Główna_strona
{
    partial class ClickGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClickGame));
            this.Naglowek = new System.Windows.Forms.Label();
            this.PrzyciskStart = new System.Windows.Forms.Button();
            this.Punkty = new System.Windows.Forms.Label();
            this.Wynik = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Czasdokonca = new System.Windows.Forms.Label();
            this.Koniec = new System.Windows.Forms.Button();
            this.CloseGame = new System.Windows.Forms.PictureBox();
            this.Uciekacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGame)).BeginInit();
            this.SuspendLayout();
            // 
            // Naglowek
            // 
            this.Naglowek.AutoSize = true;
            this.Naglowek.BackColor = System.Drawing.Color.Transparent;
            this.Naglowek.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naglowek.Location = new System.Drawing.Point(102, 140);
            this.Naglowek.Name = "Naglowek";
            this.Naglowek.Size = new System.Drawing.Size(536, 34);
            this.Naglowek.TabIndex = 0;
            this.Naglowek.Text = "Gdy zobaczysz punkt kliknij w niego jak najszybciej ";
            // 
            // PrzyciskStart
            // 
            this.PrzyciskStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrzyciskStart.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrzyciskStart.Location = new System.Drawing.Point(307, 205);
            this.PrzyciskStart.Name = "PrzyciskStart";
            this.PrzyciskStart.Size = new System.Drawing.Size(136, 42);
            this.PrzyciskStart.TabIndex = 1;
            this.PrzyciskStart.Text = "Start ";
            this.PrzyciskStart.UseVisualStyleBackColor = false;
            this.PrzyciskStart.Click += new System.EventHandler(this.PrzyciskStart_Click);
            // 
            // Punkty
            // 
            this.Punkty.AutoSize = true;
            this.Punkty.BackColor = System.Drawing.Color.Transparent;
            this.Punkty.Location = new System.Drawing.Point(166, 9);
            this.Punkty.Name = "Punkty";
            this.Punkty.Size = new System.Drawing.Size(55, 17);
            this.Punkty.TabIndex = 3;
            this.Punkty.Text = "Punkty:";
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.BackColor = System.Drawing.Color.Transparent;
            this.Wynik.Location = new System.Drawing.Point(227, 9);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(16, 17);
            this.Wynik.TabIndex = 4;
            this.Wynik.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Czas:";
            // 
            // Czasdokonca
            // 
            this.Czasdokonca.AutoSize = true;
            this.Czasdokonca.Location = new System.Drawing.Point(51, 9);
            this.Czasdokonca.Name = "Czasdokonca";
            this.Czasdokonca.Size = new System.Drawing.Size(0, 17);
            this.Czasdokonca.TabIndex = 6;
            // 
            // Koniec
            // 
            this.Koniec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Koniec.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Koniec.Location = new System.Drawing.Point(307, 253);
            this.Koniec.Name = "Koniec";
            this.Koniec.Size = new System.Drawing.Size(136, 47);
            this.Koniec.TabIndex = 7;
            this.Koniec.Text = "Wyjście z gry";
            this.Koniec.UseVisualStyleBackColor = false;
            this.Koniec.Click += new System.EventHandler(this.Koniec_Click);
            // 
            // CloseGame
            // 
            this.CloseGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseGame.BackgroundImage")));
            this.CloseGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseGame.Location = new System.Drawing.Point(758, -3);
            this.CloseGame.Name = "CloseGame";
            this.CloseGame.Size = new System.Drawing.Size(27, 29);
            this.CloseGame.TabIndex = 81;
            this.CloseGame.TabStop = false;
            this.CloseGame.Click += new System.EventHandler(this.CloseGame_Click);
            // 
            // Uciekacz
            // 
            this.Uciekacz.BackColor = System.Drawing.Color.Crimson;
            this.Uciekacz.ForeColor = System.Drawing.Color.Blue;
            this.Uciekacz.Location = new System.Drawing.Point(200, 308);
            this.Uciekacz.Name = "Uciekacz";
            this.Uciekacz.Size = new System.Drawing.Size(21, 19);
            this.Uciekacz.TabIndex = 83;
            this.Uciekacz.Tag = "Uciekacze";
            this.Uciekacz.Text = "*";
            this.Uciekacz.UseVisualStyleBackColor = false;
            this.Uciekacz.Click += new System.EventHandler(this.Uciekacz_Click_1);
            // 
            // ClickGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Uciekacz);
            this.Controls.Add(this.CloseGame);
            this.Controls.Add(this.Koniec);
            this.Controls.Add(this.Czasdokonca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Punkty);
            this.Controls.Add(this.PrzyciskStart);
            this.Controls.Add(this.Naglowek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClickGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Uciekacze";
            this.Text = "Gra w klikanie";
            ((System.ComponentModel.ISupportInitialize)(this.CloseGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naglowek;
        private System.Windows.Forms.Button PrzyciskStart;
        private System.Windows.Forms.Label Punkty;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Czasdokonca;
        private System.Windows.Forms.Button Koniec;
        private System.Windows.Forms.PictureBox CloseGame;
        private System.Windows.Forms.Button Uciekacz;
    }
}