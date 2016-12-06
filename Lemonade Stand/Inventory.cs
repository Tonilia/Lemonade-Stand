using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Inventory
    {
        double currentLemons = 0;
        double currentCups = 0;
        double currentSugar = 0;
        double currentIceCubes = 0;
        public double lemonsTotal;
        public double cupsTotal;
        public double sugarTotal;
        public double iceCubesTotal;
        Store store = new Store();

        public void CurrentInventory()
        {
            Console.WriteLine(" Your current inventory is ...");
            CalculateLemons();
            Console.WriteLine(" {0}  lemons", lemonsTotal);
            CalculateCups();
            Console.WriteLine(" {0}  Cups", cupsTotal);
            CalculateSugar();
            Console.WriteLine(" {0}  Sugar Cups", sugarTotal);
            CalculateIceCubes();
            Console.WriteLine(" {0}  Ice Cubes", iceCubesTotal);
        }
        public void CalculateLemons()
        {
            lemonsTotal = store.lemonsToBuy + currentLemons;
           // lemonsTotal = double.Parse(Console.ReadLine());
            //Convert.ToString() = lemonsTotal;
            lemonsTotal = Convert.ToString();
         }

        public void CalculateCups()
        {
            cupsTotal = currentCups + store.cupsToBuy;
        }

        public void CalculateSugar()
        {
            sugarTotal = currentSugar + store.sugarToBuy;
        }

        public void CalculateIceCubes()
        {
            iceCubesTotal = currentIceCubes + store.iceToBuy;
        }
       
    }
}
