﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        public double capital = 20;
        public Inventory inventory;
        public LemonadeMix lemonadeMix;

        public Player()
        {
            inventory = new Inventory();
            lemonadeMix = new LemonadeMix();
        }

       

        public void BuySugar(Store store)
        {
            Console.WriteLine("How much sugar do you want: ");
            int sugarAmount = Convert.ToInt32(Console.ReadLine());
            capital = capital - (sugarAmount * store.sugarPrice);
            Console.WriteLine("You have " + capital);
            
            for(int i = 0; i < sugarAmount; i ++)
            {
                Sugar sugar = new Sugar();
                inventory.sugarList.Add(sugar);
            }
            Console.WriteLine("Your inventory now has " + inventory.sugarList.Count + "sugar");

        }

        public void BuyLemons(Store store)
        {
            Console.WriteLine("How much lemons do you want: ");
            int lemonsAmount = Convert.ToInt32(Console.ReadLine());
            capital = capital - (lemonsAmount * store.lemonsPrice);
            Console.WriteLine("You have " + capital);

            for (int i = 0; i < lemonsAmount; i++)
            {
                Lemons lemons = new Lemons();
                inventory.lemonsList.Add(lemons);
            }
            Console.WriteLine("Your inventory now has " + inventory.lemonsList.Count + "lemons");

        }

        public void BuyCups(Store store)
        {
            Console.WriteLine("How many cups do you want: ");
            int cupsAmount = Convert.ToInt32(Console.ReadLine());
            capital = capital - (cupsAmount * store.cupsPrice);
            Console.WriteLine("You have " + capital);

            for (int i = 0; i < cupsAmount; i++)
            {
                Cups cups = new Cups();
                inventory.cupsList.Add(cups);
            }
            Console.WriteLine("Your inventory now has " + inventory.cupsList.Count + "cups");

        }

        public void BuyIce(Store store)
        {
            Console.WriteLine("How much ice do you want: ");
            int iceAmount = Convert.ToInt32(Console.ReadLine());
            capital = capital - (iceAmount * store.icePrice);
            Console.WriteLine("You have " + capital);

            for (int i = 0; i < iceAmount; i++)
            {
                Ice ice = new Ice();
                inventory.iceList.Add(ice);
            }
            Console.WriteLine("Your inventory now has " + inventory.iceList.Count + "ice");

        }

        public void makeDrinkRecipe()


        {
            //Console.Write("Pick your Lemon batch: ;");
            //Console.ReadLine();
            //Console.WriteLine(int Lemons.lemonBatch);

            //Console.Write("Pick your Cup batch: ");
            //Console.ReadLine();
            //Console.WriteLine(int Cups.cupbatch);

            //Console.Write("Pick your Sugar batch: ");
            //Console.ReadLine();
            //Console.WriteLine(int Sugar.sugarBatch);

            //Console.Write("Pick your Ice batch: ");
            //Console.ReadLine();
            //Console.ReadLine(int Ice.icebatch);

            //int return = drinkRecipe(Console.ReadLine());
            //return drinkRecipe;
            //}

            //  public void countProfits()
            {
                throw new System.NotImplementedException();
            }
        }
    }
    }