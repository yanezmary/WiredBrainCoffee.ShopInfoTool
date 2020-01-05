using System;
using System.Linq;
using WiredBrainCoffee.DatAccess;
using WiredBrainCoffee.DatAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
            Console.WriteLine("Write 'help' to list available coffee shops commands, " +
                "write 'quit' to exit application");


            var coffeeShopDataProvider = new CoffeeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

                ICommandHandler commandHandler =
                string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
                ? new HelpCommandHandler(coffeeShops) as ICommandHandler
                : new CoffeeShopCommandHandler(coffeeShops, line);

                commandHandler.HandleCommand();
            }

        }
    }
}
