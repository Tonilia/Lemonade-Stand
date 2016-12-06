using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        Player player = new Player();
        Weather weather = new Weather();
        Inventory inventory = new Inventory();

        public void RunGame()
        {
            Greeting();
            GetRules();
            player.SetPlayerName();
            SetUpGame();
        }

        public void Greeting()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Welcome to the Classic Game of Lemonade Stand");
            Console.ResetColor();
            Console.ReadLine();
        }

        public void GetRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Your goal is to make as much money as you can selling cups of lemonade.");
            Console.WriteLine(" You will be selling for 7 days straight in a variety of weather conditions.");
            Console.ReadLine();
            Console.WriteLine(" You will build your recipe and can change it as you see fit each day based");
            Console.WriteLine(" on the weather and your inventory.\n");
            Console.WriteLine(" Buy cups, sugar, ice, and lemons with money you have to build your inventory.");
            Console.WriteLine(" Lastly, set your price based on the day's weather.");
            Console.ReadLine();
            Console.WriteLine(" After each day, you will see your profit and loss.");
            Console.WriteLine(" At the end of the game, you will see how much money you made during the week.");
            Console.WriteLine(" Happy Selling!");
            Console.ResetColor();
        }

        public void SetUpGame()
        {
            Console.WriteLine(" Your parents have given you $20 to open your {0}'s Lemonade stand.", player.name);
            weather.GetForecast();
            player.myStore.BuySupplies();
            inventory.CurrentInventory();
            //Console.WriteLine(" Let's get started!");
            //player.name();
        }

        public void GameDay()
        {
            //loop through 7 days
        }
    }
    }
