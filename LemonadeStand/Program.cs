using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Player player = new Player();
            Weather weather = new Weather();

            player.BuySugar();
            player.BuyLemons();
            player.BuyIce();
            player.BuyCups();

            weather.GetCondition();
        }
    }
}
