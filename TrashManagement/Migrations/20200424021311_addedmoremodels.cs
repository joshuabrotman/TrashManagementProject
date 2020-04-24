using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashManagement.Migrations
{
    public partial class addedmoremodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31f56f20-7b98-43f0-b1b4-648b401261a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57ab6937-3ffd-49de-9da4-abc9b7d6ddfb");

            migrationBuilder.CreateTable(
                name: "Pickup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeScheduled = table.Column<DateTime>(nullable: false),
                    TimeCompleted = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pickup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pickup_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pickup_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suspend",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuspendStart = table.Column<DateTime>(nullable: false),
                    SuspendEnd = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suspend_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c098cd0-8161-45e2-b9ef-f665822db8c2", "c8c7694d-eef8-46ae-95e1-adbdd401a029", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cad51a30-b916-403b-a8f0-20ae696e89b4", "ab68969d-7941-4362-83f2-fed616a36e18", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Pickup_CustomerId",
                table: "Pickup",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pickup_EmployeeId",
                table: "Pickup",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Suspend_CustomerId",
                table: "Suspend",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pickup");

            migrationBuilder.DropTable(
                name: "Suspend");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c098cd0-8161-45e2-b9ef-f665822db8c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cad51a30-b916-403b-a8f0-20ae696e89b4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31f56f20-7b98-43f0-b1b4-648b401261a2", "24597455-27d8-478c-81c8-3ba33577c0fa", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57ab6937-3ffd-49de-9da4-abc9b7d6ddfb", "16c1780f-a02b-4ba9-bad3-ced46571bf35", "Employee", "EMPLOYEE" });
        }
    }
}
