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
        int choice;
        Weather weather = new Weather();

        public void BuildPerson()
        {
            Random r = new Random();
            numbers = r.Next(0, 100);
        }
        //        lemonsTotal = store.lemonsToBuy + currentLemons;     lemon = double.Parse
        //lemonsToBuy = Convert.ToDouble(Console.ReadLine( ));



        public void BuildCustomers(Weather weather)
        {
            ////string choice = "choice";
            //int choice = int.TryParse(weather);
            ////choice = Convert.ToInt32(Console.ReadLine());
            //customerTotal = weather.choice + numbers + weather.temperature + buyCup;
            //Console.WriteLine(" You had {0} cups bought today.", customerTotal);
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
    
        