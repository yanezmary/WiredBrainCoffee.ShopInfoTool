﻿using System;
using System.Collections.Generic;
using System.Text;
using WiredBrainCoffee.DatAccess.Model;

namespace WiredBrainCoffee.DatAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop
            {
                Location = "Frankfurt",
                BeansInStockInKg = 107,
                PaperCupInStock = 350
            };
            yield return new CoffeeShop
            {
                Location = "Freiburg",
                BeansInStockInKg = 23,
                PaperCupInStock = 250
            };
            yield return new CoffeeShop
            {
                Location = "Munich",
                BeansInStockInKg = 56,
                PaperCupInStock = 427
            };
        }
       
    }
}
