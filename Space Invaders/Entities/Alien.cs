using Space_Invaders.Entities.Constants;
using System.Drawing;
using System.Windows.Forms;

namespace Space_Invaders.Entities
{
    public static class Alien
    {
        public static PictureBox GetAlienPictureBox(int row, int column, Point location) =>
             new PictureBox
             {
                 Size = AlienConstants.ALIEN_SIZE,
                 Image = AlienConstants.alienTypePerRow[row],
                 InitialImage = AlienConstants.alienTypePerRow[row],
                 SizeMode = PictureBoxSizeMode.StretchImage,
                 Location = location,
                 Name = $"{row} {column}",
                 Visible = true,
             };
    }
}
