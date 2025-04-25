using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIConsultaCNPJ.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Empresas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Empresas");
        }
    }
}
