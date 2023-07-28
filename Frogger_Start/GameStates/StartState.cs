using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace Frogger_Start.GameStates
{
    class StartState : GameState
    {
        public StartState()
        {
            gameObjectList.Add(new GameObject("spr_start_screen"));
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            var keys = Keyboard.GetState().GetPressedKeys();
            if (keys.Count() > 0)
            {
                GameEnvironment.SwitchTo(1);
            }
        }
    }
}
