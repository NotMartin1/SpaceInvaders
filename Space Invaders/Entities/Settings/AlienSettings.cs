using Space_Invaders.Entities.Enums;

namespace Space_Invaders.Entities.Settings
{
    public class AlienSettings
    {
        public int BulletSpeed { get; set; }
        public int StepSize { get; }
        public int CurrentStepSize { get; set; }
        public int MaxStepSize { get; }
        public int ShootingAliens { get; }
        public Direction MovementDirection { get; set; } = Direction.Right;

        public AlienSettings(Difficulty difficulty)
        {
            switch (difficulty) 
            {
                case Difficulty.Easy:
                    BulletSpeed = 5;
                    StepSize = 2;
                    CurrentStepSize = 10;
                    MaxStepSize = 50;
                    ShootingAliens = 3;
                    break;
                case Difficulty.Medium:
                    BulletSpeed = 10;
                    StepSize = 3;
                    CurrentStepSize = 15;
                    MaxStepSize = 100;
                    ShootingAliens = 5;
                    break;
                case Difficulty.Hard:
                    BulletSpeed = 10;
                    StepSize = 5;
                    CurrentStepSize = 25;
                    MaxStepSize = 250;
                    ShootingAliens = 7;
                    break;
            }
        }
    }
}
