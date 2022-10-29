using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dal.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Niveaus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Omschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveaus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolitiekePartijen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartijNaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AantalLeden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolitiekePartijen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PolitiekePartijenNiveau",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolitiekePartijID = table.Column<int>(type: "int", nullable: false),
                    NiveauID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolitiekePartijenNiveau", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolitiekePartijenNiveau_Niveaus_NiveauID",
                        column: x => x.NiveauID,
                        principalTable: "Niveaus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolitiekePartijenNiveau_PolitiekePartijen_PolitiekePartijID",
                        column: x => x.PolitiekePartijID,
                        principalTable: "PolitiekePartijen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Politici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JarenDienst = table.Column<int>(type: "int", nullable: false),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolitiekePartijNiveauID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Politici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Politici_PolitiekePartijenNiveau_PolitiekePartijNiveauID",
                        column: x => x.PolitiekePartijNiveauID,
                        principalTable: "PolitiekePartijenNiveau",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Politici_PolitiekePartijNiveauID",
                table: "Politici",
                column: "PolitiekePartijNiveauID");

            migrationBuilder.CreateIndex(
                name: "IX_PolitiekePartijenNiveau_NiveauID",
                table: "PolitiekePartijenNiveau",
                column: "NiveauID");

            migrationBuilder.CreateIndex(
                name: "IX_PolitiekePartijenNiveau_PolitiekePartijID",
                table: "PolitiekePartijenNiveau",
                column: "PolitiekePartijID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Politici");

            migrationBuilder.DropTable(
                name: "PolitiekePartijenNiveau");

            migrationBuilder.DropTable(
                name: "Niveaus");

            migrationBuilder.DropTable(
                name: "PolitiekePartijen");
        }
    }
}
