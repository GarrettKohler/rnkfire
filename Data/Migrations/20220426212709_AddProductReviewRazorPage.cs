using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rankfire.Data.Migrations
{
    public partial class AddProductReviewRazorPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductReview",
                columns: table => new
                {
                    GUID_ProductReview = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QualityScore = table.Column<int>(type: "int", nullable: false),
                    ValueScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReview", x => x.GUID_ProductReview);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductReview");
        }
    }
}
