using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon_Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_Custome_category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmazonTaskCategory");

            migrationBuilder.CreateTable(
                name: "CategoryTesk",
                columns: table => new
                {
                    categoriesId = table.Column<int>(type: "int", nullable: false),
                    tasksId = table.Column<int>(type: "int", nullable: false),
                    getDateAdd = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTesk", x => new { x.categoriesId, x.tasksId });
                    table.ForeignKey(
                        name: "FK_CategoryTesk_amazonTasks_tasksId",
                        column: x => x.tasksId,
                        principalTable: "amazonTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryTesk_categorie_categoriesId",
                        column: x => x.categoriesId,
                        principalTable: "categorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTesk_tasksId",
                table: "CategoryTesk",
                column: "tasksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryTesk");

            migrationBuilder.CreateTable(
                name: "AmazonTaskCategory",
                columns: table => new
                {
                    categoriesId = table.Column<int>(type: "int", nullable: false),
                    tasksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmazonTaskCategory", x => new { x.categoriesId, x.tasksId });
                    table.ForeignKey(
                        name: "FK_AmazonTaskCategory_amazonTasks_tasksId",
                        column: x => x.tasksId,
                        principalTable: "amazonTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmazonTaskCategory_categorie_categoriesId",
                        column: x => x.categoriesId,
                        principalTable: "categorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmazonTaskCategory_tasksId",
                table: "AmazonTaskCategory",
                column: "tasksId");
        }
    }
}
