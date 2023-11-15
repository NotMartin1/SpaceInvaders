using Space_Invaders.Entities.Enums;
using System.Windows.Forms;

namespace Space_Invaders.Services
{
    public interface IBarrierService
    {
        bool CheckForColission(PictureBox bullet, EntityType shooter);
        void OnHitted();
        void InitializeBarriers();
    }
}