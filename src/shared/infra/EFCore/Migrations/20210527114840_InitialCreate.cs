using Microsoft.EntityFrameworkCore.Migrations;

namespace vaivoa_challenge.Migrations {
  public partial class InitialCreate : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
        name: "Cards",
        columns: table => new {
          id = table.Column<string>(type: "text", nullable: false),
          card_number = table.Column<string>(type: "text", nullable: false),
          email = table.Column<string>(type: "text", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Cards", x => x.id);
      });
    }
    protected override void Down(MigrationBuilder migrationBuilder) {
      migrationBuilder.DropTable(name: "Cards");
    }
  }
}
