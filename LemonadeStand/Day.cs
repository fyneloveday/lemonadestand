using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public Player player;
        public Store store;
        public LemonadeMix lemonadeMix;
        public Inventory inventory;




        public Day()
        {
            weather = new Weather();
            player = new Player();
            store = new Store();
            lemonadeMix = new LemonadeMix();
            inventory = new Inventory(); 
        }
        public void MakePitcher(Inventory inventory)
        {
            player.lemonadeMix.mixLemons(player.inventory);

        }

        //public void price()
        //{
        //    Console.WriteLine("How much will your lemonade cost: ");
        //    double lemonadePrice = Convert.ToDouble(Console.ReadLine());

        //}


        public void regulateCustomerFrequency()
        {
            int customerFrequency;

            if ((weather.temperature <= 50) && (weather.weatherConditions[weather.condition] == "cloudy"))
            {
                customerFrequency = 50;
            }
            else if ((weather.temperature >= 50) && (weather.weatherConditions[weather.condition] == "cloudy"))
            {
                customerFrequency = 60;
            }
            else if ((weather.temperature <= 50) && (weather.weatherConditions[weather.condition] == "rainy"))
            {
                customerFrequency = 40;
            }
            else if ((weather.temperature >= 55) && (weather.weatherConditions[weather.condition] == "rainy"))
            {
                customerFrequency = 53;
            }
            else if ((weather.temperature >= 70) && (weather.weatherConditions[weather.condition] == "sunny"))
            {
                 customerFrequency = 90;
            }

        }

       



        public void RunDay()
        {
            weather.getTemperature();
            weather.GetCondition();
            player.BuyIce(store);
            player.BuyLemons(store);
            player.BuySugar(store);
            player.BuyCups(store);
            lemonadeMix.mixSugar(inventory);
            lemonadeMix.mixLemons(inventory);
            lemonadeMix.mixIce(inventory);
            lemonadeMix.setPricePerCup();
            
        }
                     

    }
}