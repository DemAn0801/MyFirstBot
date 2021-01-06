using System;

namespace MyFirstBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            bot.botName = "Бедрос";
            bot.Greetings();
            bot.SelectGame();
        }
    }
}
