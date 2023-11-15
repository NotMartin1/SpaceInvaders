using Space_Invaders.Entities.Enums;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders.Services
{
    public interface IPlayerService
    {
        Task PlayerMove(Direction moveDirection);
        Task Shoot();
        int GetPlayerHealth();
        bool CheckForColission(PictureBox bullet, EntityType shooter);
    }
}