using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoContabil.Migrations
{
    public partial class InitialBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Recebido",
                table: "Receitas",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "Pago",
                table: "Despesas",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Recebido",
                table: "Receitas",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<bool>(
                name: "Pago",
                table: "Despesas",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean");
        }
    }
}
