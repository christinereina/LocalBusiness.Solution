using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Hours", "Name", "Rating", "ServicesOffered", "Type" },
                values: new object[,]
                {
                    { 1, "1234 Camphor St.", "10 AM - 5 PM", "Totoro's Seeds & Trees", "5", "Planting Services", "Nursery" },
                    { 2, "44 Jiji Rd", "7 AM - 12 PM", "Kiki's Delivery Service", "5", "Broomstick Delivery, Cleaning Service", "Delivery" },
                    { 3, "7853 Sen Lane", "24/7", "Yubaba's BathHouse", "2", "Spirit Relaxation, Cleaning and Luxury Pampering", "Bathhouse" },
                    { 4, "Seaside Cliff", "6 AM - 10 PM", "Ponyo & Sōsuke Boat Rental", "5", "Boat Rental, Boat Repair", "Boating" },
                    { 5, "", "6757 Gina Lane", "Hotel Adriano", "4", "Nightly Accommodations", "Hotel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);
        }
    }
}
