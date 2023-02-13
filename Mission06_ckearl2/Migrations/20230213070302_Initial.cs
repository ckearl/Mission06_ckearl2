using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ckearl2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieID", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 1, false, "-", "This movie is based in Chicago", "PG-13", "Ferris Bueller's Day Off" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieID", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 2, false, "-", "Jack Black is my hero", "PG-13", "School of Rock" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieID", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 3, false, "Scotty Smalls", "A cult classic", "PG", "The Sandlot" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieID", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 4, true, "J.K. Simmons", "GOAT movie", "R", "Whiplash" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieID", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 5, true, "Matt Damon", "The most stacked cast of all time", "R", "Good Will Hunting" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
