using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace business.Migrations
{
    /// <inheritdoc />
    public partial class editModelcustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "customer",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "customer",
                newName: "customername");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "customer",
                newName: "userid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "customer",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "customername",
                table: "customer",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "userid",
                table: "customer",
                newName: "UserId");
        }
    }
}
