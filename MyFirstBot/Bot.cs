using System;

namespace MyFirstBot
{
    class Bot
    {
        private string name;
        public string botName
        {
            get { return name; }
            set { name = value; }
        }

        public void Greetings()
        {
            Console.WriteLine($"Hi i am {name}! Let's play a game! I am choose the number and you should guess it. You have not limited attemps");
        }


        public void SelectGame()
        {
            Games game = new Games();
            GamePlay gamePlay = new GamePlay();
            Console.WriteLine("Choose the game: input 'f' if you whant guess number from 1 for 10 and 's' if from 11 for 20 and 'e' if you whant to exit");
            string choosing = Console.ReadLine();
            {
                if (choosing == "")
                {
                    Console.WriteLine("the value is missing. repeat the input");
                    SelectGame();
                }
                else
                {
                    while (true)

                        switch (choosing)
                        {
                            case "f":
                                game.Game1();
                                break;

                            case "s":
                                game.Game2();
                                break;

                            case "e":
                                Environment.Exit(0);
                                break;

                            default:
                                SelectGame();
                                break;
                        }

                }
            }
        }
        public void Repeat()
        {
            Console.WriteLine("Do you whant to play again? Please input N if you whant finish and Y if your whant to play again");
            string answer = Console.ReadLine();
            try
            {
                switch (answer)
                {
                    case "N":
                        Environment.Exit(0);
                        break;

                    case "Y":
                        SelectGame();
                        break;
                }
            }
            catch (Exception)
            {
                Repeat();
            }


        }
    }
}

