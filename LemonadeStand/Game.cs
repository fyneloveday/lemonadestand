using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        public List<Day> days = new List<Day>();
        public Player Player
        {
            get => default(Player);
            set
            {
            }
        }

        public void displayRules()
        {
            throw new System.NotImplementedException();
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
    }
}