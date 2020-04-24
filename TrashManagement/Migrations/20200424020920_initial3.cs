using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f5ae7f6-4029-40da-ab50-866a08ecc4ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ade454cd-b14c-4ac5-a215-0a99e01f2763");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2993c9c-d2c2-4ae0-80c6-a9400f5356bd", "ccf93dbe-ae7f-4458-bfc0-cd115aef9d27", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cce1c001-f3fb-42c6-a290-7591294197fb", "6958a3e0-25ed-4e89-a14c-5e595a66b523", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2993c9c-d2c2-4ae0-80c6-a9400f5356bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cce1c001-f3fb-42c6-a290-7591294197fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f5ae7f6-4029-40da-ab50-866a08ecc4ec", "c84c6260-f3ef-4fc6-874f-985e450a6133", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ade454cd-b14c-4ac5-a215-0a99e01f2763", "6bbd84c9-f765-4148-837c-82cc94463f10", "Employee", "EMPLOYEE" });
        }
    }
}
