using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_Atendimento_CRM.Migrations
{
    /// <inheritdoc />
    public partial class AjustesStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnosDeAtividade",
                table: "Fornecedores",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeDeReclamacoes",
                table: "Fornecedores",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StatusValidacao",
                table: "Fornecedores",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnosDeAtividade",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "QuantidadeDeReclamacoes",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "StatusValidacao",
                table: "Fornecedores");
        }
    }
}
