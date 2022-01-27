using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4_MasonPerry.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Russo Brothers", false, null, "A classic in 2019!", "PG-13", "Avengers: End Game", 2019 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Christopher Nolan", false, null, "Best movie EVER.", "PG-13", "Interstellar", 2014 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Peter Jackson", false, null, "One of the all-time classics.", "PG-13", "Lord of the Rings: The Return of the King ", 2003 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
