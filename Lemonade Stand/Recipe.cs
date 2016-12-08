using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Recipe : IMixable
    {
        double lemon;
        double sugar;
        double ice;
        public void BuildRecipe(Inventory inventory, Store store)
        {
            Console.WriteLine(" Now that you have your inventory. Now is the time to make your recipe.");
            Console.WriteLine(" Each pitcher holds 4 cups of lemonade.");
            GetLemons(inventory, store);
            GetSugar(inventory);
            GetIceCubes(inventory);
        }
        public void GetLemons(Inventory inventory, Store store)
        {
            Console.WriteLine(" \n You currently have {0}  lemons in your inventory.", inventory.lemonsTotal);
            Console.WriteLine(" How many lemons would you like to add to your pitcher?");
            lemon = double.Parse(Console.ReadLine());
            if (lemon < inventory.lemonsTotal)
            {
                inventory.lemonsTotal -= lemon;
            }
            else
            {
                Console.WriteLine(" Don't have enough lemons in your inventory.");
                //BuyLemons(Store store);
            }          
        }
        public void GetSugar(Inventory inventory)
        {
            Console.WriteLine(" \n You currently have {0}  cups of sugar in your inventory.", inventory.sugarTotal);
            Console.WriteLine(" How many cups of sugar would you like to add to your pitcher?");
            sugar = double.Parse(Console.ReadLine());
            if (sugar < inventory.sugarTotal)
            {
                inventory.sugarTotal -= sugar;
            }
            else
            {
                Console.WriteLine(" Don't have enough cups of sugar in your inventory.");
            }
        }
        public void GetIceCubes(Inventory inventory)
        {
            Console.WriteLine(" \n You currently have {0}  ice cubes in your inventory.", inventory.iceCubesTotal);
            Console.WriteLine("How many ice cubes would you like to add into each cup?");
            ice = double.Parse(Console.ReadLine());
            if (ice < inventory.iceCubesTotal)
            {
                inventory.iceCubesTotal -= ice;
            }
        }
        
    }
}
    