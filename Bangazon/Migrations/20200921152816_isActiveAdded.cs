using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class isActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "395b3353-0cf7-4ba1-9163-92432b27b5c3", "AQAAAAEAACcQAAAAEF8OZXOkeloP/kfaHeRY/l1N0fypaBcrK0u9s1sP1gGkD5tT02sIPKE8aRmDXULZTQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49cc80e0-9f33-408b-8443-7a7d81a1513e", "AQAAAAEAACcQAAAAELQJYea8nGhKPd83XrLyuSKt8+yx+riHXZ6a17ZvVuSnz/c3Q0s8gUKsLrB6+3BK9w==" });
        }
    }
}
