using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Migrations
{
    public partial class sunny : Migration
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
