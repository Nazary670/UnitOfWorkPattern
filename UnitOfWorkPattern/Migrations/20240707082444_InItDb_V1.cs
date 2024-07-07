using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UnitOfWorkPattern.Migrations
{
    /// <inheritdoc />
    public partial class InItDb_V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Condition");

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                schema: "Condition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_En = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: false),
                    Title_Jp = table.Column<string>(type: "nvarchar(155)", maxLength: 155, nullable: true),
                    TagName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    ParentConditionId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDisplayToClient = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conditions_Conditions_ParentConditionId",
                        column: x => x.ParentConditionId,
                        principalSchema: "Condition",
                        principalTable: "Conditions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Condition",
                table: "Conditions",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "IsDisplayToClient", "ModifiedDate", "ParentConditionId", "TagName", "Title_En", "Title_Jp" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3380), false, true, null, null, "lbl", "RUNNING STATUS", null },
                    { 2, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3391), false, true, null, null, "lbl", "IN/OUT CONDITION", null },
                    { 3, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3393), false, true, null, null, "lbl", "ACCIDENT", null },
                    { 4, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3396), false, true, null, null, "lbl", "LOADABILITY", null },
                    { 5, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3398), false, true, null, 1, "lbl", "IS SELF-PROPELLED", null },
                    { 8, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3404), false, true, null, 1, "lbl", "IS DRIVEABLE?", null },
                    { 11, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3410), false, true, null, 1, "chk", "ENGINE STATUS", null },
                    { 17, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3424), false, true, null, 1, "sl", "TRANSMISSION", null },
                    { 21, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3432), false, true, null, 1, "sl", "IS CHECK LAMPS LIT", null },
                    { 25, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3440), false, true, null, 2, "lbl", "INTERIOR", null },
                    { 38, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3467), false, true, null, 2, "ldl", "EXTERIOR", null },
                    { 55, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3501), false, true, null, 4, "chb", "ENOUGH SPACE", null },
                    { 56, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3503), false, true, null, 4, "chb", "ONLY 2 TON TRUCKS", null },
                    { 6, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3400), false, true, null, 5, "rdb", "SELF-PROPELLED", null },
                    { 7, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3402), false, true, null, 5, "rdb", "NOT SELF-PROPELLED", null },
                    { 9, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3406), false, true, null, 8, "chk", "DRIVABLE", null },
                    { 10, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3408), false, true, null, 8, "chk", "NOT DRIVABLE", null },
                    { 18, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3426), false, true, null, 17, null, "IN GOOD ConditionN", null },
                    { 19, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3428), false, true, null, 17, null, "MALFUNCTION", null },
                    { 20, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3430), false, true, null, 17, null, "UNCONFIRMED", null },
                    { 22, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3434), false, true, null, 21, null, "YES", null },
                    { 23, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3436), false, true, null, 21, null, "NO", null },
                    { 24, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3438), false, true, null, 21, null, "UNCONFIRMED", null },
                    { 26, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3442), false, true, null, 25, "sl", "DIRT/STAINS", null },
                    { 30, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3451), false, true, null, 25, "sl", "TEARS IN SEAT", null },
                    { 34, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3459), false, true, null, 25, "sl", "AIR CONDITIONING", null },
                    { 39, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3469), false, true, null, 38, "sl", "SCRATCHES", null },
                    { 43, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3478), false, true, null, 38, "sl", "DENT", null },
                    { 47, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3486), false, true, null, 38, "sl", "PAINT PEELING", null },
                    { 12, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3413), false, true, null, 9, "chk", "IN GOOD Condition", null },
                    { 13, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3415), false, true, null, 9, "chk", "STRANGE NOISE", null },
                    { 14, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3418), false, true, null, 9, "chk", "WHITE SMOKE", null },
                    { 15, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3420), false, true, null, 9, "chk", "ON BATTRY", null },
                    { 16, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3421), false, true, null, 9, "chk", "UNCONFIRMED", null },
                    { 27, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3444), false, true, null, 26, null, "YES", null },
                    { 28, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3447), false, true, null, 26, null, "NO", null },
                    { 29, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3449), false, true, null, 26, null, "UNCONFIRMED", null },
                    { 31, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3453), false, true, null, 30, null, "YES", null },
                    { 32, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3455), false, true, null, 30, null, "NO", null },
                    { 33, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3457), false, true, null, 30, null, "UNCONFIRMED", null },
                    { 35, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3461), false, true, null, 34, null, "GOOD", null },
                    { 36, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3463), false, true, null, 34, null, "BAD", null },
                    { 37, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3465), false, true, null, 34, null, "NOT CONFIRMED", null },
                    { 40, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3471), false, true, null, 39, null, "YES", null },
                    { 41, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3473), false, true, null, 39, null, "NO", null },
                    { 42, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3476), false, true, null, 39, null, "UNCONFIRMED", null },
                    { 44, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3480), false, true, null, 43, null, "YES", null },
                    { 45, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3482), false, true, null, 43, null, "NO", null },
                    { 46, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3484), false, true, null, 43, null, "UNCONFIRMED", null },
                    { 48, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3488), false, true, null, 47, null, "YES", null },
                    { 49, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3490), false, true, null, 47, null, "NO", null },
                    { 50, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3492), false, true, null, 47, null, "UNCONFIRMED", null },
                    { 51, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3494), false, true, null, 35, "sl", "RUST", null },
                    { 52, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3496), false, true, null, 51, null, "YES", null },
                    { 53, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3497), false, true, null, 51, null, "NO", null },
                    { 54, new DateTime(2024, 7, 7, 11, 54, 42, 330, DateTimeKind.Local).AddTicks(3499), false, true, null, 51, null, "UNCONFIRMED", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_ParentConditionId",
                schema: "Condition",
                table: "Conditions",
                column: "ParentConditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Conditions",
                schema: "Condition");
        }
    }
}
