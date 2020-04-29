using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class updatebudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "005fb73d-28be-4383-ae41-8162ff8f8845");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6a0433-1d55-497a-ab0d-446a6ba031c5");

            migrationBuilder.AddColumn<int>(
                name: "monthlyBalance",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12175e2c-3296-4b74-9251-0993f3d95b5b", "ac573cad-b22d-4573-9c33-db83fa1f2d19", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81843d5d-eeb5-4122-a473-90d30dd694c6", "d59bbea2-1557-4f3c-b02f-9c7ea1c106df", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12175e2c-3296-4b74-9251-0993f3d95b5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81843d5d-eeb5-4122-a473-90d30dd694c6");

            migrationBuilder.DropColumn(
                name: "monthlyBalance",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "005fb73d-28be-4383-ae41-8162ff8f8845", "84c99eea-c99b-49b7-8fd9-0b8134f19cd6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff6a0433-1d55-497a-ab0d-446a6ba031c5", "78480907-f43e-4e7e-ad1b-5b70d8b14ab1", "Employee", "EMPLOYEE" });
        }
    }
}
