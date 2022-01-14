using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_QLNH.Migrations
{
    public partial class adjust2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "UserCreatedId",
            //    table: "Restaurant",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "UserUpdatedId",
            //    table: "Restaurant",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Restaurant_UserCreatedId",
            //    table: "Restaurant",
            //    column: "UserCreatedId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Restaurant_UserUpdatedId",
            //    table: "Restaurant",
            //    column: "UserUpdatedId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Restaurant_User_UserCreatedId",
            //    table: "Restaurant",
            //    column: "UserCreatedId",
            //    principalTable: "User",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Restaurant_User_UserUpdatedId",
            //    table: "Restaurant",
            //    column: "UserUpdatedId",
            //    principalTable: "User",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Restaurant_User_UserCreatedId",
            //    table: "Restaurant");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Restaurant_User_UserUpdatedId",
            //    table: "Restaurant");

            //migrationBuilder.DropIndex(
            //    name: "IX_Restaurant_UserCreatedId",
            //    table: "Restaurant");

            //migrationBuilder.DropIndex(
            //    name: "IX_Restaurant_UserUpdatedId",
            //    table: "Restaurant");

            //migrationBuilder.DropColumn(
            //    name: "UserCreatedId",
            //    table: "Restaurant");

            //migrationBuilder.DropColumn(
            //    name: "UserUpdatedId",
            //    table: "Restaurant");
        }
    }
}
