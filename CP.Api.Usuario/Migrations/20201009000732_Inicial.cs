using Microsoft.EntityFrameworkCore.Migrations;

namespace CP.Api.Usuario.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    Nome = table.Column<string>(maxLength: 3, nullable: true),
                    Celular = table.Column<string>(maxLength: 9, nullable: true),
                    Email = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Cpf);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
