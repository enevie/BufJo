using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Entities;
using Data.EnumsCategories;

namespace MenuProj.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            var _db = new MenuDbContext();
            _db.Foods.Add(new Food
            {
                Name = "Tariaki",
                Vegetarian = false,
                Calories = 100,
                FoodType = FoodTypes.Chicken,
                Grammage = 350,
                Price = 3.50M,
            });

            _db.Drinks.Add(new Drink
            {
                Name = "Coca-Cola",
                Calories = 250,
                Alcoholic = false,
                Grammage = 250,
                Price = 1.50M,
                DrinkType = DrinkTypes.Other,
            });

            //_db.Purchases.Add(new Purchase()
            //{
            //    DateOfPurchase = DateTime.Now,
            //    PurchasedDrink = new List<PurchasedDrink>
            //    {
            //        new PurchasedDrink
            //        {
            //            DrinkID = 1,
            //        }
            //    },
            //    PurchasedFood = new List<PurchasedFood>
            //    {
            //            new PurchasedFood
            //            {
            //                FoodID = 1
            //            },
            //            new PurchasedFood
            //            {
            //                FoodID = 2
            //            }
            //    },
            //});

            //var currPur = _db.Purchases.FirstOrDefault(x => x.PurchaseID == 2);
            //var a = currPur.PurchasedFood.Select(x => x.FoodID);
            //var b = currPur.PurchasedDrink.Select(x => x.DrinkID);

            //decimal sum = 0;

            //sum += _db.Foods.Where(x => a.Contains(x.FoodID)).Select(x => x.Price).Sum();
            //sum += _db.Drinks.Where(x => b.Contains(x.DrinkID)).Select(x => x.Price).Sum();

            //currPur.SumOfThePurchase = sum;

            _db.SaveChanges();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}