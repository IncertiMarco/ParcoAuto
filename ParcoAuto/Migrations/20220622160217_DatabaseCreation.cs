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
                    Targa = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.UtentiId);
                });

            migrationBuilder.CreateTable(
                name: "SpecificheAuto",
                columns: table => new
                {
                    ModelloId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modello = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificheAuto", x => x.ModelloId);
                    table.ForeignKey(
                        name: "FK_SpecificheAuto_Auto_AutoId",
                        column: x => x.AutoId,
                        principalTable: "Auto",
                        principalColumn: "AutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prenotazioni",
                columns: table => new
                {
                    PrenotazioniId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataInizioPrenotazione = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinePrenotazione = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Chilometri = table.Column<int>(type: "int", nullable: false),
                    AutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UtentiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenotazioni", x => x.PrenotazioniId);
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

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    NotaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Annotazione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrenotazioniId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.NotaId);
                    table.ForeignKey(
                        name: "FK_Note_Prenotazioni_PrenotazioniId",
                        column: x => x.PrenotazioniId,
                        principalTable: "Prenotazioni",
                        principalColumn: "PrenotazioniId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Note_PrenotazioniId",
                table: "Note",
                column: "PrenotazioniId");

            migrationBuilder.CreateIndex(
                name: "IX_Prenotazioni_AutoId",
                table: "Prenotazioni",
                column: "AutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prenotazioni_UtentiId",
                table: "Prenotazioni",
                column: "UtentiId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificheAuto_AutoId",
                table: "SpecificheAuto",
                column: "AutoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "SpecificheAuto");

            migrationBuilder.DropTable(
                name: "Prenotazioni");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}
