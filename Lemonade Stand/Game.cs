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
        Recipe recipe = new Recipe();
        Day day = new Day();
        int i = 0;

        public void RunGame()
        {
            Greeting();
            GetRules();
            player.SetPlayerName();
            GameDay();
           // EndGame();
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
       
        public void GameDay()
        {
            weather.GetForecast();
            SetUpGame();
            day.SetPrice();
            day.SetDay();
            day.GetDailyReport();
            RunDay();
        }
        public void SetUpGame()
        {
            player.myStore.BuySupplies(player);
            inventory.CurrentInventory(player.myStore);
            recipe.BuildRecipe(inventory, recipe);
        }
        public void RunDay()
        {
            Console.WriteLine(" Day {0}", i + 1);
                if (i == 0)
                {
                    Console.WriteLine(" Monday");
                }
                else if (i == 1)
                {
                    Console.WriteLine(" Tuesday");
                }
                else if (i == 2)
                {
                    Console.WriteLine(" Wednesday");
                }
                else if (i == 3)
                {
                    Console.WriteLine(" Thursday");
                }
                else if (i == 4)
                {
                    Console.WriteLine(" Friday");
                }
                else if (i == 5)
                {
                    Console.WriteLine(" Saturday");
                }
                else if (i == 6)
                {
                    Console.WriteLine(" Sunday");
                }
            }            
        }
        //public void EndGame()
        //{
        //    Console.WriteLine(" Would you like to play again? yes or no");
        //    string input = Console.ReadLine().ToLower();
        //    if (input == "yes")
        //    {
        //        //RunGame();
        //    }
        //    else if ( input == "no")
        //    {
        //        Console.WriteLine(" Thanks for playing. Goodbye.");
        //    }
        }
   // }

