using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MenuDbContext : DbContext
    {
        public MenuDbContext() : base("MenuDbContext")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchasedDrink> PurchasedDrinks { get; set; }
        public DbSet<PurchasedFood> PurchasedFoods { get; set; }
    }
}
