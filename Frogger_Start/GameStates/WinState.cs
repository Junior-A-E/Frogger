using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace Frogger_Start.GameStates
{
    class WinState : GameState
    {
        public WinState()
        {
            gameObjectList.Add(new GameObject("spr_win_screen"));
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
