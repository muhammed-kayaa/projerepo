using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WordApp.Migrations
{
    public partial class FixWordSampleKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WordId",
                table: "Words",
                newName: "WordID");

            migrationBuilder.CreateTable(
                name: "WordSamples",
                columns: table => new
                {
                    WordSampleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordID = table.Column<int>(type: "int", nullable: false),
                    Samples = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordSamples", x => x.WordSampleId);
                    table.ForeignKey(
                        name: "FK_WordSamples_Words_WordID",
                        column: x => x.WordID,
                        principalTable: "Words",
                        principalColumn: "WordID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WordSamples_WordID",
                table: "WordSamples",
                column: "WordID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordSamples");

            migrationBuilder.RenameColumn(
                name: "WordID",
                table: "Words",
                newName: "WordId");
        }
    }
}
