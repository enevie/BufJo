using Data.Entities.Base;
using Data.EnumsCategories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Drink : BaseEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DrinkID { get; set; }
        public DrinkTypes DrinkType { get; set; }
        public bool Alcoholic { get; set; }

        [ForeignKey("DrinkID")]
        public virtual ICollection<PurchasedDrink> PurchasedDrinks { get; set; }
    }
}
