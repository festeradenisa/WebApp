using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppCrud.Migrations
{
    public partial class AddingArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Album");

            migrationBuilder.AddColumn<int>(
                name: "ArtistID",
                table: "Album",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistID",
                table: "Album",
                column: "ArtistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Artist_ArtistID",
                table: "Album",
                column: "ArtistID",
                principalTable: "Artist",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Artist_ArtistID",
                table: "Album");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropIndex(
                name: "IX_Album_ArtistID",
                table: "Album");

            migrationBuilder.DropColumn(
                name: "ArtistID",
                table: "Album");

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Album",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
