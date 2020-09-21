using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class AddingBooleanToPaymentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PaymentType",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49cc80e0-9f33-408b-8443-7a7d81a1513e", "AQAAAAEAACcQAAAAELQJYea8nGhKPd83XrLyuSKt8+yx+riHXZ6a17ZvVuSnz/c3Q0s8gUKsLrB6+3BK9w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PaymentType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "460dbe62-19bf-4074-a583-0b73b6da177d", "AQAAAAEAACcQAAAAECgp0NaBhQ4BKSlgCnrwupvAF5lqy1cUmqDEkR00gCxrQ7MZNmMYqZRdnv4o7id4eg==" });
        }
    }
}
