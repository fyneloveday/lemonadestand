using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        private readonly List<string> weatherConditions = new List<string> { "Rainy", "Sunny", "Cloudy" };
        public Weather()
        {

        }

        public void GetCondition()
        {
            Random rnd = new Random();
            int condition = rnd.Next(0, 2);
            Console.WriteLine("Today's weather forecast is " + weatherConditions[condition]);

            Console.ReadLine();
        }
      

            //Console.ReadKey();
        
    }

       
}
