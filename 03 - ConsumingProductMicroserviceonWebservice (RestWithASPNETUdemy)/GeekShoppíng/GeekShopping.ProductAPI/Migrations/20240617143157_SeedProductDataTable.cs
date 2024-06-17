using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { 3L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader", 999.99m },
                    { 4L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars Hasbro", 189.99m },
                    { 5L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m },
                    { 6L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m },
                    { 7L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee", 69.9m },
                    { 8L, "Sweatshirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz", 159.9m },
                    { 9L, "Book", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk", 49.9m },
                    { 10L, "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet", 359.99m },
                    { 11L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk", 59.99m },
                    { 12L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux", 59.99m },
                    { 13L, "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 13L);
        }
    }
}
