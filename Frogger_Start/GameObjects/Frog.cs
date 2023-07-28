using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frogger
{
    class Frog : GameObject
    {
        public Vector2 lastPosition;
        bool keyReleased = true;
        public Frog() : base("spr_frog")
        {
        }

        public override void Reset()
        {
            base.Reset();
            position.X = GameEnvironment.Screen.X / 2 - this.texture.Width / 2;
            position.Y = GameEnvironment.Screen.Y - this.texture.Height;
        }

        public override void Update()
        {
            base.Update();

            lastPosition = position;
            velocity = Vector2.Zero;

            KeyboardState keyboard = GameEnvironment.KeyboardState;
            if (keyboard.IsKeyDown(Keys.Left) && keyReleased)
            {
                velocity = new Vector2(-40, 0);
                position += velocity;
                keyReleased = false;
            }

            if (keyboard.IsKeyDown(Keys.Right) && keyReleased)
            {
                velocity = new Vector2(40, 0);
                position += velocity;
                keyReleased = false;
            }

            if (keyboard.IsKeyDown(Keys.Up) && keyReleased)
            {
                velocity = new Vector2(0, -40);
                position += velocity;
                keyReleased = false;
            }

            if (keyboard.IsKeyDown(Keys.Down) && keyReleased)
            {
                velocity = new Vector2(0, 40);
                position += velocity;
                keyReleased = false;
            }

            if (keyboard.IsKeyUp(Keys.Left) &&
                keyboard.IsKeyUp(Keys.Right) &&
                keyboard.IsKeyUp(Keys.Down) &&
                keyboard.IsKeyUp(Keys.Up)) keyReleased = true;

            if (position.X > GameEnvironment.Screen.X - texture.Width || position.X < 0 || position.Y < 0 || position.Y > GameEnvironment.Screen.Y)
            {
                position = lastPosition;
            }

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
