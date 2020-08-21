using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class SeedDataHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Address", "Hours" },
                values: new object[] { "6757 Gina Lane", "Reception Hours: 5 AM - 12 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Address", "Hours" },
                values: new object[] { "", "6757 Gina Lane" });
        }
    }
}
