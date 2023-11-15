using System;
using System.Windows.Forms;

namespace Space_Invaders.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private  void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var difficultySelectionForm = new DifficultySelectionForm();
            difficultySelectionForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
