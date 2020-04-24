using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Data.Migrations
{
    public partial class additionaltables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00e69852-0ee1-4818-a98b-c86d40226b14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e683044d-c1c7-4300-bf98-0be77caa9747");

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3b46ba7-a1a1-45f7-856d-5e393f623d6d", "8541dc1d-821b-48f0-8cd9-b0fcf21ea313", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "295b6c2a-f8cf-471e-b012-f4b6b34725b7", "1cfe015c-5641-4ca4-ae68-0ca364f10621", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "295b6c2a-f8cf-471e-b012-f4b6b34725b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3b46ba7-a1a1-45f7-856d-5e393f623d6d");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00e69852-0ee1-4818-a98b-c86d40226b14", "393bf390-9efa-45c4-8972-c93e32d2e9dc", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e683044d-c1c7-4300-bf98-0be77caa9747", "e5d6940f-7fb5-4136-999e-469ad54a1eab", "Employee", "EMPLOYEE" });
        }
    }
}
