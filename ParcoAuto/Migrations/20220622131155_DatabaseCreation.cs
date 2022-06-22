using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParcoAuto.Migrations
{
    public partial class DatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    AutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.AutoId);
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    UtentiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Targa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.UtentiId);
                });

            migrationBuilder.CreateTable(
                name: "Prenotazioni",
                columns: table => new
                {
                    Prenotazioni = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataPrenotazione = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Chilometri = table.Column<int>(type: "int", nullable: false),
                    AutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UtentiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenotazioni", x => x.Prenotazioni);
                    table.ForeignKey(
                        name: "FK_Prenotazioni_Auto_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Auto",
                        principalColumn: "AutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prenotazioni_Utenti_UtentiId",
                        column: x => x.UtentiId,
                        principalTable: "Utenti",
                        principalColumn: "UtentiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prenotazioni_AutoId",
                table: "Prenotazioni",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prenotazioni_UtentiId",
                table: "Prenotazioni",
                column: "UtentiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prenotazioni");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}
