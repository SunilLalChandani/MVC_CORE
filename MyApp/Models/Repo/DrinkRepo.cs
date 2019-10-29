using Microsoft.EntityFrameworkCore;
using MyApp.Models.Context;
using MyApp.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Repo
{
    public class DrinkRepo : IdrinkRepo
    {

        private AppDbContext _appDbContext;

        public DrinkRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        IEnumerable<drinks> IdrinkRepo.drinks => _appDbContext.drinks.ToList();
        public IEnumerable<drinks> favDrink => _appDbContext.drinks.Where(f => f.inStock).Include(c => c.Category);

        public drinks GetDrinksById(int id) => _appDbContext.drinks.FirstOrDefault(p => p.drinkId == id);
    }
}
