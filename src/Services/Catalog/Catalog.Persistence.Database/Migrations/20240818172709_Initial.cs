using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "ProductsProducts",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsProducts", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_ProductsProducts_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "ProductsProducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "ProductsProducts",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product  1", "Product 1", 889m },
                    { 2, "Description for product  2", "Product 2", 531m },
                    { 3, "Description for product  3", "Product 3", 705m },
                    { 4, "Description for product  4", "Product 4", 220m },
                    { 5, "Description for product  5", "Product 5", 824m },
                    { 6, "Description for product  6", "Product 6", 680m },
                    { 7, "Description for product  7", "Product 7", 909m },
                    { 8, "Description for product  8", "Product 8", 450m },
                    { 9, "Description for product  9", "Product 9", 701m },
                    { 10, "Description for product  10", "Product 10", 507m },
                    { 11, "Description for product  11", "Product 11", 863m },
                    { 12, "Description for product  12", "Product 12", 469m },
                    { 13, "Description for product  13", "Product 13", 767m },
                    { 14, "Description for product  14", "Product 14", 656m },
                    { 15, "Description for product  15", "Product 15", 721m },
                    { 16, "Description for product  16", "Product 16", 362m },
                    { 17, "Description for product  17", "Product 17", 424m },
                    { 18, "Description for product  18", "Product 18", 354m },
                    { 19, "Description for product  19", "Product 19", 124m },
                    { 20, "Description for product  20", "Product 20", 806m },
                    { 21, "Description for product  21", "Product 21", 939m },
                    { 22, "Description for product  22", "Product 22", 915m },
                    { 23, "Description for product  23", "Product 23", 944m },
                    { 24, "Description for product  24", "Product 24", 354m },
                    { 25, "Description for product  25", "Product 25", 861m },
                    { 26, "Description for product  26", "Product 26", 989m },
                    { 27, "Description for product  27", "Product 27", 700m },
                    { 28, "Description for product  28", "Product 28", 481m },
                    { 29, "Description for product  29", "Product 29", 957m },
                    { 30, "Description for product  30", "Product 30", 436m },
                    { 31, "Description for product  31", "Product 31", 691m },
                    { 32, "Description for product  32", "Product 32", 489m },
                    { 33, "Description for product  33", "Product 33", 702m },
                    { 34, "Description for product  34", "Product 34", 454m },
                    { 35, "Description for product  35", "Product 35", 711m },
                    { 36, "Description for product  36", "Product 36", 633m },
                    { 37, "Description for product  37", "Product 37", 953m },
                    { 38, "Description for product  38", "Product 38", 646m },
                    { 39, "Description for product  39", "Product 39", 669m },
                    { 40, "Description for product  40", "Product 40", 662m },
                    { 41, "Description for product  41", "Product 41", 906m },
                    { 42, "Description for product  42", "Product 42", 495m },
                    { 43, "Description for product  43", "Product 43", 422m },
                    { 44, "Description for product  44", "Product 44", 611m },
                    { 45, "Description for product  45", "Product 45", 889m },
                    { 46, "Description for product  46", "Product 46", 104m },
                    { 47, "Description for product  47", "Product 47", 813m },
                    { 48, "Description for product  48", "Product 48", 915m },
                    { 49, "Description for product  49", "Product 49", 908m },
                    { 50, "Description for product  50", "Product 50", 130m },
                    { 51, "Description for product  51", "Product 51", 886m },
                    { 52, "Description for product  52", "Product 52", 394m },
                    { 53, "Description for product  53", "Product 53", 724m },
                    { 54, "Description for product  54", "Product 54", 629m },
                    { 55, "Description for product  55", "Product 55", 280m },
                    { 56, "Description for product  56", "Product 56", 962m },
                    { 57, "Description for product  57", "Product 57", 763m },
                    { 58, "Description for product  58", "Product 58", 217m },
                    { 59, "Description for product  59", "Product 59", 480m },
                    { 60, "Description for product  60", "Product 60", 547m },
                    { 61, "Description for product  61", "Product 61", 232m },
                    { 62, "Description for product  62", "Product 62", 688m },
                    { 63, "Description for product  63", "Product 63", 689m },
                    { 64, "Description for product  64", "Product 64", 583m },
                    { 65, "Description for product  65", "Product 65", 211m },
                    { 66, "Description for product  66", "Product 66", 778m },
                    { 67, "Description for product  67", "Product 67", 678m },
                    { 68, "Description for product  68", "Product 68", 797m },
                    { 69, "Description for product  69", "Product 69", 865m },
                    { 70, "Description for product  70", "Product 70", 301m },
                    { 71, "Description for product  71", "Product 71", 444m },
                    { 72, "Description for product  72", "Product 72", 166m },
                    { 73, "Description for product  73", "Product 73", 130m },
                    { 74, "Description for product  74", "Product 74", 397m },
                    { 75, "Description for product  75", "Product 75", 485m },
                    { 76, "Description for product  76", "Product 76", 784m },
                    { 77, "Description for product  77", "Product 77", 436m },
                    { 78, "Description for product  78", "Product 78", 230m },
                    { 79, "Description for product  79", "Product 79", 368m },
                    { 80, "Description for product  80", "Product 80", 490m },
                    { 81, "Description for product  81", "Product 81", 769m },
                    { 82, "Description for product  82", "Product 82", 625m },
                    { 83, "Description for product  83", "Product 83", 568m },
                    { 84, "Description for product  84", "Product 84", 504m },
                    { 85, "Description for product  85", "Product 85", 318m },
                    { 86, "Description for product  86", "Product 86", 842m },
                    { 87, "Description for product  87", "Product 87", 975m },
                    { 88, "Description for product  88", "Product 88", 375m },
                    { 89, "Description for product  89", "Product 89", 303m },
                    { 90, "Description for product  90", "Product 90", 638m },
                    { 91, "Description for product  91", "Product 91", 177m },
                    { 92, "Description for product  92", "Product 92", 699m },
                    { 93, "Description for product  93", "Product 93", 453m },
                    { 94, "Description for product  94", "Product 94", 358m },
                    { 95, "Description for product  95", "Product 95", 105m },
                    { 96, "Description for product  96", "Product 96", 601m },
                    { 97, "Description for product  97", "Product 97", 484m },
                    { 98, "Description for product  98", "Product 98", 352m },
                    { 99, "Description for product  99", "Product 99", 739m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductsProducts_ProductId",
                schema: "Catalog",
                table: "ProductsProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductInStockId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ProductsProducts",
                schema: "Catalog");
        }
    }
}
