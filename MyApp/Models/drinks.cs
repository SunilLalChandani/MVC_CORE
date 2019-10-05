using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class drinks
    {
        [Required]
        [Key]
        public int drinkId { get; set; }
        [MaxLength(30)]
        public string drinkName { get; set; }
        [MaxLength(100)]
        public string shortDescription { get; set; }
        [MaxLength]
        public string DetailDescription { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int storage { get; set; }
        // public IFormFile Photo { get; set; }
        [Required]
        public string Photo { get; set; }
        public string thumbnail { get; set; }

        public int CategoryId { get; set; }
        public bool inStock { get; set; }
        public virtual Category Category { get; set; }
    }
}
