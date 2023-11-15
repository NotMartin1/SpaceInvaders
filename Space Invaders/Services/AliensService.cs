using Space_Invaders.Entities;
using Space_Invaders.Entities.Constants;
using Space_Invaders.Entities.Enums;
using Space_Invaders.Entities.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders.Services
{
    public class AliensService : GameEntity, IAliensService
    {
        private List<PictureBox> Aliens = new List<PictureBox>();
        private readonly Game _mainGameForm;
        private AlienSettings settings;
        private int aliensLeft;
        private PictureBox lastHittedAlien;

        public AliensService(Game mainGameForm, Difficulty difficulty)
        {
            _mainGameForm = mainGameForm;
            settings = new AlienSettings(difficulty);
        }

        public void SummonAliens()
        {
            var alienPoint = new Point(AlienConstants.DISTANCE_BETWEEN_ALIENS, AlienConstants.TOP_CORNER_PADDING);

            Aliens = new List<PictureBox>();

            for (var row = 0; row < AlienConstants.ROWS; row++)
            {
                for (var column = 0; column < AlienConstants.COLUMNS; column++)
                {
                    var alien = Alien.GetAlienPictureBox(row, column, alienPoint);
                    _mainGameForm.Controls.Add(alien);
                    Aliens.Add(alien);
                    alienPoint.X += AlienConstants.DISTANCE_BETWEEN_ALIENS;
                }
                alienPoint.Y += AlienConstants.DISTANCE_BETWEEN_ALIENS;
                alienPoint.X = AlienConstants.DISTANCE_BETWEEN_ALIENS;
            }
            aliensLeft = Aliens.Count;
        }

        public async Task<bool> AliensMovement()
        {
            while (Aliens.Count > 0)
            {
                if (Aliens.Any(x => x.Location.Y >= AlienConstants.MAX_POSITION_Y))
                    _mainGameForm.PlayerLost();

                if (GamePauseService.IsGamePaused() || _mainGameForm.IsGameEnded())
                    continue;

                PerfomShooting();

                if (settings.MovementDirection == Direction.Right)
                    await MoveAliensRight();
                else if (settings.MovementDirection == Direction.Left)
                    await MoveAliensLeft();

                if (Aliens.Any(x => x.Location.X == 0) || Aliens.Any(x => x.Location.X >= _mainGameForm.Size.Width - x.Width))
                {
                    MoveAliensDown();
                    settings.MovementDirection = settings.MovementDirection == Direction.Left ? Direction.Right : Direction.Left;
                }
            }

            return true;
        }

        private async Task MoveAliensLeft()
        {
            for (var row = 0; row < AlienConstants.ROWS; row++)
            {
                for (var columnn = 0; columnn < AlienConstants.COLUMNS; columnn++)
                    MoveAlienHorizontally(row, columnn, Direction.Left);

                await Task.Delay(250);
            }
        }

        private async Task MoveAliensRight()
        {
            for (var row = 0; row < AlienConstants.ROWS; row++)
            {
                for (var columnn = AlienConstants.COLUMNS - 1; columnn >= 0; columnn--)
                    MoveAlienHorizontally(row, columnn, Direction.Right);

                await Task.Delay(250);
            }
        }

        private void MoveAliensDown()
        {
            foreach (var alien in Aliens.Where(a => a.Visible).OrderByDescending(a => a.Name))
            {
                var newLocation = new Point(alien.Location.X, alien.Location.Y + settings.CurrentStepSize);
                alien.Location = newLocation;
            }
        }

        private void MoveAlienHorizontally(int row, int column, Direction direction)
        {
            var alien = Aliens.FirstOrDefault(x => x.Name == $"{row} {column}");
            if (alien == null || !alien.Visible)
                return;

            var step = direction == Direction.Left ? settings.CurrentStepSize * -1 : settings.CurrentStepSize;

            var newLocation = new Point(alien.Location.X + step, alien.Location.Y);
            if (newLocation.X < 0)
                newLocation.X = 0;
            if (newLocation.X > _mainGameForm.Size.Width - alien.Width)
                newLocation.X = _mainGameForm.Width - alien.Width;

            alien.Location = newLocation;

        }

        private async Task PerfomShooting()
        {
            var availabeAliensToShoot = await AliensAvailabeToShoot();
            if (availabeAliensToShoot == null || availabeAliensToShoot.Count == 0)
                return;

            var randomAliens = availabeAliensToShoot.OrderBy(args => Guid.NewGuid()).Take(settings.ShootingAliens).ToList();

            foreach (var alien in randomAliens)
                if (await Shoot(alien) || _mainGameForm.IsGameEnded())
                    return;
        }

        private async Task<List<PictureBox>> AliensAvailabeToShoot()
        {
            var columns = Aliens.Select(x => x.Location.X).Distinct().ToList();
            var nearestAliens = new List<PictureBox>();

            foreach (var column in columns)
            {
                var nearestAlien = Aliens.Where(x => x.Location.X == column && x.Visible && x.Location != null)
                                         .OrderByDescending(x => x.Location.Y)
                                         .FirstOrDefault();

                if (nearestAlien != null)
                    nearestAliens.Add(nearestAlien);
            }

            if (nearestAliens.Count == 0)
                return null;

            return nearestAliens;
        }

        private async Task<bool> Shoot(PictureBox alien)
        {
            var bullet = Bullet.GetBulletPictureBox(alien.Location.X, alien.Location.Y, alien.Width);

            _mainGameForm.Controls.Add(bullet);

            while (bullet.Location.Y <= _mainGameForm.Height)
            {
                if (_mainGameForm.IsGameEnded())
                    return false;

                bullet.Location = new Point(bullet.Location.X, bullet.Location.Y + settings.BulletSpeed);
                if (_mainGameForm.CheckForBulletCollision(bullet, EntityType.Player))
                {
                    bullet.Dispose();
                    return true;
                }

                await Task.Delay(10);
            }

            bullet.Dispose();
            return false;
        }

        public override bool CheckForColission(PictureBox bullet, EntityType target)
        {
            if (target != EntityType.Alien)
                return false;

            var hittedAlien = Aliens.FirstOrDefault(x => x.Visible && x.Bounds.IntersectsWith(bullet.Bounds));
            if (hittedAlien == null)
                return false;

            lastHittedAlien = hittedAlien;

            OnHitted();

            return true;
        }

        public override void OnHitted()
        {
            lastHittedAlien.Visible = false;
            aliensLeft--;

            if (aliensLeft != AlienConstants.ROWS * AlienConstants.COLUMNS && aliensLeft % AlienConstants.COLUMNS == 0)
                settings.CurrentStepSize += settings.StepSize;
        }
    }
}