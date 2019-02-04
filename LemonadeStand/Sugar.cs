using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Sugar : Ingredients
    {
        public List<Sugar> sugarList = new List<Sugar>();
        public double ingredientPrice = 1;
    }
}