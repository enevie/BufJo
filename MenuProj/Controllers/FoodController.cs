using Data;
using Data.EnumsCategories;
using MenuProj.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuProj.Controllers
{
    public class FoodController : Controller
    {
        private MenuDbContext _db;

        public FoodController()
        {
            this._db = new MenuDbContext();
        }

        // GET: Food
        public ActionResult Index()
        {
            var types = Enum.GetNames(typeof(FoodTypes));
            var model = new FoodTypesViewModel() { FoodTypes = types };
            return View(model);
        }

        public ActionResult Chicken()
        {
            var food = _db.Foods.Where(x => x.FoodType == FoodTypes.Chicken)
                                .Select(y=> new ChickenFoodSingleViewModel
                                          {
                                              Description = y.Description,
                                              Price = y.Price,
                                              Name = y.Name
                                          }).ToList();

            var model = new ChikenFoodViewModel();

            model.ChickenFood = food;

            return View(model);
        }
    }
}