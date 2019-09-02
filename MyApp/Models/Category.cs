using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Category
    {   [Required]
        public int categoryId { get; set; }
        [MaxLength(30)]
        public string categoryName { get; set; }
        public string description { get; set; }
        public IEnumerable<drinks> drinks { get; set; }
        public string cat;
    }
}
