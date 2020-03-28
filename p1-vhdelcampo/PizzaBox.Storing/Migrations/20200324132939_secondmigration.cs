using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Location",
                keyValue: "S Cooper St");

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Location",
                keyValue: "S West St");

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Location",
                keyValue: "W Mitchell St");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "alex");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "fred");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "isaiah");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "nick");

            migrationBuilder.UpdateData(
                table: "PizzaType",
                keyColumn: "TypeId",
                keyValue: 1L,
                columns: new[] { "Cost", "Crust" },
                values: new object[] { 9.00m, "Regular Crust" });

            migrationBuilder.UpdateData(
                table: "PizzaType",
                keyColumn: "TypeId",
                keyValue: 2L,
                columns: new[] { "Cost", "Crust", "Name" },
                values: new object[] { 12.00m, "Deep Crust", "Meat Lovers" });

            migrationBuilder.UpdateData(
                table: "PizzaType",
                keyColumn: "TypeId",
                keyValue: 3L,
                columns: new[] { "Cost", "Crust", "Name" },
                values: new object[] { 10.00m, "Thin Crust", "Hawaiian Pizza" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 2L,
                column: "Cost",
                value: 9.00m);

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 3L,
                column: "Cost",
                value: 10.00m);

            migrationBuilder.InsertData(
                table: "Store",
                column: "Location",
                values: new object[]
                {
                    "3978 Crispy Road",
                    "2342 Greasy Grove"
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "roby",
                columns: new[] { "Password", "UserType" },
                values: new object[] { "word", "Customer" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Password", "UserType" },
                values: new object[] { "victor", "pass", "Customer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Location",
                keyValue: "2342 Greasy Grove");

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "Location",
                keyValue: "3978 Crispy Road");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "victor");

            migrationBuilder.UpdateData(
                table: "PizzaType",
                keyColumn: "TypeId",
                keyValue: 1L,
                columns: new[] { "Cost", "Crust" },
                values: new object[] { 8.50m, "Cheese Filled Crust" });

            migrationBuilder.UpdateData(
                table: "PizzaType",
                keyColumn: "TypeId",
                keyValue: 2L,
                columns: new[] { "Cost", "Crust", "Name" },
                values: new object[] { 7.00m, "Thin Crust", "Cheese Pizza" });

            migrationBuilder.UpdateData(
                table: "PizzaType",
                keyColumn: "TypeId",
                keyValue: 3L,
                columns: new[] { "Cost", "Crust", "Name" },
                values: new object[] { 10.25m, "Thick Crust", "Pineapple Bacon Pizza" });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 2L,
                column: "Cost",
                value: 10.00m);

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "SizeId",
                keyValue: 3L,
                column: "Cost",
                value: 12.00m);

            migrationBuilder.InsertData(
                table: "Store",
                column: "Location",
                values: new object[]
                {
                    "S Cooper St",
                    "S West St",
                    "W Mitchell St"
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: "roby",
                columns: new[] { "Password", "UserType" },
                values: new object[] { "456", "Admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Password", "UserType" },
                values: new object[,]
                {
                    { "alex", "123", "Customer" },
                    { "isaiah", "234", "Customer" },
                    { "nick", "345", "Customer" },
                    { "fred", "567", "Admin" }
                });
        }
    }
}
