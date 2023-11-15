using System.Collections.Generic;
using System.Drawing;

namespace Space_Invaders.Entities.Constants
{
    public static class AlienConstants
    {
        public static readonly Size ALIEN_SIZE = new Size(40, 40);
        public static readonly Dictionary<int, Image> alienTypePerRow = new Dictionary<int, Image>
        {
            { 0, Properties.Resources.alienType1 },
            { 1, Properties.Resources.alienType1 },
            { 2, Properties.Resources.alienType2 },
            { 3, Properties.Resources.alienType2 },
            { 4, Properties.Resources.alienType3 },
        };
        public static readonly int DISTANCE_BETWEEN_ALIENS = 65;
        public static readonly int ROWS = 5;
        public static readonly int COLUMNS = 11;
        public static readonly int TOP_CORNER_PADDING = 10;
        public static readonly int MAX_POSITION_Y = 600;
    }
}
