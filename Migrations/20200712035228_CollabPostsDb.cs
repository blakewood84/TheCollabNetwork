using Microsoft.EntityFrameworkCore.Migrations;

namespace collabnetwork.Migrations
{
    public partial class CollabPostsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollabPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GitHubRepoLink = table.Column<string>(nullable: true),
                    SlackChannel = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollabPosts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollabPosts");
        }
    }
}
