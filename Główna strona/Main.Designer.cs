namespace Główna_strona
{
    partial class glownyprogram
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glownyprogram));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kolkokrzyzyk = new System.Windows.Forms.Button();
            this.pomysloliczbie = new System.Windows.Forms.Button();
            this.ClickGame = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Galaxy = new System.Windows.Forms.Button();
            this.Hell = new System.Windows.Forms.Button();
            this.Breakout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kolkokrzyzyk
            // 
            this.kolkokrzyzyk.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.kolkokrzyzyk, "kolkokrzyzyk");
            this.kolkokrzyzyk.Name = "kolkokrzyzyk";
            this.kolkokrzyzyk.UseVisualStyleBackColor = false;
            this.kolkokrzyzyk.Click += new System.EventHandler(this.kolkokrzyzyk_Click);
            // 
            // pomysloliczbie
            // 
            this.pomysloliczbie.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.pomysloliczbie, "pomysloliczbie");
            this.pomysloliczbie.Name = "pomysloliczbie";
            this.pomysloliczbie.UseVisualStyleBackColor = false;
            this.pomysloliczbie.Click += new System.EventHandler(this.pomysloliczbie_Click);
            // 
            // ClickGame
            // 
            this.ClickGame.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.ClickGame, "ClickGame");
            this.ClickGame.Name = "ClickGame";
            this.ClickGame.UseVisualStyleBackColor = false;
            this.ClickGame.Click += new System.EventHandler(this.ClickGame_Click);
            // 
            // Close
            // 
            resources.ApplyResources(this.Close, "Close");
            this.Close.Name = "Close";
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Galaxy
            // 
            this.Galaxy.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Galaxy, "Galaxy");
            this.Galaxy.Name = "Galaxy";
            this.Galaxy.UseVisualStyleBackColor = false;
            this.Galaxy.Click += new System.EventHandler(this.Galaxy_Click);
            // 
            // Hell
            // 
            this.Hell.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.Hell, "Hell");
            this.Hell.Name = "Hell";
            this.Hell.UseVisualStyleBackColor = false;
            this.Hell.Click += new System.EventHandler(this.Hell_Click);
            // 
            // Breakout
            // 
            resources.ApplyResources(this.Breakout, "Breakout");
            this.Breakout.Name = "Breakout";
            this.Breakout.UseVisualStyleBackColor = true;
            this.Breakout.Click += new System.EventHandler(this.Breakout_Click);
            // 
            // glownyprogram
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Breakout);
            this.Controls.Add(this.Hell);
            this.Controls.Add(this.Galaxy);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ClickGame);
            this.Controls.Add(this.pomysloliczbie);
            this.Controls.Add(this.kolkokrzyzyk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "glownyprogram";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kolkokrzyzyk;
        private System.Windows.Forms.Button pomysloliczbie;
        private System.Windows.Forms.Button ClickGame;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Button Galaxy;
        private System.Windows.Forms.Button Hell;
        private System.Windows.Forms.Button Breakout;
    }
}

