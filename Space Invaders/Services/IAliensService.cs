using Space_Invaders.Entities.Enums;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders.Services
{
    public interface IAliensService
    {
        void SummonAliens();
        bool CheckForColission(PictureBox bullet, EntityType shooter);
        Task<bool> AliensMovement();
    }
}