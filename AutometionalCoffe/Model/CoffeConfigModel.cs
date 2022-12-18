﻿using System.Collections.Generic;

namespace AutometionalCoffee.Model
{
    public class CoffeeConfigModel
    {
        public string Name { get; set; }

        public int Cost { get; set; }

        public int WaterCount { get; set; }

        public int SugarValue { get; set; }

        public int CoffeeCount { get; set; }

        public int MilkCount { get; set; }

        public int ChocolatrCount { get; set; }

        public List<string> CoffeeActions { get; set; }
    }
}
