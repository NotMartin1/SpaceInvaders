using Space_Invaders.Entities.Enums;
using System.Drawing;
using System.Windows.Forms;

namespace Space_Invaders.Entities
{
    public class Barrier : GameEntityCommon
    {
        public PictureBox ImageBox { get; set; }

        public Barrier(Difficulty difficulty, PictureBox imageBox)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    Health = 10;
                    break;
                case Difficulty.Medium:
                    Health = 5;
                    break;
                case Difficulty.Hard:
                    Health = 1;
                    break;
            }

            ImageBox = imageBox;
        }

        public static Image GetCurrentBarrierImageByDifficulty(int health, Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    if (8 <= health && health <= 10)
                        return Properties.Resources.barrier1;
                    if (6 <= health && health <= 8)
                        return Properties.Resources.barrier2;
                    if (4 <= health && health <= 6)
                        return Properties.Resources.barrier3;
                    if (2 <= health && health <= 4)
                        return Properties.Resources.barrier4;
                    if (1 <= health && health <= 2)
                        return Properties.Resources.barrier5;
                    break;
                case Difficulty.Medium:
                    if (4 <= health && health <= 5)
                        return Properties.Resources.barrier2;
                    if (3 <= health && health <= 4)
                        return Properties.Resources.barrier3;
                    if (2 <= health && health <= 3)
                        return Properties.Resources.barrier4;
                    if (1 <= health && health <= 2)
                        return Properties.Resources.barrier5;
                    break;
                case Difficulty.Hard:
                    if (health == 1)
                        return Properties.Resources.barrier1;
                    break;
            }
            return null;
        }
    }
}
