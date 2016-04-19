using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Purchase
    {
        public Purchase()
        {
            PurchasedFood = new HashSet<PurchasedFood>();
            PurchasedDrink = new HashSet<PurchasedDrink>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PurchaseID { get; set; }
        public decimal SumOfThePurchase { get; set; }
        public DateTime DateOfPurchase { get; set; }




        [ForeignKey("PurchaseID")]
        public virtual ICollection<PurchasedFood> PurchasedFood { get; set; }

        [ForeignKey("PurchaseID")]
        public virtual ICollection<PurchasedDrink> PurchasedDrink { get; set; }

    }
}
