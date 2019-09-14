using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Interface
{
    public interface IdrinkRepo
    {
         IEnumerable<drinks> drinks { get; set; }
        IEnumerable<drinks> favDrink { get; set; }

        drinks GetDrinksById(int id);

    }
}
