using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class AddingLocalPickup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LocalPickup",
                table: "Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71758d9a-4223-483c-8237-662d354c7994", "AQAAAAEAACcQAAAAEOfC7Y/T7vpHkQeWaPtjF3/M5BfYPqTzUeKmFh2b6nPLicpbkl437jKVsCuCI2/SGA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalPickup",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "460dbe62-19bf-4074-a583-0b73b6da177d", "AQAAAAEAACcQAAAAECgp0NaBhQ4BKSlgCnrwupvAF5lqy1cUmqDEkR00gCxrQ7MZNmMYqZRdnv4o7id4eg==" });
        }
    }
}
