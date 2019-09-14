using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Interface
{
  public  interface ICategoryRepo
    {
        IEnumerable<Category> categories { get; set; }
    }
}
