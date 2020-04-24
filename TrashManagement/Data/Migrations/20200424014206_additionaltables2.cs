using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Data.Migrations
{
    public partial class additionaltables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "295b6c2a-f8cf-471e-b012-f4b6b34725b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3b46ba7-a1a1-45f7-856d-5e393f623d6d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d061399a-62bf-4377-b2d5-e3e1da86e7de", "0f8d1900-3737-442e-90fa-38b9fc89a7f9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89a2dba8-337d-4d8b-93f5-8e775a8cee3f", "26a9adea-a0e1-43b4-82dc-c77f4b05e221", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89a2dba8-337d-4d8b-93f5-8e775a8cee3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d061399a-62bf-4377-b2d5-e3e1da86e7de");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3b46ba7-a1a1-45f7-856d-5e393f623d6d", "8541dc1d-821b-48f0-8cd9-b0fcf21ea313", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "295b6c2a-f8cf-471e-b012-f4b6b34725b7", "1cfe015c-5641-4ca4-ae68-0ca364f10621", "Employee", "EMPLOYEE" });
        }
    }
}
