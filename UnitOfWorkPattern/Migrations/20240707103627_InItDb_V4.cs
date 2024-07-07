using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWorkPattern.Migrations
{
    /// <inheritdoc />
    public partial class InItDb_V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Vehicle");

            migrationBuilder.CreateTable(
                name: "Cars",
                schema: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfMade = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDisplayToClient = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 14, 6, 26, 746, DateTimeKind.Local).AddTicks(9002));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars",
                schema: "Vehicle");

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6417));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 13, 59, 29, 190, DateTimeKind.Local).AddTicks(6534));
        }
    }
}
