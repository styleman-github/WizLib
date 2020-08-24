using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class AddCategoryWithMixOfDaAndFluent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_fluent_Publishers",
                table: "fluent_Publishers");

            migrationBuilder.RenameTable(
                name: "fluent_Publishers",
                newName: "Fluent_Publishers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Publishers",
                table: "Fluent_Publishers",
                column: "Publisher_Id");

            migrationBuilder.CreateTable(
                name: "tbl_category",
                columns: table => new
                {
                    Category_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category", x => x.Category_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Publishers",
                table: "Fluent_Publishers");

            migrationBuilder.RenameTable(
                name: "Fluent_Publishers",
                newName: "fluent_Publishers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fluent_Publishers",
                table: "fluent_Publishers",
                column: "Publisher_Id");
        }
    }
}
