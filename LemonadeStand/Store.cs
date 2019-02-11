using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {

        //member Variables
        public double lemonsPrice;
        public double sugarPrice;
        public double icePrice;
        public double cupsPrice;


        //constructor
        public Store()
        {
            lemonsPrice = 0.50;
            sugarPrice = 0.15;
            icePrice = 1.15;
            cupsPrice = 0.70;
        }
    }
       
}