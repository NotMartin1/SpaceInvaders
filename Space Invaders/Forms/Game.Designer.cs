using Space_Invaders.Entities;

namespace Space_Invaders
{
    partial class Game
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.playerPicutreBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.barrier1 = new System.Windows.Forms.PictureBox();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.barrier3 = new System.Windows.Forms.PictureBox();
            this.barrier4 = new System.Windows.Forms.PictureBox();
            this.health_label = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicutreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPicutreBox
            // 
            this.playerPicutreBox.AccessibleName = "playerPicutreBox";
            this.playerPicutreBox.BackColor = System.Drawing.Color.Transparent;
            this.playerPicutreBox.Image = global::Space_Invaders.Properties.Resources.space;
            this.playerPicutreBox.InitialImage = global::Space_Invaders.Properties.Resources.space;
            this.playerPicutreBox.Location = new System.Drawing.Point(425, 750);
            this.playerPicutreBox.Name = "playerPicutreBox";
            this.playerPicutreBox.Size = new System.Drawing.Size(51, 50);
            this.playerPicutreBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPicutreBox.TabIndex = 0;
            this.playerPicutreBox.TabStop = false;
            this.playerPicutreBox.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(1, 863);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 10);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "playerPicutreBox";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Space_Invaders.Properties.Resources.health;
            this.pictureBox1.InitialImage = global::Space_Invaders.Properties.Resources.health;
            this.pictureBox1.Location = new System.Drawing.Point(12, 888);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.AccessibleName = "bullet";
            this.bullet.Location = new System.Drawing.Point(442, 664);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(100, 50);
            this.bullet.TabIndex = 5;
            this.bullet.TabStop = false;
            this.bullet.Visible = false;
            // 
            // barrier1
            // 
            this.barrier1.BackColor = System.Drawing.Color.Transparent;
            this.barrier1.Image = global::Space_Invaders.Properties.Resources.barrier1;
            this.barrier1.Location = new System.Drawing.Point(17, 631);
            this.barrier1.Name = "barrier1";
            this.barrier1.Size = new System.Drawing.Size(95, 70);
            this.barrier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier1.TabIndex = 6;
            this.barrier1.TabStop = false;
            // 
            // barrier2
            // 
            this.barrier2.BackColor = System.Drawing.Color.Transparent;
            this.barrier2.Image = global::Space_Invaders.Properties.Resources.barrier1;
            this.barrier2.Location = new System.Drawing.Point(264, 631);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(95, 70);
            this.barrier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier2.TabIndex = 7;
            this.barrier2.TabStop = false;
            // 
            // barrier3
            // 
            this.barrier3.BackColor = System.Drawing.Color.Transparent;
            this.barrier3.Image = global::Space_Invaders.Properties.Resources.barrier1;
            this.barrier3.Location = new System.Drawing.Point(548, 631);
            this.barrier3.Name = "barrier3";
            this.barrier3.Size = new System.Drawing.Size(95, 70);
            this.barrier3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier3.TabIndex = 8;
            this.barrier3.TabStop = false;
            // 
            // barrier4
            // 
            this.barrier4.BackColor = System.Drawing.Color.Transparent;
            this.barrier4.Image = global::Space_Invaders.Properties.Resources.barrier1;
            this.barrier4.Location = new System.Drawing.Point(745, 631);
            this.barrier4.Name = "barrier4";
            this.barrier4.Size = new System.Drawing.Size(95, 70);
            this.barrier4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier4.TabIndex = 9;
            this.barrier4.TabStop = false;
            // 
            // health_label
            // 
            this.health_label.AutoSize = true;
            this.health_label.BackColor = System.Drawing.Color.Transparent;
            this.health_label.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health_label.ForeColor = System.Drawing.SystemColors.Control;
            this.health_label.Location = new System.Drawing.Point(65, 888);
            this.health_label.Name = "health_label";
            this.health_label.Size = new System.Drawing.Size(162, 63);
            this.health_label.TabIndex = 10;
            this.health_label.Text = "HELATH";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.creditsLabel.Location = new System.Drawing.Point(434, 888);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(142, 63);
            this.creditsLabel.TabIndex = 11;
            this.creditsLabel.Text = "SCORE:";
            this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.credits.ForeColor = System.Drawing.SystemColors.Control;
            this.credits.Location = new System.Drawing.Point(582, 910);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(18, 20);
            this.credits.TabIndex = 12;
            this.credits.Text = "0";
            this.credits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(852, 950);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.health_label);
            this.Controls.Add(this.barrier4);
            this.Controls.Add(this.barrier3);
            this.Controls.Add(this.barrier2);
            this.Controls.Add(this.barrier1);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerPicutreBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Shown += new System.EventHandler(this.Game_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.playerPicutreBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public System.Windows.Forms.PictureBox playerPicutreBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox bullet;
        public System.Windows.Forms.PictureBox barrier1;
        public System.Windows.Forms.PictureBox barrier2;
        public System.Windows.Forms.PictureBox barrier3;
        public System.Windows.Forms.PictureBox barrier4;
        private System.Windows.Forms.Label health_label;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label credits;
    }
}

