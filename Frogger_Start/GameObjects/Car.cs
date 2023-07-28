using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frogger_Start.GameObjects
{
    class Car : GameObject
    {
        private int line;
        public Car(string assetName, Vector2 position, Vector2 velocity, int line) : base(assetName)
        {
            this.position = position;
            this.velocity = velocity;
            this.line = line;
        }

        public override void Reset()
        {
            base.Reset();
            switch (this.line)
            {
                case 1:
                    this.position = new Vector2(GameEnvironment.Screen.X - texture.Width, GameEnvironment.Screen.Y - 70);
                    break;
                case 2:
                    this.position = new Vector2(0, GameEnvironment.Screen.Y - 110);
                    break;
                case 3:
                    this.position = new Vector2(GameEnvironment.Screen.X - texture.Width, GameEnvironment.Screen.Y - 150);
                    break;
                default:
                    break;


            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        public override void Update()
        {
            base.Update();
            position += velocity;
            if (position.X >= GameEnvironment.Screen.X + texture.Width || position.X <= 0 - texture.Width)
            {
                this.Reset();
            }
        }
    }
}
