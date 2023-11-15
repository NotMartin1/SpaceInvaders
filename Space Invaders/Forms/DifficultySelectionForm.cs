using Space_Invaders.Entities.Enums;
using System;
using System.Windows.Forms;

namespace Space_Invaders.Forms
{
    public partial class DifficultySelectionForm : Form
    {
        public DifficultySelectionForm()
        {
            InitializeComponent();
        }

        private void easyButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var gameForm = new Game(Difficulty.Easy);
            gameForm.Show();
        }

        private void mediumButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var gameForm = new Game(Difficulty.Medium);
            gameForm.Show();
        }

        private void hardButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            var gameForm = new Game(Difficulty.Hard);
            gameForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
