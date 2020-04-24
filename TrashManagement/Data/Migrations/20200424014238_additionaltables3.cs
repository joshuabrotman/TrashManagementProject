using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Data.Migrations
{
    public partial class additionaltables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0c8071fa-d95f-48e7-87e9-119d00769bb2", "75cda003-003f-4a8d-b756-b25820d40615", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8d90695-b673-428b-a321-880ef6037bd9", "e4b5b98d-5c76-4722-9c62-9146499dfaed", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c8071fa-d95f-48e7-87e9-119d00769bb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8d90695-b673-428b-a321-880ef6037bd9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d061399a-62bf-4377-b2d5-e3e1da86e7de", "0f8d1900-3737-442e-90fa-38b9fc89a7f9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "89a2dba8-337d-4d8b-93f5-8e775a8cee3f", "26a9adea-a0e1-43b4-82dc-c77f4b05e221", "Employee", "EMPLOYEE" });
        }
    }
}
