using System;

namespace MyFirstBot
{
    class Games
    {
        GamePlay gameplay = new GamePlay();
        public void Game1()
        {
            Random rnd1 = new Random();
            int randomNumber1 = rnd1.Next(0, 9);
            gameplay.PlayMove();
                  
        }
        public void Game2()
        {
            Random rnd2 = new Random();
            int randomNumber2 = rnd2.Next(11, 19);
            gameplay.PlayMove();
        }
    }
}
