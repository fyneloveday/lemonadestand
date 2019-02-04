using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UI
    {




        public static int GetInteger(string prompt)
        {
            Console.WriteLine(prompt);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }
}
