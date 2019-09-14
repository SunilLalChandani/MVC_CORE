using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models.Interface;

namespace MyApp.Controllers
{
    public class DrinkController : Controller
    {
        public readonly IdrinkRepo _idrinkRepo;
        public readonly ICategoryRepo _categoryRepo;

        public DrinkController(IdrinkRepo idrinkRepo,ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
            _idrinkRepo = idrinkRepo;
        }

        public IActionResult List()
        {
            var drink_list = _idrinkRepo.drinks;
            return View(drink_list);
        }
        public IActionResult Index() {
            return View();
        }
    }
}