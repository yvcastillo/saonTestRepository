using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Saon.DataAccess.Migrations
{
    public partial class FirstMigration : Migration
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
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 26, 9, 44, 36, 147, DateTimeKind.Local).AddTicks(8766), "Descripcion about .net developer", new DateTime(2020, 6, 25, 9, 44, 36, 148, DateTimeKind.Local).AddTicks(9860), ".NET Developer" },
                    { 2, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(641), "Descripcion about QA Analyst", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(653), ".QA Analyst" },
                    { 3, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(668), "Descripcion about Solution Architec", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(669), "Solution Architec" },
                    { 4, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(671), "Descripcion about Developer Manager", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(672), "Developer Manager" },
                    { 5, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(674), "Descripcion about Human Resource Talent Hunter", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(675), "Human Resource Talent Hunter" },
                    { 6, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(677), "Descripcion about Junior Java Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(678), "Junior Java Developer" },
                    { 7, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(679), "Descripcion about Senior Java Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(680), "Senior Java Developer" },
                    { 8, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(682), "Descripcion about Junior Javascript Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(683), "Junior Javascript Developer" },
                    { 9, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(684), "Descripcion about Senior Javascript Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(685), "Senior Javascript Developer" },
                    { 10, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(687), "Descripcion about Junior React Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(688), "Junior React Developer" },
                    { 11, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(689), "Descripcion about Senior React Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(690), "Senior React Developer" },
                    { 12, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(692), "Descripcion about Junior Phyton Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(693), "Junior Phyton Developer" },
                    { 13, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(694), "Descripcion about Senior Phyton Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(695), "Senior Phyton Developer" },
                    { 14, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(697), "Descripcion about Junior React  Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(698), "Junior React Developer" },
                    { 15, new DateTime(2020, 5, 26, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(700), "Descripcion about Senior React Developer", new DateTime(2020, 6, 25, 9, 44, 36, 149, DateTimeKind.Local).AddTicks(701), "Senior React Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
