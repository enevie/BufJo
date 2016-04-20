using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuProj.Models.Food
{
    public class ChikenFoodViewModel
    {
        public IEnumerable<ChickenFoodSingleViewModel> ChickenFood { get; set; }
    }
}