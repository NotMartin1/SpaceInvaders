using Microsoft.VisualStudio.TestTools.UnitTesting;
using Space_Invaders.Entities.Enums;
using Space_Invaders.Entities;
using Space_Invaders.Services;
using Space_Invaders;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceInvadersTests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void PlayerHealth_DecreasesAfterHit()
        {
            // Arrange
            var difficulty = Difficulty.Easy;
            var game = new Game(difficulty);
            var playerService = new PlayerService(game, difficulty);
            var expectedHealth = new PlayerSettings(difficulty).Health - 1;
            // Act
            playerService.OnHitted();
            var healthAfterHit = playerService.GetPlayerHealth();

            // Assert
            Assert.AreEqual(expectedHealth, healthAfterHit);
        }

        [TestMethod]
        public void Player_NotCollidedWithObject()
        {
            // Arrange
            var difficulty = Difficulty.Easy;
            var game = new Game(difficulty);
            var playerService = new PlayerService(game, difficulty);

            var collisionObject = new PictureBox
            {
                Location = new Point(game.playerPicutreBox.Location.X / 2, game.playerPicutreBox.Location.Y / 2),
                Size = game.playerPicutreBox.Size,
            };

            // Act
            var collisionResult = playerService.CheckForColission(collisionObject, EntityType.Alien);

            // Assert
            Assert.AreEqual(collisionResult, false);
        }

        [TestMethod]
        public void Player_CollidedWithObject()
        {
            // Arrange
            var difficulty = Difficulty.Easy;
            var game = new Game(difficulty);
            var playerService = new PlayerService(game, difficulty);

            var collisionObject = new PictureBox
            {
                Location = new Point(game.playerPicutreBox.Location.X, game.playerPicutreBox.Location.Y),
                Size = game.playerPicutreBox.Size,
            };

            // Act
            var collisionResult = playerService.CheckForColission(collisionObject, EntityType.Alien);

            // Assert
            Assert.AreEqual(collisionResult, true);
        }
    }
}
