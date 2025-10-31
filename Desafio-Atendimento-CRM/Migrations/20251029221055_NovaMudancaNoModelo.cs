using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio_Atendimento_CRM.Migrations
{
    /// <inheritdoc />
    public partial class NovaMudancaNoModelo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_ClientePF_ClienteId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuariosId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pareceres_Atendimentos_AtendimentosId",
                table: "Pareceres");

            migrationBuilder.DropForeignKey(
                name: "FK_Pareceres_Usuarios_UsuariosId",
                table: "Pareceres");

            migrationBuilder.DropIndex(
                name: "IX_Pareceres_AtendimentosId",
                table: "Pareceres");

            migrationBuilder.DropIndex(
                name: "IX_Pareceres_UsuariosId",
                table: "Pareceres");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_ClienteId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_UsuariosId",
                table: "Atendimentos");

            migrationBuilder.AlterColumn<int>(
                name: "AtendimentosId",
                table: "ClientePF",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AtendimentosId",
                table: "ClientePF",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pareceres_AtendimentosId",
                table: "Pareceres",
                column: "AtendimentosId");

            migrationBuilder.CreateIndex(
                name: "IX_Pareceres_UsuariosId",
                table: "Pareceres",
                column: "UsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_ClienteId",
                table: "Atendimentos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_UsuariosId",
                table: "Atendimentos",
                column: "UsuariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_ClientePF_ClienteId",
                table: "Atendimentos",
                column: "ClienteId",
                principalTable: "ClientePF",
                principalColumn: "ClientePfId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Usuarios_UsuariosId",
                table: "Atendimentos",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "UsuariosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pareceres_Atendimentos_AtendimentosId",
                table: "Pareceres",
                column: "AtendimentosId",
                principalTable: "Atendimentos",
                principalColumn: "AtendimentosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pareceres_Usuarios_UsuariosId",
                table: "Pareceres",
                column: "UsuariosId",
                principalTable: "Usuarios",
                principalColumn: "UsuariosId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
