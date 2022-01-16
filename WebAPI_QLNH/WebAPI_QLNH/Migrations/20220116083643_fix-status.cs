using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_QLNH.Migrations
{
    public partial class fixstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Status",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Status_RestaurantId",
                table: "Status",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Restaurants_RestaurantId",
                table: "Status",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_Restaurants_RestaurantId",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_RestaurantId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Status");
        }
    }
}
