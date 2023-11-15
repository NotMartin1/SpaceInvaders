using Space_Invaders.Entities;
using Space_Invaders.Entities.Constants;
using Space_Invaders.Entities.Enums;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders.Services
{
    public class PlayerService : GameEntity, IPlayerService
    {
        private Game _mainGameForm;
        private Player player;

        public PlayerService(Game mainGameForm, Difficulty difficulty)
        {
            var playerSettings = new PlayerSettings(difficulty);

            player = new Player
            {
                Health = playerSettings.Health,
                Settings = playerSettings,
            };

            _mainGameForm = mainGameForm;
        }

        public async Task PlayerMove(Direction moveDirection)
        {
            var currentPlayerLocation = _mainGameForm.playerPicutreBox.Location;

            switch (moveDirection)
            {
                case Direction.Left when currentPlayerLocation.X > 0:
                    MovePlayer(moveDirection);
                    break;
                case Direction.Right when currentPlayerLocation.X < _mainGameForm.Size.Width - _mainGameForm.playerPicutreBox.Width:
                    MovePlayer(moveDirection);
                    break;
            }
        }

        void MovePlayer(Direction direction)
        {
            var multiplier = 1;
            if (direction == Direction.Left)
                multiplier = -1;

            var speed = new Random().Next(PlayerConstants.MOVING_SPEED_MIN, PlayerConstants.MOVING_SPEED_MAX);

            var currentPlayerLocation = _mainGameForm.playerPicutreBox.Location;
            currentPlayerLocation.X += multiplier * Math.Max(speed, currentPlayerLocation.X > PlayerConstants.MOVING_SPEED_MIN ? speed : currentPlayerLocation.X);
            currentPlayerLocation.X = Math.Min(currentPlayerLocation.X, _mainGameForm.Size.Width + _mainGameForm.playerPicutreBox.Width);
            _mainGameForm.playerPicutreBox.Location = currentPlayerLocation;
        }

        public async Task Shoot()
        {
            var playerPictureBox = _mainGameForm.playerPicutreBox;

            if (_mainGameForm.bullet.Visible)
                return;


            _mainGameForm.bullet = Bullet.GetBulletPictureBox(playerPictureBox.Location.X, playerPictureBox.Location.Y, playerPictureBox.Width);
            _mainGameForm.Controls.Add(_mainGameForm.bullet);

            while (_mainGameForm.bullet.Location.Y >= 0)
            {
                _mainGameForm.bullet.Location = new Point(_mainGameForm.bullet.Location.X, _mainGameForm.bullet.Location.Y - player.Settings.BulletSpeed);

                var barrierHitted = _mainGameForm.CheckForBulletCollision(_mainGameForm.bullet, EntityType.Barrier);
                if (barrierHitted)
                {
                    _mainGameForm.bullet.Visible = false;
                    break;
                }

                if (_mainGameForm.CheckForBulletCollision(_mainGameForm.bullet, EntityType.Alien))
                {
                    _mainGameForm.IncreaseCredits();
                    break;
                }

                await Task.Delay(10);
            }

            _mainGameForm.bullet.Visible = false;
            _mainGameForm.Controls.Remove(_mainGameForm.bullet);
        }

        public int GetPlayerHealth() => player.Health;

        public override bool CheckForColission(PictureBox bullet, EntityType shooter)
        {
            if (!bullet.Bounds.IntersectsWith(_mainGameForm.playerPicutreBox.Bounds))
                return false;
            
            OnHitted();
            return true;
        }

        public override void OnHitted()
        {
            GamePauseService.Pause();

            player.Health--;

            for (int i = 0; i < 6; i++)
            {
                _mainGameForm.playerPicutreBox.Visible = !_mainGameForm.playerPicutreBox.Visible;
                _mainGameForm.Refresh();
                System.Threading.Thread.Sleep(150);
            }

            _mainGameForm.UpdatePlayerHealth();

            GamePauseService.UnPause();
        }
    }
}