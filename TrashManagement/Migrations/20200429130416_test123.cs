using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class test123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12175e2c-3296-4b74-9251-0993f3d95b5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81843d5d-eeb5-4122-a473-90d30dd694c6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5f7e2e8b-fab0-470d-aafc-c816ad175968", "eed9638d-e113-4dac-aca6-1f8b3ed7f938", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ee5b5e72-0e57-459a-94fd-0724a40fdd5e", "ef962efa-10ea-4b6d-93bd-5c838ba54f99", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f7e2e8b-fab0-470d-aafc-c816ad175968");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee5b5e72-0e57-459a-94fd-0724a40fdd5e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12175e2c-3296-4b74-9251-0993f3d95b5b", "ac573cad-b22d-4573-9c33-db83fa1f2d19", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81843d5d-eeb5-4122-a473-90d30dd694c6", "d59bbea2-1557-4f3c-b02f-9c7ea1c106df", "Employee", "EMPLOYEE" });
        }
    }
}
