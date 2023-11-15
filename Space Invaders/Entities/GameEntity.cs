using Space_Invaders.Entities.Enums;
using System.Windows.Forms;

namespace Space_Invaders.Entities
{
    public abstract class GameEntity
    {
        public abstract bool CheckForColission(PictureBox bullet, EntityType target = EntityType.All);
        public abstract void OnHitted();
    }
}
