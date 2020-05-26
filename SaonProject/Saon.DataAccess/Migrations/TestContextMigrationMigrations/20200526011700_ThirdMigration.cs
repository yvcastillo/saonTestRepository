using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Saon.DataAccess.Migrations.TestContextMigrationMigrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    IdJob = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(maxLength: 64, nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExpiredAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.IdJob);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "CreatedAt", "Description", "ExpiredAt", "JobTitle" },
                values: new object[] { 1, new DateTime(2020, 5, 25, 19, 17, 0, 449, DateTimeKind.Local).AddTicks(7050), "Descripcion about .net developer", new DateTime(2020, 6, 24, 19, 17, 0, 450, DateTimeKind.Local).AddTicks(7354), ".NET Developer" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "CreatedAt", "Description", "ExpiredAt", "JobTitle" },
                values: new object[] { 2, new DateTime(2020, 5, 25, 19, 17, 0, 450, DateTimeKind.Local).AddTicks(7828), "Descripcion about QA Analyst", new DateTime(2020, 6, 24, 19, 17, 0, 450, DateTimeKind.Local).AddTicks(7841), ".QA Analyst" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "IdJob", "CreatedAt", "Description", "ExpiredAt", "JobTitle" },
                values: new object[] { 3, new DateTime(2020, 5, 25, 19, 17, 0, 450, DateTimeKind.Local).AddTicks(7855), "Descripcion about Solution Architec", new DateTime(2020, 6, 24, 19, 17, 0, 450, DateTimeKind.Local).AddTicks(7856), "Solution Architec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
