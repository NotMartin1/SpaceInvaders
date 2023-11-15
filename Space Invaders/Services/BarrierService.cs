using Space_Invaders.Entities;
using Space_Invaders.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Space_Invaders.Services
{
    public class BarrierService : GameEntity, IBarrierService
    {
        private List<Barrier> barriers;
        private Game _mainGameForm;
        private Barrier lastHittedBarrier;
        private readonly Difficulty difficulty;

        public BarrierService(Game mainGameForm, Difficulty difficulty)
        {
            this.difficulty = difficulty;
            _mainGameForm = mainGameForm;
        }

        public void InitializeBarriers()
        {
            barriers = new List<Barrier>
            {
                new Barrier(difficulty, _mainGameForm.barrier1),
                new Barrier(difficulty, _mainGameForm.barrier2),
                new Barrier(difficulty, _mainGameForm.barrier3),
                new Barrier(difficulty, _mainGameForm.barrier4)
            };

            foreach (var barrier in barriers)
                barrier.ImageBox.Image = Barrier.GetCurrentBarrierImageByDifficulty(barrier.Health, difficulty);
        }

        public override bool CheckForColission(PictureBox bullet, EntityType shooter)
        {
            var barrierHitted = barriers.FirstOrDefault(x => x.ImageBox.Visible && bullet.Bounds.IntersectsWith(x.ImageBox.Bounds));
            if (barrierHitted == null)
                return false;

            lastHittedBarrier = barrierHitted;
            OnHitted();
            return true;
        }

        public override void OnHitted()
        {
            lastHittedBarrier.Health--;

            if (lastHittedBarrier.Health == 0)
                lastHittedBarrier.ImageBox.Visible = false;

            lastHittedBarrier.ImageBox.Image = Barrier.GetCurrentBarrierImageByDifficulty(lastHittedBarrier.Health, difficulty);
        }
    }
}
