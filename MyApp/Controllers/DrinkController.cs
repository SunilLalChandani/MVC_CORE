using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models.Interface;
using MyApp.Models.ViewModel;

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
            DrinkListViewModel drinkListViewModel = new DrinkListViewModel();
            drinkListViewModel.drinks = _idrinkRepo.drinks;
            
            return View(drinkListViewModel);
         }
        public IActionResult Index() {
            return View();
        }
    }
}