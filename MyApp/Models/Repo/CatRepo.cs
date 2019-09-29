using MyApp.Models.Context;
using MyApp.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Repo
{
    public class CatRepo : ICategoryRepo
    {
        private readonly AppDbContext appDbContext;

        public CatRepo(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        IEnumerable<Category> ICategoryRepo.categories => appDbContext.categories;
    }
}
