using Frogger_Start.GameObjects;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Frogger
{
    class PlayingState : GameState
    {
        List<Lives> lives;
        List<Car> cars;

        Frog frog;
        Fly fly;
        public PlayingState()
        {
            cars = new List<Car>();
            lives = new List<Lives>();

            frog = new Frog();
            fly = new Fly();
            gameObjectList.Add(new GameObject("spr_background"));
            gameObjectList.Add(frog);
            gameObjectList.Add(fly);

            Car car;
            for (int i = 0; i < 3; i++)
            {
                car = new Car("spr_dozer", new Vector2(i * 140, GameEnvironment.Screen.Y - 110), new Vector2(4, 0), 2);
                gameObjectList.Add(car);
                cars.Add(car);
            }
            for (int j = 0; j < 3; j++)
            {
                car = new Car("spr_truck", new Vector2((GameEnvironment.Screen.X - 100) - (j * 160), GameEnvironment.Screen.Y - 70), new Vector2(-1, 0), 1);
                gameObjectList.Add(car);
                cars.Add(car);
            }
            for (int k = 0; k < 3; k++)
            {
                car = new Car("spr_racecar", new Vector2((GameEnvironment.Screen.X - 80) - (k * 120), GameEnvironment.Screen.Y - 150), new Vector2(-3, 0), 3);
                gameObjectList.Add(car);
                cars.Add(car);
            }

            this.AddNewLives();
        }

        public void AddNewLives()
        {
            gameObjectList.Add(new Lives(new Vector2(10, 10)));
            lives.Add(new Lives(new Vector2(10, 10)));
            gameObjectList.Add(new Lives(new Vector2(50, 10)));
            lives.Add(new Lives(new Vector2(50, 10)));
            gameObjectList.Add(new Lives(new Vector2(90, 10)));
            lives.Add(new Lives(new Vector2(90, 10)));
        }
        public override void Reset()
        {
            base.Reset();
        }
        public override void Update(GameTime gameTime)
        {
            foreach (Car car in cars)
            {
                if (lives.Count > 0)
                {
                    if (frog.Overlaps(car))
                    {
                        lives.RemoveAt(lives.Count - 1);
                        gameObjectList.RemoveAt(gameObjectList.Count - 1);
                        frog.Reset();
                    }
                    else if (frog.Overlaps(fly))
                    {
                        GameEnvironment.SwitchTo(3);
                        this.AddNewLives();
                        frog.Reset();
                    }
                }
                else
                {
                    this.AddNewLives();
                    GameEnvironment.SwitchTo(2);
                }
            }
            base.Update(gameTime);
        }
    }
}
