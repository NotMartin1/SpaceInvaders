using Space_Invaders.Entities.Constants;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Space_Invaders.Entities
{
    public static class Bullet
    {
        public static PictureBox GetBulletPictureBox(int shooterLocationX, int shooterLocationY, int shooterWidth) =>
            new PictureBox
            {
                Size = new Size(GameConstants.BULLET_WIDTH, GameConstants.BULLET_HEIGHT),
                BackColor = GameConstants.BULLET_COLOR,
                Location = new Point(shooterLocationX + (shooterWidth / 2) - 2, shooterLocationY - 15),
                Name = Guid.NewGuid().ToString(),
                Visible = true,
            };
    }
}
