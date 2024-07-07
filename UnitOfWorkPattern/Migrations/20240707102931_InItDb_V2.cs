using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWorkPattern.Migrations
{
    /// <inheritdoc />
    public partial class InItDb_V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDisplayToClient = table.Column<bool>(type: "bit", nullable: false),
                    MakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YearOfMade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3396));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3503));
        }
    }
}
