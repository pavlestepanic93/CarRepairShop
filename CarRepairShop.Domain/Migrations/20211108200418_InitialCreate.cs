using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRepairShop.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientusers",
                columns: table => new
                {
                    ClientuserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surename = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Jmbg = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientusers", x => x.ClientuserId);
                });

            migrationBuilder.CreateTable(
                name: "Mechanicmans",
                columns: table => new
                {
                    MechanicmanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Surename = table.Column<string>(nullable: true),
                    Jmbg = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mechanicmans", x => x.MechanicmanId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(nullable: true),
                    CarModel = table.Column<string>(nullable: true),
                    CarChassis = table.Column<string>(nullable: true),
                    CarYear = table.Column<string>(nullable: true),
                    ClientuserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Clientusers_ClientuserId",
                        column: x => x.ClientuserId,
                        principalTable: "Clientusers",
                        principalColumn: "ClientuserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MechanicmanRole",
                columns: table => new
                {
                    MechanicmanRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MechanicManRoleName = table.Column<int>(nullable: false),
                    MechanicmanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MechanicmanRole", x => x.MechanicmanRoleId);
                    table.ForeignKey(
                        name: "FK_MechanicmanRole_Mechanicmans_MechanicmanId",
                        column: x => x.MechanicmanId,
                        principalTable: "Mechanicmans",
                        principalColumn: "MechanicmanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairService",
                columns: table => new
                {
                    RepairServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    DateTimeOfService = table.Column<DateTime>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    MechanicmanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairService", x => x.RepairServiceId);
                    table.ForeignKey(
                        name: "FK_RepairService_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairService_Mechanicmans_MechanicmanId",
                        column: x => x.MechanicmanId,
                        principalTable: "Mechanicmans",
                        principalColumn: "MechanicmanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ClientuserId",
                table: "Cars",
                column: "ClientuserId");

            migrationBuilder.CreateIndex(
                name: "IX_MechanicmanRole_MechanicmanId",
                table: "MechanicmanRole",
                column: "MechanicmanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RepairService_CarId",
                table: "RepairService",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairService_MechanicmanId",
                table: "RepairService",
                column: "MechanicmanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MechanicmanRole");

            migrationBuilder.DropTable(
                name: "RepairService");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Mechanicmans");

            migrationBuilder.DropTable(
                name: "Clientusers");
        }
    }
}
