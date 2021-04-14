using Microsoft.EntityFrameworkCore.Migrations;

namespace CeeLearnAndDo_WijOnt.Data.Migrations
{
    public partial class consultantCards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Consultant",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Consultant");
        }
    }
}
