using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoseCerezo_Taller1.Migrations
{
    /// <inheritdoc />
    public partial class Anadir_Nombre_A_Estadio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Estadio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Estadio");
        }
    }
}
