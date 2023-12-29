using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFManyToMany.Migrations
{
    public partial class DbNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderWebuser",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    WebusersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderWebuser", x => new { x.OrdersId, x.WebusersId });
                    table.ForeignKey(
                        name: "FK_OrderWebuser_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderWebuser_WebUsers_WebusersId",
                        column: x => x.WebusersId,
                        principalTable: "WebUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderWebuser_WebusersId",
                table: "OrderWebuser",
                column: "WebusersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderWebuser");
        }
    }
}
