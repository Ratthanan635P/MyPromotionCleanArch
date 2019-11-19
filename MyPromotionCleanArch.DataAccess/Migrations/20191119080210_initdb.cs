using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPromotionCleanArch.DataAccess.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Nationality = table.Column<string>(maxLength: 50, nullable: false),
                    CitizenId = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Salt = table.Column<string>(nullable: false),
                    Role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Promotion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Expired = table.Column<DateTime>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    CreateById = table.Column<int>(nullable: true),
                    UpdateById = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Promotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_Promotion_Tb_User_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Tb_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_Promotion_Tb_User_UpdateById",
                        column: x => x.UpdateById,
                        principalTable: "Tb_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_MapCustomerPromotion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDateTime = table.Column<DateTime>(nullable: false),
                    UpdateDateTime = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    PromotionId = table.Column<int>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    IsUsed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_MapCustomerPromotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tb_MapCustomerPromotion_Tb_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Tb_Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_MapCustomerPromotion_Tb_Promotion_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Tb_Promotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_MapCustomerPromotion_CustomerId",
                table: "Tb_MapCustomerPromotion",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_MapCustomerPromotion_PromotionId",
                table: "Tb_MapCustomerPromotion",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Promotion_CreateById",
                table: "Tb_Promotion",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Promotion_UpdateById",
                table: "Tb_Promotion",
                column: "UpdateById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_MapCustomerPromotion");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Tb_Customer");

            migrationBuilder.DropTable(
                name: "Tb_Promotion");

            migrationBuilder.DropTable(
                name: "Tb_User");
        }
    }
}
