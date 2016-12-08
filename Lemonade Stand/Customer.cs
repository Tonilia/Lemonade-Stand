using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        public int numbers;
        int buyCup;
        double customerTotal;
        Weather weather = new Weather();

        public void BuildPerson()
        {
            Random r = new Random();
            numbers = r.Next(0, 50);
        }
  
        public void BuildCustomers(Weather weather)
        {
            customerTotal = numbers + buyCup;
            Console.WriteLine(" You had {0} cups bought today.", customerTotal);
        }
        public void BuyCupCustomer()   
        {
            Random ra = new Random();
            buyCup = ra.Next(0, 1);
            switch(buyCup)
                {             
                case 0:
                    if (weather.choice == "cloudy" && weather.temperature <=80)
                         { }
                    else if (weather.choice == "cloudy" && weather.temperature >= 80)
                         { buyCup++; }
                    else if (weather.choice == "rainy" && weather.temperature <= 80)
                         { buyCup++; }
                    else if (weather.choice == "rainy" && weather.temperature >= 80)
                         { }
                    else if (weather.choice == "hot" && weather.temperature <= 80)
                         { }
                    else if (weather.choice == "hot" && weather.temperature >= 80)
                         { buyCup++; }
                    else if (weather.choice == "sunny" && weather.temperature <= 80)
                         { buyCup++; }
                    else if (weather.choice == "sunny" && weather.temperature >= 80)
                         { }
                    break;
                case 1:
                    if (weather.choice == "cloudy" && weather.temperature <= 80)
                    { buyCup++; }
                    else if (weather.choice == "cloudy" && weather.temperature >= 80)
                    {  }
                    else if (weather.choice == "rainy" && weather.temperature <= 80)
                    {  }
                    else if (weather.choice == "rainy" && weather.temperature >= 80)
                    { buyCup++; }
                    else if (weather.choice == "hot" && weather.temperature <= 80)
                    { buyCup++; }
                    else if (weather.choice == "hot" && weather.temperature >= 80)
                    { }
                    else if (weather.choice == "sunny" && weather.temperature <= 80)
                    { }
                    else if (weather.choice == "sunny" && weather.temperature >= 80)
                    { buyCup++; }
                    break;
            }
        }              
     }     
 }
    
        