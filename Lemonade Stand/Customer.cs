using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {
        int number = 0;
        int buyCup;
        Weather weather = new Weather();
        public void GetCustomerBuyCup()
        {

        }
        public void BuildCustomers()
        {
            Random r = new Random();
            number = r.Next(0, 25);  //cloudy, rainy, hot, sunny
            while (number < 25)
            {
                if ((number % 3) == 0)  //odd
                {
                    string cloudy = "Cloudy";
                    if (weather.choice == cloudy && weather.temperature <= 80)
                    {
                        buyCup++;
                    }
                }
                else if ((number % 2) == 0) //even
                {
                    string hot = "Hot";
                    if (weather.choice == hot && weather.temperature >= 80)
                    {
                        buyCup++;
                    }
                }
            }

            Random ra = new Random();
            number = r.Next(26, 50);  //cloudy, rainy, hot, sunny
            while (number < 50)
            {
                if ((number % 3) == 0)  //odd
                {
                    string sunny = "Sunny";
                    if (weather.choice == sunny && weather.temperature >= 80)
                    {
                        buyCup++;
                    }
                }
                else if ((number % 2) == 0) //even
                {
                    string rainy = "Rainy";
                    if (weather.choice == rainy && weather.temperature <= 80)
                    {
                        buyCup++;
                    }
                }
            }

            Random ran = new Random();
            number = r.Next(51, 75);  //cloudy, rainy, hot, sunny
            while (number < 75)
            {
                if ((number % 3) == 0)  //odd
                {
                    string cloudy = "Cloudy";
                    if (weather.choice == cloudy && weather.temperature >= 80)
                    {
                        buyCup++;
                    }
                }
                else if ((number % 2) == 0) //even
                {
                    string hot = "Hot";
                    if (weather.choice == hot && weather.temperature <= 80)
                    {
                        buyCup++;
                    }
                }
            }

            Random rand = new Random();
            number = r.Next(76, 100);  //cloudy, rainy, hot, sunny
            while (number > 76)
            {
                if ((number % 3) == 0)  //odd
                {
                    string sunny = "Sunnyy";
                    if (weather.choice == sunny && weather.temperature <= 80)
                    {
                        buyCup++;
                    }
                }
                else if ((number % 2) == 0) //even
                {
                    string rainy = "Rainy";
                    if (weather.choice == rainy && weather.temperature >= 80)
                    {
                        buyCup++;
                    }
                }
            }
        }
    }
}