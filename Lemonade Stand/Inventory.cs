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

        public void CurrentInventory(Store store)
        {
            Console.WriteLine(" Your current inventory is ...");
            CalculateLemons(store);
            Console.WriteLine(" {0}  lemons", lemonsTotal);
            CalculateCups(store);
            Console.WriteLine(" {0}  Cups", cupsTotal);
            CalculateSugar(store);
            Console.WriteLine(" {0}  Sugar Cups", sugarTotal);
            CalculateIceCubes(store);
            Console.WriteLine(" {0}  Ice Cubes", iceCubesTotal);
        }
        public void CalculateLemons(Store store)
        {
            lemonsTotal = store.lemonsToBuy + currentLemons;
         }

        public void CalculateCups(Store store)
        {
            cupsTotal = currentCups + store.cupsToBuy;
        }

        public void CalculateSugar(Store store)
        {
            sugarTotal = currentSugar + store.sugarToBuy;
        }

        public void CalculateIceCubes(Store store)
        {
            iceCubesTotal = currentIceCubes + store.iceToBuy;
        }
       
    }
}
