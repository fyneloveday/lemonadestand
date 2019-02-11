using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    // class
    public class LemonadeMix
    {

        // member variables
        // (things that relate to the class...)
        // variables are something the class has
        // always need access modifiers and data type
        public double pricePerCup;
        public int sugarScoops;

        //constructor
       
        


        //methods / what your class can do
        //methods start with uppercase
        //variables start with lowercase
        public double setPricePerCup()
        {
            Console.Write("How much will your lemonade cost: ");
            pricePerCup = Convert.ToDouble(Console.ReadLine());

            return pricePerCup;
        }

        
        public void sellLemonade()
        {
           // double mixedLemonade = pricePerCup * day.customerFrequency;
        }
 

        public void mixLemons(Inventory inventory)
        {
            Console.WriteLine("How many lemons for your pitcher: ");
            // local variable. Does not need protection level
            int squeezedLemons = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < squeezedLemons; i++)
            {
                inventory.lemonsList.RemoveAt(0);
            }

           
            // record how many lemons are left
        }


        public void mixSugar(Inventory inventory)
        {
            Console.WriteLine("How many scoops of sugar will you use in your mix: ");
           sugarScoops = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sugarScoops; i++)
            {
                inventory.sugarList.RemoveAt(0);
            }
            // record how much sugar is left
        }


        public void mixIce(Inventory inventory)
        {
            Console.WriteLine("How many cubes of ice will you use to cool your drink mix: ");
            int iceCubes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < iceCubes; i++)
            {
                inventory.iceList.RemoveAt(0);
            }
            // record how much ice is left
        }


        public void numberOfCupsForTheDay(Inventory inventory)
        {
            Console.WriteLine("How many cups of Lemonade will you be serving for the day: ");
            int cupsForTheDay = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cupsForTheDay; i++)
            {
                inventory.cupsList.RemoveAt(0);
            }
            // record number of cups left
        }


        
        //int lemons;
        //int sugar;
        //int ice;
        //int cups;

        //Console.WriteLine() 
            
        
       
    }
}