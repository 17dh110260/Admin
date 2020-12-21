using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeShopping.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e4b0354-69eb-4b9f-955d-8ead3b911aec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68f56f0c-1cd2-498c-aa95-73e9c97c2d57");

            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductName",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ProductImage",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "68f56f0c-1cd2-498c-aa95-73e9c97c2d57", "c3a52a38-2a38-439e-b097-a06bbd93844b", "Visitor", "VISITOR" },
                    { "1e4b0354-69eb-4b9f-955d-8ead3b911aec", "af33f1bc-32cd-43ab-9e02-4bfc2aa5fbdf", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 40, 3, 430, DateTimeKind.Local).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 40, 3, 432, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 40, 3, 432, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2020, 11, 19, 10, 40, 3, 432, DateTimeKind.Local).AddTicks(788));
        }
    }
}
