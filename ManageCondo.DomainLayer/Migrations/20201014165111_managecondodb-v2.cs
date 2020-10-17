using Microsoft.EntityFrameworkCore.Migrations;

namespace ManageCondo.DomainLayer.Migrations
{
    public partial class managecondodbv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Property",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Property",
                newName: "Id");
        }
    }
}
