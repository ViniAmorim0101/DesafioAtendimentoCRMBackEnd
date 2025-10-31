using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_Atendimento_CRM.Migrations
{
    /// <inheritdoc />
    public partial class AjusteID2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fornecedores",
                newName: "Forn_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Forn_Id",
                table: "Fornecedores",
                newName: "Id");
        }
    }
}
