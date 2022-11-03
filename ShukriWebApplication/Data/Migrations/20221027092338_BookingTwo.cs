using Microsoft.EntityFrameworkCore.Migrations;

namespace ShukriWebApplication.Data.Migrations
{
    public partial class BookingTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BkEndDate",
                table: "Experiences",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BkEndDate",
                table: "Experiences");
        }
    }
}
