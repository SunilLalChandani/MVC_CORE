﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApp.Models.Context;

namespace MyApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyApp.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName")
                        .HasMaxLength(30);

                    b.Property<string>("description");

                    b.HasKey("categoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new { categoryId = 1, categoryName = "Beer", description = "Beer has 8% alcohol" }
                    );
                });

            modelBuilder.Entity("MyApp.Models.drinks", b =>
                {
                    b.Property<int>("drinkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("DetailDescription");

                    b.Property<string>("Photo")
                        .IsRequired();

                    b.Property<string>("drinkName")
                        .HasMaxLength(30);

                    b.Property<bool>("inStock");

                    b.Property<int>("price");

                    b.Property<string>("shortDescription")
                        .HasMaxLength(100);

                    b.Property<int>("storage");

                    b.Property<string>("thumbnail");

                    b.HasKey("drinkId");

                    b.HasIndex("CategoryId");

                    b.ToTable("drinks");

                    b.HasData(
                        new { drinkId = 1, CategoryId = 1, Photo = "https://cheers.com.np/uploads/products/978328434466665691222391259197415673358.png", drinkName = "Bira white", inStock = true, price = 0, storage = 0 },
                        new { drinkId = 2, CategoryId = 1, Photo = "https://media.danmurphys.com.au/dmo/product/23100-1.png", drinkName = "Carlsburg", inStock = true, price = 0, storage = 0 },
                        new { drinkId = 3, CategoryId = 1, Photo = "https://www.trzcacak.rs/myfile/detail/37-373891_next-corona-beer-bottle-png.png", drinkName = "Corona", inStock = true, price = 0, storage = 0 }
                    );
                });

            modelBuilder.Entity("MyApp.Models.drinks", b =>
                {
                    b.HasOne("MyApp.Models.Category", "Category")
                        .WithMany("drinks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
