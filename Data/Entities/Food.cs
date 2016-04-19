using Data.Entities.Base;
using Data.EnumsCategories;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Food : BaseEntity
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodID { get; set; }
        public FoodTypes FoodType { get; set; }
        public bool Vegetarian { get; set; }

        [ForeignKey("FoodID")]
        public virtual ICollection<PurchasedFood> PurchasedItems { get; set; }
    }
}
