using Microsoft.Xna.Framework;

namespace Frogger_Start.GameObjects
{
    class Lives : GameObject
    {
        public Lives(Vector2 position) : base("spr_frog")
        {
            this.position = position;
        }
    }
}
