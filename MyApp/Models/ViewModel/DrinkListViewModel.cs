using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.ViewModel
{
    public class DrinkListViewModel
    {
        public IEnumerable<drinks> drinks { get; set; }
        public string currentCategory { get; set; }
    }
}
