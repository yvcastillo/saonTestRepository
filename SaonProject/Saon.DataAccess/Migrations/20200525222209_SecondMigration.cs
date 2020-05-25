using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Saon.DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "CreatedAt", "Description", "ExpiredAt", "JobTitle" },
                values: new object[] { 1, new DateTime(2020, 5, 25, 16, 22, 9, 13, DateTimeKind.Local).AddTicks(9752), "Descripcion about .net developer", new DateTime(2020, 6, 24, 16, 22, 9, 15, DateTimeKind.Local).AddTicks(183), ".NET Developer" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "CreatedAt", "Description", "ExpiredAt", "JobTitle" },
                values: new object[] { 2, new DateTime(2020, 5, 25, 16, 22, 9, 15, DateTimeKind.Local).AddTicks(662), "Descripcion about QA Analyst", new DateTime(2020, 6, 24, 16, 22, 9, 15, DateTimeKind.Local).AddTicks(676), ".QA Analyst" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "CreatedAt", "Description", "ExpiredAt", "JobTitle" },
                values: new object[] { 3, new DateTime(2020, 5, 25, 16, 22, 9, 15, DateTimeKind.Local).AddTicks(691), "Descripcion about Solution Architec", new DateTime(2020, 6, 24, 16, 22, 9, 15, DateTimeKind.Local).AddTicks(692), "Solution Architec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "IdJob",
                keyValue: 3);
        }
    }
}
