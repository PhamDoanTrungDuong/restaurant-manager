using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_QLNH.Migrations
{
    public partial class adjust4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Restaurant_User_UserCreatedId",
            //    table: "Restaurant");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Restaurant_User_UserUpdatedId",
            //    table: "Restaurant");

            //migrationBuilder.RenameColumn(
            //    name: "UserUpdatedId",
            //    table: "Restaurant",
            //    newName: "UpdatedUserId");

            //migrationBuilder.RenameColumn(
            //    name: "UserCreatedId",
            //    table: "Restaurant",
            //    newName: "CreatedUserId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Restaurant_UserUpdatedId",
            //    table: "Restaurant",
            //    newName: "IX_Restaurant_UpdatedUserId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Restaurant_UserCreatedId",
            //    table: "Restaurant",
            //    newName: "IX_Restaurant_CreatedUserId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Restaurant_User_CreatedUserId",
            //    table: "Restaurant",
            //    column: "CreatedUserId",
            //    principalTable: "User",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Restaurant_User_UpdatedUserId",
            //    table: "Restaurant",
            //    column: "UpdatedUserId",
            //    principalTable: "User",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Restaurant_User_CreatedUserId",
            //    table: "Restaurant");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Restaurant_User_UpdatedUserId",
            //    table: "Restaurant");

            //migrationBuilder.RenameColumn(
            //    name: "UpdatedUserId",
            //    table: "Restaurant",
            //    newName: "UserUpdatedId");

            //migrationBuilder.RenameColumn(
            //    name: "CreatedUserId",
            //    table: "Restaurant",
            //    newName: "UserCreatedId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Restaurant_UpdatedUserId",
            //    table: "Restaurant",
            //    newName: "IX_Restaurant_UserUpdatedId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Restaurant_CreatedUserId",
            //    table: "Restaurant",
            //    newName: "IX_Restaurant_UserCreatedId");

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
    }
}
