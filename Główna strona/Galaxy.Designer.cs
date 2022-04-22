
namespace Główna_strona
{
    partial class Galaxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galaxy));
            this.coin11 = new System.Windows.Forms.PictureBox();
            this.ruchprzeciwników = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.enemy = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.coin7 = new System.Windows.Forms.PictureBox();
            this.coin6 = new System.Windows.Forms.PictureBox();
            this.coin10 = new System.Windows.Forms.PictureBox();
            this.coin9 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin5 = new System.Windows.Forms.PictureBox();
            this.coin8 = new System.Windows.Forms.PictureBox();
            this.Koniec = new System.Windows.Forms.PictureBox();
            this.enemy6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.coin11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // coin11
            // 
            this.coin11.BackColor = System.Drawing.Color.White;
            this.coin11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin11.Location = new System.Drawing.Point(273, 385);
            this.coin11.Name = "coin11";
            this.coin11.Size = new System.Drawing.Size(10, 10);
            this.coin11.TabIndex = 1;
            this.coin11.TabStop = false;
            this.coin11.Tag = "coin";
            // 
            // ruchprzeciwników
            // 
            this.ruchprzeciwników.Interval = 50;
            this.ruchprzeciwników.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.player.Location = new System.Drawing.Point(194, 504);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(18, 19);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // move
            // 
            this.move.Interval = 50;
            this.move.Tick += new System.EventHandler(this.move_Tick);
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy.BackgroundImage")));
            this.enemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy.Location = new System.Drawing.Point(315, 89);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(20, 20);
            this.enemy.TabIndex = 3;
            this.enemy.TabStop = false;
            this.enemy.Tag = "enemy";
            // 
            // enemy4
            // 
            this.enemy4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enemy4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy4.BackgroundImage")));
            this.enemy4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy4.Location = new System.Drawing.Point(57, 162);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(20, 20);
            this.enemy4.TabIndex = 4;
            this.enemy4.TabStop = false;
            this.enemy4.Tag = "enemy";
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enemy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy3.BackgroundImage")));
            this.enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy3.Location = new System.Drawing.Point(263, 236);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(20, 20);
            this.enemy3.TabIndex = 5;
            this.enemy3.TabStop = false;
            this.enemy3.Tag = "enemy";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enemy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy2.BackgroundImage")));
            this.enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy2.Location = new System.Drawing.Point(93, 326);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(20, 20);
            this.enemy2.TabIndex = 6;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enemy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy1.BackgroundImage")));
            this.enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy1.Location = new System.Drawing.Point(273, 402);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(20, 20);
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // coin7
            // 
            this.coin7.BackColor = System.Drawing.Color.White;
            this.coin7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin7.Location = new System.Drawing.Point(299, 263);
            this.coin7.Name = "coin7";
            this.coin7.Size = new System.Drawing.Size(10, 10);
            this.coin7.TabIndex = 8;
            this.coin7.TabStop = false;
            this.coin7.Tag = "coin";
            // 
            // coin6
            // 
            this.coin6.BackColor = System.Drawing.Color.White;
            this.coin6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin6.Location = new System.Drawing.Point(67, 263);
            this.coin6.Name = "coin6";
            this.coin6.Size = new System.Drawing.Size(10, 10);
            this.coin6.TabIndex = 9;
            this.coin6.TabStop = false;
            this.coin6.Tag = "coin";
            // 
            // coin10
            // 
            this.coin10.BackColor = System.Drawing.Color.White;
            this.coin10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin10.Location = new System.Drawing.Point(57, 420);
            this.coin10.Name = "coin10";
            this.coin10.Size = new System.Drawing.Size(10, 10);
            this.coin10.TabIndex = 10;
            this.coin10.TabStop = false;
            this.coin10.Tag = "coin";
            // 
            // coin9
            // 
            this.coin9.BackColor = System.Drawing.Color.White;
            this.coin9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin9.Location = new System.Drawing.Point(382, 326);
            this.coin9.Name = "coin9";
            this.coin9.Size = new System.Drawing.Size(10, 10);
            this.coin9.TabIndex = 11;
            this.coin9.TabStop = false;
            this.coin9.Tag = "coin";
            // 
            // coin3
            // 
            this.coin3.BackColor = System.Drawing.Color.White;
            this.coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin3.Location = new System.Drawing.Point(299, 145);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(10, 10);
            this.coin3.TabIndex = 12;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            // 
            // coin4
            // 
            this.coin4.BackColor = System.Drawing.Color.White;
            this.coin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin4.Location = new System.Drawing.Point(112, 193);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(10, 10);
            this.coin4.TabIndex = 13;
            this.coin4.TabStop = false;
            this.coin4.Tag = "coin";
            // 
            // coin2
            // 
            this.coin2.BackColor = System.Drawing.Color.White;
            this.coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin2.Location = new System.Drawing.Point(382, 89);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(10, 10);
            this.coin2.TabIndex = 14;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.White;
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin1.Location = new System.Drawing.Point(67, 89);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(10, 10);
            this.coin1.TabIndex = 15;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // coin5
            // 
            this.coin5.BackColor = System.Drawing.Color.White;
            this.coin5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin5.Location = new System.Drawing.Point(251, 203);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(10, 10);
            this.coin5.TabIndex = 16;
            this.coin5.TabStop = false;
            this.coin5.Tag = "coin";
            // 
            // coin8
            // 
            this.coin8.BackColor = System.Drawing.Color.White;
            this.coin8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin8.Location = new System.Drawing.Point(137, 319);
            this.coin8.Name = "coin8";
            this.coin8.Size = new System.Drawing.Size(10, 10);
            this.coin8.TabIndex = 17;
            this.coin8.TabStop = false;
            this.coin8.Tag = "coin";
            // 
            // Koniec
            // 
            this.Koniec.BackColor = System.Drawing.Color.Black;
            this.Koniec.Location = new System.Drawing.Point(0, -11);
            this.Koniec.Name = "Koniec";
            this.Koniec.Size = new System.Drawing.Size(438, 42);
            this.Koniec.TabIndex = 20;
            this.Koniec.TabStop = false;
            // 
            // enemy6
            // 
            this.enemy6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.enemy6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enemy6.BackgroundImage")));
            this.enemy6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enemy6.Location = new System.Drawing.Point(174, 58);
            this.enemy6.Name = "enemy6";
            this.enemy6.Size = new System.Drawing.Size(20, 20);
            this.enemy6.TabIndex = 21;
            this.enemy6.TabStop = false;
            this.enemy6.Tag = "enemy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(407, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-17, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 574);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Galaxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(432, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemy6);
            this.Controls.Add(this.coin8);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin9);
            this.Controls.Add(this.coin10);
            this.Controls.Add(this.coin6);
            this.Controls.Add(this.coin7);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.player);
            this.Controls.Add(this.coin11);
            this.Controls.Add(this.Koniec);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Galaxy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.coin11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox coin11;
        private System.Windows.Forms.Timer ruchprzeciwników;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox coin7;
        private System.Windows.Forms.PictureBox coin6;
        private System.Windows.Forms.PictureBox coin10;
        private System.Windows.Forms.PictureBox coin9;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin5;
        private System.Windows.Forms.PictureBox coin8;
        private System.Windows.Forms.PictureBox Koniec;
        private System.Windows.Forms.PictureBox enemy6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}