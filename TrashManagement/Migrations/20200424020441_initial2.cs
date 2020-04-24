using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "624b2a53-2891-4047-a5ba-4abc5cd7e159");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f62181e2-4573-4400-a58f-f7ecef11023c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f5ae7f6-4029-40da-ab50-866a08ecc4ec", "c84c6260-f3ef-4fc6-874f-985e450a6133", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ade454cd-b14c-4ac5-a215-0a99e01f2763", "6bbd84c9-f765-4148-837c-82cc94463f10", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f62181e2-4573-4400-a58f-f7ecef11023c", "794f2894-a688-492c-9924-c268f66331aa", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "624b2a53-2891-4047-a5ba-4abc5cd7e159", "3d3b4040-dc04-441f-8359-a16576da4c7a", "Employee", "EMPLOYEE" });
        }
    }
}
