using Space_Invaders.Entities.Enums;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders.Forms
{
    public partial class PlayerLostForm : Form
    {
        private readonly Difficulty _difficulty;
        public PlayerLostForm(Difficulty difficulty, string score)
        {
            _difficulty = difficulty;
            InitializeComponent();
            scoreText.Text = score;
        }

        private async void restartButtonClick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            await Task.Run(() =>
            {
                Application.Run(new Game(_difficulty));
            });
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            GC.Collect();
            await Task.Run(() =>
            {
                Application.Run(new MenuForm());
            });
        }
    }
}
