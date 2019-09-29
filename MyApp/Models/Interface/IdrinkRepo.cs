using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Interface
{
    public interface IdrinkRepo
    {
         IEnumerable<drinks> drinks { get; }
        IEnumerable<drinks> favDrink { get; }

        drinks GetDrinksById(int id);

    }
}
