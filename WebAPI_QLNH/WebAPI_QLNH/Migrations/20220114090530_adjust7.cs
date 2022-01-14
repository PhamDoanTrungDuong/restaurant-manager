using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_QLNH.Migrations
{
    public partial class adjust7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterDatabase()
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Categorys",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        parentId = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Categorys", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Locations",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Locations", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Orders",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        OrderNumber = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        TotalPrice = table.Column<double>(type: "double", nullable: false),
            //        PaidAmount = table.Column<double>(type: "double", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "UnitTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitTypes", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Units",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        UnitTypeId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Units", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Units_UnitTypes_UnitTypeId",
            //            column: x => x.UnitTypeId,
            //            principalTable: "UnitTypes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Items",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Price = table.Column<double>(type: "double", nullable: false),
            //        Discount = table.Column<double>(type: "double", nullable: false),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        UnitId = table.Column<int>(type: "int", nullable: true),
            //        CategoryId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Items", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Items_Categorys_CategoryId",
            //            column: x => x.CategoryId,
            //            principalTable: "Categorys",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Items_Units_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "Units",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "ItemImages",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Data = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemImages", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ItemImages_Items_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Items",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "OrderItems",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        SalePrice = table.Column<double>(type: "double", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        OrderId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItems", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderItems_Items_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Items",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_OrderItems_Orders_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Orders",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "GuestTables",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        StatusId = table.Column<int>(type: "int", nullable: true),
            //        LocationId = table.Column<int>(type: "int", nullable: true),
            //        GuestId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GuestTables", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GuestTables_Locations_LocationId",
            //            column: x => x.LocationId,
            //            principalTable: "Locations",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Guests",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Phone = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        RestaurantId = table.Column<int>(type: "int", nullable: true),
            //        CreatedUserId = table.Column<int>(type: "int", nullable: true),
            //        UpdatedUserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Guests", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        RestaurantId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        UserName = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Password = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        OffDuty = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        RoleId = table.Column<int>(type: "int", nullable: true),
            //        CreatedUserId = table.Column<int>(type: "int", nullable: false),
            //        UpdatedUserId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Users_Roles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "Roles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Restaurants",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Phone = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Address = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        CreatedUserId = table.Column<int>(type: "int", nullable: true),
            //        UpdatedUserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Restaurants", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Restaurants_Users_CreatedUserId",
            //            column: x => x.CreatedUserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Restaurants_Users_UpdatedUserId",
            //            column: x => x.UpdatedUserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Status",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        CreatedUserId = table.Column<int>(type: "int", nullable: true),
            //        UpdatedUserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Status", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Status_Users_CreatedUserId",
            //            column: x => x.CreatedUserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Status_Users_UpdatedUserId",
            //            column: x => x.UpdatedUserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

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

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_GuestId",
            //    table: "GuestTables",
            //    column: "GuestId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_LocationId",
            //    table: "GuestTables",
            //    column: "LocationId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTables_StatusId",
            //    table: "GuestTables",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemImages_ItemId",
            //    table: "ItemImages",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Items_CategoryId",
            //    table: "Items",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Items_UnitId",
            //    table: "Items",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_ItemId",
            //    table: "OrderItems",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItems_OrderId",
            //    table: "OrderItems",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Restaurants_CreatedUserId",
            //    table: "Restaurants",
            //    column: "CreatedUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Restaurants_UpdatedUserId",
            //    table: "Restaurants",
            //    column: "UpdatedUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Roles_RestaurantId",
            //    table: "Roles",
            //    column: "RestaurantId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Status_CreatedUserId",
            //    table: "Status",
            //    column: "CreatedUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Status_UpdatedUserId",
            //    table: "Status",
            //    column: "UpdatedUserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Units_UnitTypeId",
            //    table: "Units",
            //    column: "UnitTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_RoleId",
            //    table: "Users",
            //    column: "RoleId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_GuestTables_Guests_GuestId",
            //    table: "GuestTables",
            //    column: "GuestId",
            //    principalTable: "Guests",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_GuestTables_Status_StatusId",
            //    table: "GuestTables",
            //    column: "StatusId",
            //    principalTable: "Status",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

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

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Roles_Restaurants_RestaurantId",
            //    table: "Roles",
            //    column: "RestaurantId",
            //    principalTable: "Restaurants",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Restaurants_RestaurantId",
                table: "Roles");

            migrationBuilder.DropTable(
                name: "GuestTables");

            migrationBuilder.DropTable(
                name: "ItemImages");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "UnitTypes");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
