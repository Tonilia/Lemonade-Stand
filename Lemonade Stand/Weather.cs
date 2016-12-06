using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        string choice;
        int temperture;
        public void GetForecast()
        {
            Console.WriteLine(" Before we buy supplies, we need to know what the weather is.");
            Console.ReadLine();
            GetTemperture();
            Random r = new Random();
            int randomInt = r.Next(0, 3);

            switch (randomInt)
            {           
                case 0:
                    choice = "Cloudy";
                    break;
                case 1:
                    choice = "Sunny";
                    break;
                case 2:
                    choice = "Rainy";
                    break;
                case 3:
                    choice = "Hot";
                    break;              
            }
            Console.WriteLine(" The weather today is {0} and {1} degrees.", choice, temperture);
        }

        public void GetTemperture()
        {
            Random r = new Random();
            temperture = r.Next(60, 100);          
        }
    }
}
