using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeShopping.Migrations
{
    public partial class addStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01ca9ae9-4346-407d-aec5-57b0484825e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c994d7c7-956f-44ea-a242-046e4bef0697");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "OrderDetails",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "39b99083-f75d-4ce1-948f-26639779c22c", "88218560-5fbb-4938-b4b7-caa30b950d48", "Visitor", "VISITOR" },
                    { "3dc7af9b-0c36-4829-a8a6-8736fffd369f", "f6477788-79f7-4a7a-ae04-73d82a2956a7", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 51, 1, 139, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 51, 1, 140, DateTimeKind.Local).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 51, 1, 140, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 51, 1, 140, DateTimeKind.Local).AddTicks(1510));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39b99083-f75d-4ce1-948f-26639779c22c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc7af9b-0c36-4829-a8a6-8736fffd369f");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OrderDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01ca9ae9-4346-407d-aec5-57b0484825e9", "3aa7c57e-6023-4837-b574-c0fb569de609", "Visitor", "VISITOR" },
                    { "c994d7c7-956f-44ea-a242-046e4bef0697", "9172f92d-3322-4868-a0bc-156be6a2ac5b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 49, 16, 958, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 49, 16, 959, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 49, 16, 959, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 49, 16, 959, DateTimeKind.Local).AddTicks(5015));
        }
    }
}
