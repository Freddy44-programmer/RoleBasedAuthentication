using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoleBasedAuthentication.Migrations
{
    /// <inheritdoc />
    public partial class SecondMagration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1aa240a-a278-45f3-83db-c0ab367adab1", null, "seller", "seller" },
                    { "db1dfba8-aa3a-467e-827d-d51aab3e5c51", null, "client", "client" },
                    { "dfd41d97-9d87-443a-b4fc-b1fd812d082b", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1aa240a-a278-45f3-83db-c0ab367adab1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db1dfba8-aa3a-467e-827d-d51aab3e5c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfd41d97-9d87-443a-b4fc-b1fd812d082b");
        }
    }
}
