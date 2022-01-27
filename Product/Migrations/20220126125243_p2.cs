using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.Migrations
{
    public partial class p2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "isactive",
                table: "User",
                newName: "IsActive");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "User",
                type: "bit",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "VerifyAccountId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "VerifyAccount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerifyAccount", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_VerifyAccountId",
                table: "User",
                column: "VerifyAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_VerifyAccount_VerifyAccountId",
                table: "User",
                column: "VerifyAccountId",
                principalTable: "VerifyAccount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_VerifyAccount_VerifyAccountId",
                table: "User");

            migrationBuilder.DropTable(
                name: "VerifyAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_VerifyAccountId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "VerifyAccountId",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "users");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "users",
                newName: "isactive");

            migrationBuilder.AlterColumn<string>(
                name: "isactive",
                table: "users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }
    }
}
