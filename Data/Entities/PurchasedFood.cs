﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PurchasedFood
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchasedDrinksID { get; set; }
        public int PurchaseID { get; set; }
        public int FoodID { get; set; }
        //decimal Price { get; set; }
    }
}