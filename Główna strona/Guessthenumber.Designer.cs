
namespace Główna_strona
{
    partial class Guessthenumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guessthenumber));
            this.label1 = new System.Windows.Forms.Label();
            this.PrzyciskStart = new System.Windows.Forms.Button();
            this.przyciskTAK = new System.Windows.Forms.Button();
            this.przyciskNIE = new System.Windows.Forms.Button();
            this.Nrpytania = new System.Windows.Forms.Label();
            this.Pytanie = new System.Windows.Forms.Label();
            this.Liczba = new System.Windows.Forms.Label();
            this.wyjscie = new System.Windows.Forms.Button();
            this.CloseGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseGame)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(121, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomyśl o liczbie całkowitej z przedziału od 1 do 10";
            // 
            // PrzyciskStart
            // 
            this.PrzyciskStart.BackColor = System.Drawing.SystemColors.Control;
            this.PrzyciskStart.Location = new System.Drawing.Point(296, 245);
            this.PrzyciskStart.Name = "PrzyciskStart";
            this.PrzyciskStart.Size = new System.Drawing.Size(135, 44);
            this.PrzyciskStart.TabIndex = 5;
            this.PrzyciskStart.Text = "Start";
            this.PrzyciskStart.UseVisualStyleBackColor = false;
            this.PrzyciskStart.Click += new System.EventHandler(this.PrzyciskStart_Click);
            // 
            // przyciskTAK
            // 
            this.przyciskTAK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.przyciskTAK.Location = new System.Drawing.Point(148, 245);
            this.przyciskTAK.Name = "przyciskTAK";
            this.przyciskTAK.Size = new System.Drawing.Size(142, 44);
            this.przyciskTAK.TabIndex = 6;
            this.przyciskTAK.Text = "Tak";
            this.przyciskTAK.UseVisualStyleBackColor = false;
            this.przyciskTAK.Click += new System.EventHandler(this.przyciskTAK_Click);
            // 
            // przyciskNIE
            // 
            this.przyciskNIE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.przyciskNIE.Location = new System.Drawing.Point(442, 245);
            this.przyciskNIE.Name = "przyciskNIE";
            this.przyciskNIE.Size = new System.Drawing.Size(149, 44);
            this.przyciskNIE.TabIndex = 7;
            this.przyciskNIE.Text = "Nie";
            this.przyciskNIE.UseVisualStyleBackColor = false;
            this.przyciskNIE.Click += new System.EventHandler(this.przyciskNIE_Click);
            // 
            // Nrpytania
            // 
            this.Nrpytania.AutoSize = true;
            this.Nrpytania.BackColor = System.Drawing.Color.Transparent;
            this.Nrpytania.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nrpytania.Location = new System.Drawing.Point(154, 165);
            this.Nrpytania.Name = "Nrpytania";
            this.Nrpytania.Size = new System.Drawing.Size(27, 34);
            this.Nrpytania.TabIndex = 8;
            this.Nrpytania.Text = "1";
            // 
            // Pytanie
            // 
            this.Pytanie.AutoSize = true;
            this.Pytanie.BackColor = System.Drawing.Color.Transparent;
            this.Pytanie.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pytanie.Location = new System.Drawing.Point(197, 165);
            this.Pytanie.Name = "Pytanie";
            this.Pytanie.Size = new System.Drawing.Size(394, 34);
            this.Pytanie.TabIndex = 11;
            this.Pytanie.Text = "Czy twoja liczba jest liczbą pierwszą?";
            // 
            // Liczba
            // 
            this.Liczba.AutoSize = true;
            this.Liczba.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Liczba.Location = new System.Drawing.Point(680, 165);
            this.Liczba.Name = "Liczba";
            this.Liczba.Size = new System.Drawing.Size(0, 34);
            this.Liczba.TabIndex = 12;
            // 
            // wyjscie
            // 
            this.wyjscie.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wyjscie.BackColor = System.Drawing.SystemColors.Control;
            this.wyjscie.Location = new System.Drawing.Point(297, 298);
            this.wyjscie.Name = "wyjscie";
            this.wyjscie.Size = new System.Drawing.Size(134, 42);
            this.wyjscie.TabIndex = 13;
            this.wyjscie.Text = "Wyjście";
            this.wyjscie.UseVisualStyleBackColor = false;
            this.wyjscie.Click += new System.EventHandler(this.wyjscie_Click);
            // 
            // CloseGame
            // 
            this.CloseGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseGame.BackgroundImage")));
            this.CloseGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseGame.Location = new System.Drawing.Point(755, 1);
            this.CloseGame.Name = "CloseGame";
            this.CloseGame.Size = new System.Drawing.Size(27, 25);
            this.CloseGame.TabIndex = 14;
            this.CloseGame.TabStop = false;
            this.CloseGame.Click += new System.EventHandler(this.CloseGame_Click);
            // 
            // Guessthenumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.CloseGame);
            this.Controls.Add(this.wyjscie);
            this.Controls.Add(this.Liczba);
            this.Controls.Add(this.Pytanie);
            this.Controls.Add(this.Nrpytania);
            this.Controls.Add(this.przyciskNIE);
            this.Controls.Add(this.przyciskTAK);
            this.Controls.Add(this.PrzyciskStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guessthenumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomyśl o liczbie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CloseGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrzyciskStart;
        private System.Windows.Forms.Button przyciskTAK;
        private System.Windows.Forms.Button przyciskNIE;
        private System.Windows.Forms.Label Nrpytania;
        private System.Windows.Forms.Label Pytanie;
        private System.Windows.Forms.Label Liczba;
        private System.Windows.Forms.Button wyjscie;
        private System.Windows.Forms.PictureBox CloseGame;
    }
}