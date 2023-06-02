using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_changeusers_usercolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMessages_Messages_MessageID1",
                table: "UserMessages");

            migrationBuilder.DropIndex(
                name: "IX_UserMessages_MessageID1",
                table: "UserMessages");

            migrationBuilder.DropColumn(
                name: "MessageID1",
                table: "UserMessages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageID1",
                table: "UserMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserMessages_MessageID1",
                table: "UserMessages",
                column: "MessageID1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserMessages_Messages_MessageID1",
                table: "UserMessages",
                column: "MessageID1",
                principalTable: "Messages",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
