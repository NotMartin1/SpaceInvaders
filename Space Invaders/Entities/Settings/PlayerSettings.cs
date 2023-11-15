using Space_Invaders.Entities.Enums;
using System.Collections.Generic;

namespace Space_Invaders.Entities
{
    public class PlayerSettings
    {
        public int Health { get; set; }
        public int BulletSpeed { get; set; }

        public PlayerSettings(Difficulty difficulty)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    Health = 5;
                    BulletSpeed = 13;
                    break;
                case Difficulty.Medium:
                    Health = 3;
                    BulletSpeed = 11; 
                    break;
                case Difficulty.Hard:
                    Health = 1;
                    BulletSpeed = 11;
                    break;
            }
        }
    }
}
