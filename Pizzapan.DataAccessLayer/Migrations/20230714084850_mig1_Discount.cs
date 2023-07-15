using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzapan.DataAccessLayer.Migrations
{
    public partial class mig1_Discount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "discounts",
                columns: table => new
                {
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountLastDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountSınır = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discounts", x => x.DiscountID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "discounts");
        }
    }
}
