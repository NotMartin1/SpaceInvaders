using Space_Invaders.Entities.Constants;
using Space_Invaders.Entities.Enums;
using Space_Invaders.Forms;
using Space_Invaders.Services;
using System;
using System.Windows.Forms;

namespace Space_Invaders
{
    public partial class Game : Form
    {
        private readonly IPlayerService _playerService;
        private readonly IAliensService _aliensService;
        private readonly IBarrierService _barrierService;
        private readonly Difficulty _difficulty;
        private int playerCredits = 0;
        private bool gameEnded = false;

        public Game(Difficulty difficulty)
        {
            InitializeComponent();

            _difficulty = difficulty;
            _aliensService = new AliensService(this, _difficulty);
            _playerService = new PlayerService(this, _difficulty);
            _barrierService = new BarrierService(this, _difficulty);
            _aliensService.SummonAliens();

            health_label.Text = _playerService.GetPlayerHealth().ToString();
        }

        private async void Game_KeyDown(object sender, KeyEventArgs keyButton)
        {
            if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.Left))
                await _playerService.PlayerMove(Direction.Left);
            else if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.Right))
                await _playerService.PlayerMove(Direction.Right);
        }

        private async void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                await _playerService.Shoot();
        }

        private async void Game_Shown(object sender, EventArgs e)
        {
            while (!gameEnded)
            {
                _barrierService.InitializeBarriers();
                await _aliensService.AliensMovement();
                GamePauseService.Pause();
                _aliensService.SummonAliens();
                GamePauseService.UnPause();
            }
        }

        public void IncreaseCredits()
        {
            playerCredits += GameConstants.CREDITS_INCREASE_VALUE;
            credits.Text = playerCredits.ToString();
        }

        public void UpdatePlayerHealth()
        {
            var health = _playerService.GetPlayerHealth();
            if (health == 0)
                PlayerLost();
            else
                health_label.Text = health.ToString();
        }

        public void PlayerLost()
        {
            gameEnded = true;

            var playerLostForm = new PlayerLostForm(_difficulty, credits.Text);
            playerLostForm.Show();

            Hide();
            GC.Collect();
        }

        public bool CheckForBulletCollision(PictureBox bullet, EntityType shooter)
        {
            var isHitted = _playerService.CheckForColission(bullet, shooter) ||
                           _aliensService.CheckForColission(bullet, shooter) ||
                           _barrierService.CheckForColission(bullet, shooter);
            
            return isHitted;
        }

        public bool IsGameEnded() => gameEnded;

    }
}
