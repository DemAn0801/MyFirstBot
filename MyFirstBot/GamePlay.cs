using System;


namespace MyFirstBot
{
    class GamePlay
    {
            Bot bot = new Bot();
            Games game = new Games();

            public void PlayMove()
            {
                Console.WriteLine("Make attempt");
                string attempt = Console.ReadLine();

                if (attempt == "")
                {
                    Console.WriteLine("reapeat attempt");
                    PlayMove();
                }
                else
                {
                    int att = Convert.ToInt32(attempt);

                    if (att == )
                    {
                        Console.WriteLine("you win");
                        bot.Repeat();
                    }
                    else
                    {
                        Console.WriteLine("try again");
                        PlayMove();
                    }
                }
            }
        }
    }
}
