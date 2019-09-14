using MyApp.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Mock
{
    public class MockCateogryRepo : ICategoryRepo
    {
        public IEnumerable<Category> categories
        {
            get {
                return new List<Category> {
                    new Category {
                        categoryId = 1, categoryName = "Rum", description = "white rum, good in mountains"
                                }
                    , new Category {
                        categoryId = 2, categoryName = "Beer", description = "beer is good for bones and hairs"
                                }

            }; } set => throw new NotImplementedException(); }
    }
}
