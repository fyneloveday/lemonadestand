using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    
    public class Game
    {
        
        public void displayRules()
        {
                Console.WriteLine("Welcome to your lemonade stand. Where your business savvy are put to the test./n" +
                "The game is pretty simple./n" +
                "First, buy your desired items at the store./n" +
                "Then put together a recipe for your customers./n" +
                "Set your price, and see the results of your business decision making skills./n" +
                "Here's a hint: Check the weather forecast and the temperature./n" +
                "As the day gets hotter, you would want to increase your prices, as customers are more willing to pay/n" +
                "As the day gets cooler, consider lowering your price to attract more business." +
                "Bonne Chance!!!");
        }

        //member variable
        public List<Day> days;
        public Day day;

        public Game()
        {
            days = new List<Day>();
            day = new Day();
        }
        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }
        public void StartGame()
        {
            Player = new Player();
            
        }

        public void PrepareForDay()
        {
            Player = new Player();
            days[0].MakePitcher(Player.inventory);
        }
        public void getPlayer()
        {
            throw new System.NotImplementedException();
        }

        public void getDaySale()
        {
            throw new System.NotImplementedException();
        }

        public void getCustomers()
        {
            throw new System.NotImplementedException();
        }

        public void getCurrentDay()
        {
            throw new System.NotImplementedException();
        }
        public void GenerateDays()
        {
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }

        public void RunGame()
        {
            for (int i = 0; i < 7; i++)
            {
                //for loop
                day.RunDay();
            }
        }
    }
}