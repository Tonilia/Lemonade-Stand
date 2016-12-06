using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        
        double iceCubes;
        double lemons;
        double cups;
        double sugar;
        Cashbox money = new Cashbox();
        public double lemonsToBuy;
        public double cupsToBuy;
        public double sugarToBuy;
        public double iceToBuy;

        public void BuySupplies()
        {
            Console.ReadLine();
            Console.WriteLine(" We need to buy supplies first to make your Lemonade recipe.");
            Console.WriteLine(" Cups, lemons, sugar, and/or ice cubes will need to be bought.");
            Console.WriteLine(" Keep in mind the weather when buying things.");
            Console.ReadLine();
            GetLemons();
            GetCups();
            GetSugar();
            GetIceCubes();
            Console.WriteLine(" You bought {0} lemons, {1} cups, {2} cups of sugar, {3} ice cubes.", lemons, cups, sugar, iceCubes);
            Console.WriteLine("Your remaining cashbox is ${0}", money.moneyBox);
        }

        public void GetLemons()
        {
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Let's buy our main ingrediant, lemons first.");
            Console.WriteLine("\n You can get 10 for $.80");
            Console.WriteLine("             30 for $2.30");
            Console.WriteLine("             75 for $4.15");
            Console.WriteLine("\n How many lemons would you like to buy?");
            lemonsToBuy = Convert.ToDouble(Console.ReadLine( ));

            if ( lemonsToBuy == 10)
            {
                lemons += lemonsToBuy;
                money.moneyBox -= .80;
        
            }
            else if (lemonsToBuy == 30)
            {
                lemons += lemonsToBuy;
                money.moneyBox -= 2.30;
            }
            else if (lemonsToBuy == 75)
            {
                lemons += lemonsToBuy;
                money.moneyBox -= 4.15;
            }
            else
            {
                Console.WriteLine("Invalid entry. Enter 10, 30, or 75.");
                GetLemons();
            }
            Console.ResetColor();
        }
       
        public void GetCups() 
        {
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" Let's buy our cups that we'll serve our delicious lemonade in.");
            Console.WriteLine("\n You can get 25 for $.85");
            Console.WriteLine("             50 for $1.75");
            Console.WriteLine("             100 for $2.85");
            Console.WriteLine("\n How many cups would you like to buy?");
            cupsToBuy = Convert.ToDouble(Console.ReadLine( ));

            if (cupsToBuy == 25)
            {
                cups += cupsToBuy;
                money.moneyBox -= .85;

            }
            else if (cupsToBuy == 50)
            {
                cups += cupsToBuy;
                money.moneyBox -= 1.75;
            }
            else if (cupsToBuy == 100)
            {
                cups += cupsToBuy;
                money.moneyBox -= 2.85;
            }
            else
            {
                Console.WriteLine("Invalid entry. Enter 25, 50, or 100.");
                GetCups();
            }
            Console.ResetColor();
        }
        
        public void GetSugar()
        {
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" Let's buy cups of sugar to sweeten our delicious lemonade up.");
            Console.WriteLine("\n You can get 8 for $.75");
            Console.WriteLine("             20 for $1.80");
            Console.WriteLine("             48 for $3.50");
            Console.WriteLine("\n How many sugar cups would you like to buy?");
            sugarToBuy = Convert.ToDouble(Console.ReadLine());

            if (sugarToBuy == 8)
            {
                sugar += sugarToBuy;
                money.moneyBox -= .75;

            }
            else if (sugarToBuy == 20)
            {
                sugar += sugarToBuy;
                money.moneyBox -= 1.80;
            }
            else if (sugarToBuy == 48)
            {
                sugar += sugarToBuy;
                money.moneyBox -= 3.50;
            }
            else
            {
                Console.WriteLine("Invalid entry. Enter 8, 20, or 48.");
                GetSugar();
            }
            Console.ResetColor();
        }
        public void GetIceCubes()
        {
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" Let's buy our ice cubes to chill our delicious lemonade.");
            Console.WriteLine("\n You can get 100 for $.90");
            Console.WriteLine("             250 for $2.05");
            Console.WriteLine("             400 for $3.60");
            Console.WriteLine("\n How many ice cubes would you like to buy?");
            iceToBuy = Convert.ToDouble(Console.ReadLine());

            if (iceToBuy == 100)
            {
                iceCubes += iceToBuy;
                money.moneyBox -= .90;

            }
            else if (iceToBuy == 250)
            {
                iceCubes += iceToBuy;
                money.moneyBox -= 2.05;
            }
            else if (iceToBuy == 400)
            {
                iceCubes += iceToBuy;
                money.moneyBox -= 3.60;
            }
            else
            {
                Console.WriteLine("Invalid entry. Enter 100, 250, or 400.");
                GetIceCubes();
            }
            Console.ResetColor();
        }
    }
}
    
