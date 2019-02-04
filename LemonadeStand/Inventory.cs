using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemons> lemonsList = new List<Lemons>();
        public List<Sugar> sugarList = new List<Sugar>();
        public List<Cups> cupsList = new List<Cups>();
        public List<Ice> iceList = new List<Ice>();

        public Lemons lemons = new Lemons();
        public Sugar sugar = new Sugar();
        public Ice ice = new Ice();
        public Cups cups = new Cups();
        public void AddLemons()
        {
            int numberOfLemons;
            Console.WriteLine();
        }

    }
}