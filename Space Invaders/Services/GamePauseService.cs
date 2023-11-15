namespace Space_Invaders.Services
{
    public static class GamePauseService
    {
        private static bool IsPaused = false;

        public static void Pause()
        {
            IsPaused = true;
        }

        public static void UnPause()
        {
            IsPaused = false;
        }

        public static bool IsGamePaused() => IsPaused;
    }
}
