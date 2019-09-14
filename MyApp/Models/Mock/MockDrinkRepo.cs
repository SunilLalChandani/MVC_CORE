using MyApp.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Mock
{
    public class MockDrinkRepo : IdrinkRepo
    {
        public IEnumerable<drinks> drinks {
            get {
                return new List<drinks> {
                    new drinks { drinkId=1,drinkName="Bira",inStock=true,price=100,shortDescription="pint 330ml ,white bira",thumbnail="",CategoryId=2,Photo="https://cheers.com.np/uploads/products/978328434466665691222391259197415673358.png"},

                    new drinks { drinkId=2,drinkName="budwiser",inStock=true,price=120,shortDescription="pint 330ml ,budwiser magnum",thumbnail="",CategoryId=2,Photo="https://www.pngfind.com/pngs/m/230-2306616_budweiser-clipart-budweiser-beer-beer-can-and-bottle.png"}
                    ,  new drinks { drinkId=3,drinkName="CORONA",inStock=true,price=120,shortDescription="pint 330ml ,CORONA LEMON",thumbnail="",CategoryId=2,Photo="https://www.pngfind.com/pngs/m/230-2306616_budweiser-clipart-budweiser-beer-beer-can-and-bottle.png"}

                }; } set => throw new NotImplementedException(); }
        public IEnumerable<drinks> favDrink { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public drinks GetDrinksById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
