using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger_Start.GameStates
{
    class EndState: GameState
    {
        public EndState() {
            gameObjectList.Add(new GameObject("spr_gameover_screen"));
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
