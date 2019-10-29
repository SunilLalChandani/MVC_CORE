using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Migrations
{
    public partial class initals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    categoryName = table.Column<string>(maxLength: 30, nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "drinks",
                columns: table => new
                {
                    drinkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    drinkName = table.Column<string>(maxLength: 30, nullable: true),
                    shortDescription = table.Column<string>(maxLength: 100, nullable: true),
                    DetailDescription = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    storage = table.Column<int>(nullable: false),
                    Photo = table.Column<string>(nullable: false),
                    thumbnail = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    inStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drinks", x => x.drinkId);
                    table.ForeignKey(
                        name: "FK_drinks_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_drinks_CategoryId",
                table: "drinks",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drinks");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
