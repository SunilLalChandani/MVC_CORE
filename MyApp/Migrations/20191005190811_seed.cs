using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "categoryId", "categoryName", "description" },
                values: new object[] { 1, "Beer", "Beer has 8% alcohol" });

            migrationBuilder.InsertData(
                table: "drinks",
                columns: new[] { "drinkId", "CategoryId", "DetailDescription", "Photo", "drinkName", "inStock", "price", "shortDescription", "storage", "thumbnail" },
                values: new object[] { 1, 1, null, "https://cheers.com.np/uploads/products/978328434466665691222391259197415673358.png", "Bira white", true, 0, null, 0, null });

            migrationBuilder.InsertData(
                table: "drinks",
                columns: new[] { "drinkId", "CategoryId", "DetailDescription", "Photo", "drinkName", "inStock", "price", "shortDescription", "storage", "thumbnail" },
                values: new object[] { 2, 1, null, "https://media.danmurphys.com.au/dmo/product/23100-1.png", "Carlsburg", true, 0, null, 0, null });

            migrationBuilder.InsertData(
                table: "drinks",
                columns: new[] { "drinkId", "CategoryId", "DetailDescription", "Photo", "drinkName", "inStock", "price", "shortDescription", "storage", "thumbnail" },
                values: new object[] { 3, 1, null, "https://www.trzcacak.rs/myfile/detail/37-373891_next-corona-beer-bottle-png.png", "Corona", true, 0, null, 0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "drinks",
                keyColumn: "drinkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "drinks",
                keyColumn: "drinkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "drinks",
                keyColumn: "drinkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "categoryId",
                keyValue: 1);
        }
    }
}
