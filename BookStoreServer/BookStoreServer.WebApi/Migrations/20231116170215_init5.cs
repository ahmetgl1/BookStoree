using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 12, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 14, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 15, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 26, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 31, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 33, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 38, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 39, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 41, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 42, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 43, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 44, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 48, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 50, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 51, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 52, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 54, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 56, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 57, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 58, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 59, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 61, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 62, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 63, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 64, 8 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 65, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 68, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 69, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 70, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 71, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 72, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 73, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 74, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 75, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 76, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 77, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 78, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 80, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 81, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 82, 10 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 84, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 87, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 88, 9 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 89, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 90, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 91, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 93, 1 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 94, 2 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 95, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 96, 5 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 97, 6 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 98, 4 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 99, 7 });

            migrationBuilder.DeleteData(
                table: "BookCategories",
                keyColumns: new[] { "BookId", "CategoryId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Books",
                newName: "Price_Value");

            migrationBuilder.AddColumn<string>(
                name: "Price_Currency",
                table: "Books",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price_Currency",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Price_Value",
                table: "Books",
                newName: "Price");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImageUrl", "CreateAt", "ISBN", "IsActive", "IsDelete", "Price", "Quantity", "Summary", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(109), "782-454-961-41", true, false, 10m, 10, "Summary1", "Kitap1", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(130) },
                    { 2, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(136), "782-454-961-42", true, false, 20m, 10, "Summary2", "Kitap2", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(139) },
                    { 3, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(144), "782-454-961-43", true, false, 30m, 10, "Summary3", "Kitap3", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(147) },
                    { 4, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(150), "782-454-961-44", true, false, 40m, 10, "Summary4", "Kitap4", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(152) },
                    { 5, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(168), "782-454-961-45", true, false, 50m, 10, "Summary5", "Kitap5", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(170) },
                    { 6, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(175), "782-454-961-46", true, false, 60m, 10, "Summary6", "Kitap6", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(176) },
                    { 7, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(179), "782-454-961-47", true, false, 70m, 10, "Summary7", "Kitap7", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(181) },
                    { 8, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(184), "782-454-961-48", true, false, 80m, 10, "Summary8", "Kitap8", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(185) },
                    { 9, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(187), "782-454-961-49", true, false, 90m, 10, "Summary9", "Kitap9", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(189) },
                    { 10, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(195), "782-454-961-410", true, false, 100m, 10, "Summary10", "Kitap10", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(196) },
                    { 11, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(199), "782-454-961-411", true, false, 110m, 10, "Summary11", "Kitap11", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(201) },
                    { 12, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(204), "782-454-961-412", true, false, 120m, 10, "Summary12", "Kitap12", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(206) },
                    { 13, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(208), "782-454-961-413", true, false, 130m, 10, "Summary13", "Kitap13", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(210) },
                    { 14, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(212), "782-454-961-414", true, false, 140m, 10, "Summary14", "Kitap14", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(214) },
                    { 15, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(216), "782-454-961-415", true, false, 150m, 10, "Summary15", "Kitap15", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(218) },
                    { 16, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(220), "782-454-961-416", true, false, 160m, 10, "Summary16", "Kitap16", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(222) },
                    { 17, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(225), "782-454-961-417", true, false, 170m, 10, "Summary17", "Kitap17", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(226) },
                    { 18, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(231), "782-454-961-418", true, false, 180m, 10, "Summary18", "Kitap18", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(232) },
                    { 19, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(235), "782-454-961-419", true, false, 190m, 10, "Summary19", "Kitap19", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(236) },
                    { 20, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(239), "782-454-961-420", true, false, 200m, 10, "Summary20", "Kitap20", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(240) },
                    { 21, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(243), "782-454-961-421", true, false, 210m, 10, "Summary21", "Kitap21", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(245) },
                    { 22, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(247), "782-454-961-422", true, false, 220m, 10, "Summary22", "Kitap22", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(249) },
                    { 23, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(251), "782-454-961-423", true, false, 230m, 10, "Summary23", "Kitap23", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(253) },
                    { 24, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(255), "782-454-961-424", true, false, 240m, 10, "Summary24", "Kitap24", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(257) },
                    { 25, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(259), "782-454-961-425", true, false, 250m, 10, "Summary25", "Kitap25", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(261) },
                    { 26, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(263), "782-454-961-426", true, false, 260m, 10, "Summary26", "Kitap26", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(266) },
                    { 27, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(268), "782-454-961-427", true, false, 270m, 10, "Summary27", "Kitap27", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(270) },
                    { 28, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(273), "782-454-961-428", true, false, 280m, 10, "Summary28", "Kitap28", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(275) },
                    { 29, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(288), "782-454-961-429", true, false, 290m, 10, "Summary29", "Kitap29", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(291) },
                    { 30, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(293), "782-454-961-430", true, false, 300m, 10, "Summary30", "Kitap30", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(295) },
                    { 31, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(298), "782-454-961-431", true, false, 310m, 10, "Summary31", "Kitap31", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(299) },
                    { 32, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(302), "782-454-961-432", true, false, 320m, 10, "Summary32", "Kitap32", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(303) },
                    { 33, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(306), "782-454-961-433", true, false, 330m, 10, "Summary33", "Kitap33", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(308) },
                    { 34, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(312), "782-454-961-434", true, false, 340m, 10, "Summary34", "Kitap34", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(313) },
                    { 35, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(316), "782-454-961-435", true, false, 350m, 10, "Summary35", "Kitap35", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(318) },
                    { 36, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(320), "782-454-961-436", true, false, 360m, 10, "Summary36", "Kitap36", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(322) },
                    { 37, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(324), "782-454-961-437", true, false, 370m, 10, "Summary37", "Kitap37", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(326) },
                    { 38, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(328), "782-454-961-438", true, false, 380m, 10, "Summary38", "Kitap38", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(330) },
                    { 39, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(332), "782-454-961-439", true, false, 390m, 10, "Summary39", "Kitap39", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(334) },
                    { 40, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(336), "782-454-961-440", true, false, 400m, 10, "Summary40", "Kitap40", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(338) },
                    { 41, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(340), "782-454-961-441", true, false, 410m, 10, "Summary41", "Kitap41", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(342) },
                    { 42, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(344), "782-454-961-442", true, false, 420m, 10, "Summary42", "Kitap42", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(346) },
                    { 43, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(348), "782-454-961-443", true, false, 430m, 10, "Summary43", "Kitap43", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(350) },
                    { 44, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(352), "782-454-961-444", true, false, 440m, 10, "Summary44", "Kitap44", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(354) },
                    { 45, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(356), "782-454-961-445", true, false, 450m, 10, "Summary45", "Kitap45", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(358) },
                    { 46, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(360), "782-454-961-446", true, false, 460m, 10, "Summary46", "Kitap46", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(362) },
                    { 47, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(364), "782-454-961-447", true, false, 470m, 10, "Summary47", "Kitap47", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(366) },
                    { 48, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(368), "782-454-961-448", true, false, 480m, 10, "Summary48", "Kitap48", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(370) },
                    { 49, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(373), "782-454-961-449", true, false, 490m, 10, "Summary49", "Kitap49", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(374) },
                    { 50, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(378), "782-454-961-450", true, false, 500m, 10, "Summary50", "Kitap50", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(379) },
                    { 51, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(382), "782-454-961-451", true, false, 510m, 10, "Summary51", "Kitap51", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(383) },
                    { 52, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(394), "782-454-961-452", true, false, 520m, 10, "Summary52", "Kitap52", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(396) },
                    { 53, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(399), "782-454-961-453", true, false, 530m, 10, "Summary53", "Kitap53", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(401) },
                    { 54, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(404), "782-454-961-454", true, false, 540m, 10, "Summary54", "Kitap54", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(405) },
                    { 55, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(408), "782-454-961-455", true, false, 550m, 10, "Summary55", "Kitap55", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(409) },
                    { 56, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(412), "782-454-961-456", true, false, 560m, 10, "Summary56", "Kitap56", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(413) },
                    { 57, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(416), "782-454-961-457", true, false, 570m, 10, "Summary57", "Kitap57", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(418) },
                    { 58, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(420), "782-454-961-458", true, false, 580m, 10, "Summary58", "Kitap58", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(422) },
                    { 59, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(424), "782-454-961-459", true, false, 590m, 10, "Summary59", "Kitap59", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(426) },
                    { 60, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(428), "782-454-961-460", true, false, 600m, 10, "Summary60", "Kitap60", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(430) },
                    { 61, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(432), "782-454-961-461", true, false, 610m, 10, "Summary61", "Kitap61", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(434) },
                    { 62, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(436), "782-454-961-462", true, false, 620m, 10, "Summary62", "Kitap62", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(438) },
                    { 63, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(440), "782-454-961-463", true, false, 630m, 10, "Summary63", "Kitap63", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(442) },
                    { 64, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(444), "782-454-961-464", true, false, 640m, 10, "Summary64", "Kitap64", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(447) },
                    { 65, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(449), "782-454-961-465", true, false, 650m, 10, "Summary65", "Kitap65", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(451) },
                    { 66, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(458), "782-454-961-466", true, false, 660m, 10, "Summary66", "Kitap66", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(460) },
                    { 67, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(462), "782-454-961-467", true, false, 670m, 10, "Summary67", "Kitap67", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(464) },
                    { 68, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(466), "782-454-961-468", true, false, 680m, 10, "Summary68", "Kitap68", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(468) },
                    { 69, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(470), "782-454-961-469", true, false, 690m, 10, "Summary69", "Kitap69", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(472) },
                    { 70, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(474), "782-454-961-470", true, false, 700m, 10, "Summary70", "Kitap70", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(476) },
                    { 71, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(478), "782-454-961-471", true, false, 710m, 10, "Summary71", "Kitap71", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(480) },
                    { 72, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(482), "782-454-961-472", true, false, 720m, 10, "Summary72", "Kitap72", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(484) },
                    { 73, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(495), "782-454-961-473", true, false, 730m, 10, "Summary73", "Kitap73", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(497) },
                    { 74, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(500), "782-454-961-474", true, false, 740m, 10, "Summary74", "Kitap74", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(503) },
                    { 75, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(505), "782-454-961-475", true, false, 750m, 10, "Summary75", "Kitap75", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(507) },
                    { 76, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(509), "782-454-961-476", true, false, 760m, 10, "Summary76", "Kitap76", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(511) },
                    { 77, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(513), "782-454-961-477", true, false, 770m, 10, "Summary77", "Kitap77", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(515) },
                    { 78, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(517), "782-454-961-478", true, false, 780m, 10, "Summary78", "Kitap78", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(519) },
                    { 79, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(521), "782-454-961-479", true, false, 790m, 10, "Summary79", "Kitap79", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(523) },
                    { 80, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(526), "782-454-961-480", true, false, 800m, 10, "Summary80", "Kitap80", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(528) },
                    { 81, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(530), "782-454-961-481", true, false, 810m, 10, "Summary81", "Kitap81", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(532) },
                    { 82, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(534), "782-454-961-482", true, false, 820m, 10, "Summary82", "Kitap82", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(536) },
                    { 83, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(538), "782-454-961-483", true, false, 830m, 10, "Summary83", "Kitap83", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(540) },
                    { 84, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(542), "782-454-961-484", true, false, 840m, 10, "Summary84", "Kitap84", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(544) },
                    { 85, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(546), "782-454-961-485", true, false, 850m, 10, "Summary85", "Kitap85", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(548) },
                    { 86, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(550), "782-454-961-486", true, false, 860m, 10, "Summary86", "Kitap86", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(552) },
                    { 87, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(555), "782-454-961-487", true, false, 870m, 10, "Summary87", "Kitap87", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(556) },
                    { 88, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(559), "782-454-961-488", true, false, 880m, 10, "Summary88", "Kitap88", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(561) },
                    { 89, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(563), "782-454-961-489", true, false, 890m, 10, "Summary89", "Kitap89", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(565) },
                    { 90, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(567), "782-454-961-490", true, false, 900m, 10, "Summary90", "Kitap90", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(569) },
                    { 91, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(571), "782-454-961-491", true, false, 910m, 10, "Summary91", "Kitap91", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(573) },
                    { 92, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(576), "782-454-961-492", true, false, 920m, 10, "Summary92", "Kitap92", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(578) },
                    { 93, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(580), "782-454-961-493", true, false, 930m, 10, "Summary93", "Kitap93", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(582) },
                    { 94, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(584), "782-454-961-494", true, false, 940m, 10, "Summary94", "Kitap94", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(586) },
                    { 95, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(588), "782-454-961-495", true, false, 950m, 10, "Summary95", "Kitap95", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(590) },
                    { 96, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(592), "782-454-961-496", true, false, 960m, 10, "Summary96", "Kitap96", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(594) },
                    { 97, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(604), "782-454-961-497", true, false, 970m, 10, "Summary97", "Kitap97", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(606) },
                    { 98, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(608), "782-454-961-498", true, false, 980m, 10, "Summary98", "Kitap98", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(610) },
                    { 99, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(612), "782-454-961-499", true, false, 990m, 10, "Summary99", "Kitap99", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(614) },
                    { 100, "Ahmet Güzeller", "http://exprostudio.com/html/book_library/images/books/img-06.jpg", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(617), "782-454-961-4100", true, false, 1000m, 10, "Summary100", "Kitap100", new DateTime(2023, 11, 16, 19, 17, 1, 797, DateTimeKind.Local).AddTicks(620) }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 1 },
                    { 3, 4 },
                    { 4, 2 },
                    { 5, 4 },
                    { 6, 2 },
                    { 7, 5 },
                    { 8, 10 },
                    { 9, 6 },
                    { 10, 6 },
                    { 11, 4 },
                    { 12, 7 },
                    { 13, 9 },
                    { 14, 6 },
                    { 15, 10 },
                    { 16, 2 },
                    { 17, 5 },
                    { 18, 7 },
                    { 19, 8 },
                    { 20, 3 },
                    { 21, 2 },
                    { 22, 5 },
                    { 23, 4 },
                    { 24, 7 },
                    { 25, 5 },
                    { 26, 6 },
                    { 27, 10 },
                    { 28, 8 },
                    { 29, 8 },
                    { 30, 9 },
                    { 31, 1 },
                    { 32, 5 },
                    { 33, 4 },
                    { 34, 1 },
                    { 35, 10 },
                    { 36, 4 },
                    { 37, 5 },
                    { 38, 7 },
                    { 39, 4 },
                    { 40, 1 },
                    { 41, 5 },
                    { 42, 6 },
                    { 43, 4 },
                    { 44, 8 },
                    { 45, 1 },
                    { 46, 4 },
                    { 47, 1 },
                    { 48, 8 },
                    { 49, 3 },
                    { 50, 7 },
                    { 51, 8 },
                    { 52, 9 },
                    { 53, 1 },
                    { 54, 4 },
                    { 55, 3 },
                    { 56, 7 },
                    { 57, 3 },
                    { 58, 9 },
                    { 59, 10 },
                    { 60, 2 },
                    { 61, 9 },
                    { 62, 6 },
                    { 63, 10 },
                    { 64, 8 },
                    { 65, 5 },
                    { 66, 1 },
                    { 67, 1 },
                    { 68, 9 },
                    { 69, 7 },
                    { 70, 7 },
                    { 71, 9 },
                    { 72, 10 },
                    { 73, 9 },
                    { 74, 4 },
                    { 75, 6 },
                    { 76, 3 },
                    { 77, 4 },
                    { 78, 6 },
                    { 79, 2 },
                    { 80, 5 },
                    { 81, 2 },
                    { 82, 10 },
                    { 83, 3 },
                    { 84, 9 },
                    { 85, 1 },
                    { 86, 1 },
                    { 87, 7 },
                    { 88, 9 },
                    { 89, 7 },
                    { 90, 2 },
                    { 91, 7 },
                    { 92, 2 },
                    { 93, 1 },
                    { 94, 2 },
                    { 95, 4 },
                    { 96, 5 },
                    { 97, 6 },
                    { 98, 4 },
                    { 99, 7 },
                    { 100, 4 }
                });
        }
    }
}
