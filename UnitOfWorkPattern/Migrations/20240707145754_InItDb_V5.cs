using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UnitOfWorkPattern.Migrations
{
    /// <inheritdoc />
    public partial class InItDb_V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelName",
                schema: "Vehicle",
                table: "Cars",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MakerName",
                schema: "Vehicle",
                table: "Cars",
                type: "nvarchar(125)",
                maxLength: 125,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2377));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                schema: "Condition",
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 7, 18, 27, 54, 54, DateTimeKind.Local).AddTicks(2405));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelName",
                schema: "Vehicle",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125);

            migrationBuilder.AlterColumn<string>(
                name: "MakerName",
                schema: "Vehicle",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(125)",
                oldMaxLength: 125);

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
    }
}
