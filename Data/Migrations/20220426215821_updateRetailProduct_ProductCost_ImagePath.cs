using Microsoft.EntityFrameworkCore.Migrations;

namespace rankfire.Data.Migrations
{
    public partial class updateRetailProduct_ProductCost_ImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "RetailProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductDescription",
                table: "RetailProduct",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "RetailProduct");

            migrationBuilder.DropColumn(
                name: "ProductDescription",
                table: "RetailProduct");
        }
    }
}
