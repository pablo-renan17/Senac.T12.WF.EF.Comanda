using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeComandas.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomeUsuario = table.Column<string>(type: "TEXT", nullable: false),
                    emailusuario = table.Column<string>(type: "TEXT", nullable: false),
                    senhaUsuario = table.Column<string>(type: "TEXT", nullable: false),
                    idFuncaoUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
