using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaServicios.Api.Autor.Migrations
{
    public partial class Cambio_en_nombres_de_tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gradoAcademico_autorLibro_AutorLibroId",
                table: "gradoAcademico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gradoAcademico",
                table: "gradoAcademico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_autorLibro",
                table: "autorLibro");

            migrationBuilder.RenameTable(
                name: "gradoAcademico",
                newName: "GradoAcademico");

            migrationBuilder.RenameTable(
                name: "autorLibro",
                newName: "AutorLibro");

            migrationBuilder.RenameIndex(
                name: "IX_gradoAcademico_AutorLibroId",
                table: "GradoAcademico",
                newName: "IX_GradoAcademico_AutorLibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GradoAcademico",
                table: "GradoAcademico",
                column: "GradoAcademicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AutorLibro",
                table: "AutorLibro",
                column: "AutorLibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_GradoAcademico_AutorLibro_AutorLibroId",
                table: "GradoAcademico",
                column: "AutorLibroId",
                principalTable: "AutorLibro",
                principalColumn: "AutorLibroId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradoAcademico_AutorLibro_AutorLibroId",
                table: "GradoAcademico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GradoAcademico",
                table: "GradoAcademico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AutorLibro",
                table: "AutorLibro");

            migrationBuilder.RenameTable(
                name: "GradoAcademico",
                newName: "gradoAcademico");

            migrationBuilder.RenameTable(
                name: "AutorLibro",
                newName: "autorLibro");

            migrationBuilder.RenameIndex(
                name: "IX_GradoAcademico_AutorLibroId",
                table: "gradoAcademico",
                newName: "IX_gradoAcademico_AutorLibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gradoAcademico",
                table: "gradoAcademico",
                column: "GradoAcademicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_autorLibro",
                table: "autorLibro",
                column: "AutorLibroId");

            migrationBuilder.AddForeignKey(
                name: "FK_gradoAcademico_autorLibro_AutorLibroId",
                table: "gradoAcademico",
                column: "AutorLibroId",
                principalTable: "autorLibro",
                principalColumn: "AutorLibroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
