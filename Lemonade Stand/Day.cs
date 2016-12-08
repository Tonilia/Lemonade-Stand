using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        Weather weather = new Weather();
        Customer customer = new Customer();
        int i = 0;
        double price;

        public void SetDay()
        {
            for (i = 0; i >= 50; i++)
                {
                    customer.BuildPerson();
                    customer.BuyCupCustomer();
                    customer.BuildCustomers(weather);
                }
        }
        public void SetPrice()
        {
            Console.WriteLine(" How much would you like to charge for each cup?");
            Console.WriteLine(" Please enter price like the example. 1.05 or .25");
            price = double.Parse(Console.ReadLine());
        }
        //public void GetDailyReport()
        //{

        //}
    }
}
