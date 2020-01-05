﻿using System;
using WiredBrainCoffee.DatAccess;
using WiredBrainCoffee.DatAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
            Console.WriteLine("Write 'help' to list available coffee shops commands");


            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();
                if(string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach(var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }
                }
            }


        }
    }
}
