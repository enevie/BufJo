using Data;
using Data.EnumsCategories;
using MenuProj.Models.Food;
using System;
using System.Collections.Generic;
using PagedList.Mvc;
using PagedList;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Entities;

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

        [HttpGet]
        public ActionResult Chicken(int page = 1, int pageSize = 11)
        {
            var food = _db.Foods.Where(x => x.FoodType == FoodTypes.Chicken).OrderByDescending(x=>x.Name);

            var model = new PagedList<Food>(food, page, pageSize);

            return View(model);
        }

    }
}