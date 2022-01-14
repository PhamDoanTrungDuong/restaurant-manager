using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_QLNH.Migrations
{
    public partial class adjust6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "CreatedUserId",
            //    table: "Guests",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "RestaurantId",
            //    table: "Guests",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "UpdatedUserId",
            //    table: "Guests",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Guests_CreatedUserId",
            //    table: "Guests",
            //    column: "CreatedUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Guests_RestaurantId",
            //    table: "Guests",
            //    column: "RestaurantId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Guests_UpdatedUserId",
            //    table: "Guests",
            //    column: "UpdatedUserId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Guests_Restaurants_RestaurantId",
            //    table: "Guests",
            //    column: "RestaurantId",
            //    principalTable: "Restaurants",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Guests_Users_CreatedUserId",
            //    table: "Guests",
            //    column: "CreatedUserId",
            //    principalTable: "Users",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Guests_Users_UpdatedUserId",
            //    table: "Guests",
            //    column: "UpdatedUserId",
            //    principalTable: "Users",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Guests_Restaurants_RestaurantId",
            //    table: "Guests");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Guests_Users_CreatedUserId",
            //    table: "Guests");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Guests_Users_UpdatedUserId",
            //    table: "Guests");

            //migrationBuilder.DropIndex(
            //    name: "IX_Guests_CreatedUserId",
            //    table: "Guests");

            //migrationBuilder.DropIndex(
            //    name: "IX_Guests_RestaurantId",
            //    table: "Guests");

            //migrationBuilder.DropIndex(
            //    name: "IX_Guests_UpdatedUserId",
            //    table: "Guests");

            //migrationBuilder.DropColumn(
            //    name: "CreatedUserId",
            //    table: "Guests");

            //migrationBuilder.DropColumn(
            //    name: "RestaurantId",
            //    table: "Guests");

            //migrationBuilder.DropColumn(
            //    name: "UpdatedUserId",
            //    table: "Guests");
        }
    }
}
