using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IamgeFileName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "IamgeFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Carrot Cake Any Description", "carrot_cake.webp", "Carrot Cake", 0m },
                    { 2, "Lemo Tart Any Description", "lemo_tart.webp", "Lemo Tart", 0m },
                    { 3, "Cup Cake Any Description", "cup_cake.webp", "Cup Cake", 0m },
                    { 4, "Mutech Cake Any Description", "carrot_cake.webp", "Mutech Cake", 0m },
                    { 5, "bread Any Description", "bread.webp", "bread", 0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
