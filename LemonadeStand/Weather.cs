using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        public List<string> weatherConditions = new List<string> { "Rainy", "Sunny", "Cloudy" };


        public int temperature;
        public int condition;

        public void getTemperature()
        {
            Random rnd = new Random();
            temperature = rnd.Next(40, 100);
        }

            public Weather()
        {

        }
        

        public void GetCondition()
        {
            Random rnd = new Random();
            condition = rnd.Next(0, 2);
            Console.WriteLine("Today's weather forecast is " + weatherConditions[condition]);

            Console.ReadLine();
        }
      

            //Console.ReadKey();
        
    }

       
}
