using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<drinks> drinks { get; set; }
        public virtual DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<drinks>().HasData(new drinks { drinkId = 1,drinkName="Bira white",CategoryId=1,inStock=true,Photo= "https://cheers.com.np/uploads/products/978328434466665691222391259197415673358.png"},
                new drinks { drinkId = 2,drinkName="Carlsburg",CategoryId=1,inStock=true,Photo= "https://media.danmurphys.com.au/dmo/product/23100-1.png" }
                , new drinks { drinkId = 3, drinkName = "Corona", CategoryId = 1, inStock = true, Photo = "https://www.trzcacak.rs/myfile/detail/37-373891_next-corona-beer-bottle-png.png" });

            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 1, categoryName = "Beer", description = "Beer has 8% alcohol" });
        }
    }
}
