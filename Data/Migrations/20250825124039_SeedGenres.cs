using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameStoreApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04075994-f276-4f05-b979-be9e1d79f979"), "Action" },
                    { new Guid("38fc59a2-7530-4f18-8ae6-034016fc9c4f"), "Sports" },
                    { new Guid("42536eca-eb40-485d-b46b-06d37b317efa"), "Racing" },
                    { new Guid("7fcb0a7d-eb7a-4454-a493-eaab14106cc8"), "Adventure" },
                    { new Guid("a7a751d1-2e58-46cf-9504-020dac13f40a"), "Strategy" },
                    { new Guid("d9cca864-5103-4142-8041-08c1fca7b822"), "RPG" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GenreId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0fb7c267-3369-4f48-84f6-b04464f6c728"), new Guid("04075994-f276-4f05-b979-be9e1d79f979"), "Game Action", 100m },
                    { new Guid("188e5a5b-1265-4da6-af67-3360f053fd32"), new Guid("d9cca864-5103-4142-8041-08c1fca7b822"), "Game RPG", 300m },
                    { new Guid("300bd70a-5483-438d-ba79-0f23241df42c"), new Guid("42536eca-eb40-485d-b46b-06d37b317efa"), "Game Racing", 600m },
                    { new Guid("4fa4c6b0-f896-4636-b68a-d37775546476"), new Guid("a7a751d1-2e58-46cf-9504-020dac13f40a"), "Game Strategy", 400m },
                    { new Guid("d25f5b7f-6a30-448e-b477-7dcba2a6aee8"), new Guid("7fcb0a7d-eb7a-4454-a493-eaab14106cc8"), "Game Adventure", 200m },
                    { new Guid("e31d8c36-8efb-468d-bd4a-5ff74f7ba7e5"), new Guid("38fc59a2-7530-4f18-8ae6-034016fc9c4f"), "Game Sports", 500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("0fb7c267-3369-4f48-84f6-b04464f6c728"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("188e5a5b-1265-4da6-af67-3360f053fd32"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("300bd70a-5483-438d-ba79-0f23241df42c"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("4fa4c6b0-f896-4636-b68a-d37775546476"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("d25f5b7f-6a30-448e-b477-7dcba2a6aee8"));

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e31d8c36-8efb-468d-bd4a-5ff74f7ba7e5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("04075994-f276-4f05-b979-be9e1d79f979"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("38fc59a2-7530-4f18-8ae6-034016fc9c4f"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("42536eca-eb40-485d-b46b-06d37b317efa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7fcb0a7d-eb7a-4454-a493-eaab14106cc8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a7a751d1-2e58-46cf-9504-020dac13f40a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d9cca864-5103-4142-8041-08c1fca7b822"));
        }
    }
}
