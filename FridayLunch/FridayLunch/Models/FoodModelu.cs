using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FridayLunch.Models
{
    public class FoodMenu
    {
        public string MainDish { get; set; }
        public bool IsIncludedSideDish { get; set; }
        public string SideDish { get; set; }
        public string Soup { get; set; }
        public bool IsIncludedDrink { get; set; }
        public string Drink { get; set; }
        
    }
}