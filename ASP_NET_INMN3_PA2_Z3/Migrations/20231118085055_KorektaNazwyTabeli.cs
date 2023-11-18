using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET_INMN3_PA2_Z3.Migrations
{
    /// <inheritdoc />
    public partial class KorektaNazwyTabeli : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Miasto",
                table: "Miasto");

            migrationBuilder.RenameTable(
                name: "Miasto",
                newName: "Miasta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miasta",
                table: "Miasta",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Miasta",
                table: "Miasta");

            migrationBuilder.RenameTable(
                name: "Miasta",
                newName: "Miasto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miasto",
                table: "Miasto",
                column: "Id");
        }
    }
}
