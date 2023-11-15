namespace Space_Invaders.Forms
{
    partial class PlayerLostForm
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
            this.playerLostLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerLostLabel
            // 
            this.playerLostLabel.AutoSize = true;
            this.playerLostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerLostLabel.ForeColor = System.Drawing.Color.Red;
            this.playerLostLabel.Location = new System.Drawing.Point(170, 42);
            this.playerLostLabel.Name = "playerLostLabel";
            this.playerLostLabel.Size = new System.Drawing.Size(449, 108);
            this.playerLostLabel.TabIndex = 0;
            this.playerLostLabel.Text = "You Lost!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(12, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.scoreText.Location = new System.Drawing.Point(226, 392);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(39, 42);
            this.scoreText.TabIndex = 2;
            this.scoreText.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.restartButtonClick);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(713, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(75, 23);
            this.menuButton.TabIndex = 4;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // PlayerLostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerLostLabel);
            this.Name = "PlayerLostForm";
            this.Text = "PlayerLostForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLostLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button menuButton;
    }
}