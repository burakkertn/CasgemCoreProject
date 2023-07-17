using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class migqw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfrimCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfrimCode",
                table: "AspNetUsers");
        }
    }
}
