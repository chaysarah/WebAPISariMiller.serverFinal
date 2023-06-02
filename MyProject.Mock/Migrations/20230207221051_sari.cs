using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    public partial class sari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Users_User",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "IdParent",
                table: "Children");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Children",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Children_User",
                table: "Children",
                newName: "IX_Children_IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Users_IdUser",
                table: "Children",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_Users_IdUser",
                table: "Children");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Children",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Children_IdUser",
                table: "Children",
                newName: "IX_Children_User");

            migrationBuilder.AddColumn<int>(
                name: "IdParent",
                table: "Children",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Children_Users_User",
                table: "Children",
                column: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
