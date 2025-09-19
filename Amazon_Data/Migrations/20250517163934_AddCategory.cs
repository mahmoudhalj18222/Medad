using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Amazon_Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorie", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmazonTaskCategory");

            migrationBuilder.DropTable(
                name: "categorie");
        }
    }
}
