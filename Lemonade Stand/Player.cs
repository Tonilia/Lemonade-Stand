using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
       public string name;
       public Store myStore = new Store();

        public void SetPlayerName()
        {
            Console.WriteLine("\n What is your name or a fun stand name?");
            name = Console.ReadLine().ToLower();
            Console.WriteLine(" Welcome, {0}.", name);
        }

    }
}
