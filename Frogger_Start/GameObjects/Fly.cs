
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger_Start.GameObjects
{
    class Fly : GameObject
    {
        public Fly() : base("spr_fly")
        {
            int x = GameEnvironment.Random.Next(0,GameEnvironment.Screen.X - this.texture.Width);
            int y = GameEnvironment.Random.Next(0, 100);
            this.position = new Vector2(x,y);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }


    }
}
