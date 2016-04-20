using Data.EnumsCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuProj.Models.Food
{
    public class FoodTypesViewModel
    {
        public IEnumerable<string> FoodTypes { get; set; }
    }
}