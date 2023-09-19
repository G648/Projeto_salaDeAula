using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi_SenaiClassRoom.Migrations
{
    /// <inheritdoc />
    public partial class BD_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instituicao",
                columns: table => new
                {
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(12)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituicao", x => x.IdInstituicao);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoCurso",
                columns: table => new
                {
                    IdPeriodoCurso = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoCurso", x => x.IdPeriodoCurso);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoUsuario",
                columns: table => new
                {
                    IdPeriodoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoUsuario", x => x.IdPeriodoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "CalendarioEscolar",
                columns: table => new
                {
                    IdCalendarioEscolar = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InicioCalendario = table.Column<DateTime>(type: "DATE", nullable: false),
                    FinalCalendario = table.Column<DateTime>(type: "DATE", nullable: false),
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarioEscolar", x => x.IdCalendarioEscolar);
                    table.ForeignKey(
                        name: "FK_CalendarioEscolar_Instituicao_IdInstituicao",
                        column: x => x.IdInstituicao,
                        principalTable: "Instituicao",
                        principalColumn: "IdInstituicao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    IdSetor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Responsavel = table.Column<string>(type: "VARCHAR(80)", nullable: false),
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.IdSetor);
                    table.ForeignKey(
                        name: "FK_Setor_Instituicao_IdInstituicao",
                        column: x => x.IdInstituicao,
                        principalTable: "Instituicao",
                        principalColumn: "IdInstituicao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    UsuarioSN = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInstituicao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPeriodoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Instituicao_IdInstituicao",
                        column: x => x.IdInstituicao,
                        principalTable: "Instituicao",
                        principalColumn: "IdInstituicao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_PeriodoUsuario_IdPeriodoUsuario",
                        column: x => x.IdPeriodoUsuario,
                        principalTable: "PeriodoUsuario",
                        principalColumn: "IdPeriodoUsuario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuario_TiposUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TiposUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalasDeAula",
                columns: table => new
                {
                    IdSalaDeAula = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    IdSetor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasDeAula", x => x.IdSalaDeAula);
                    table.ForeignKey(
                        name: "FK_SalasDeAula_Setor_IdSetor",
                        column: x => x.IdSetor,
                        principalTable: "Setor",
                        principalColumn: "IdSetor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalasDeAula_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    IdCurso = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    QuantidadeAlunos = table.Column<byte>(type: "TINYINT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    IdPeriodoCurso = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSalaDeAula = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.IdCurso);
                    table.ForeignKey(
                        name: "FK_Curso_PeriodoCurso_IdPeriodoCurso",
                        column: x => x.IdPeriodoCurso,
                        principalTable: "PeriodoCurso",
                        principalColumn: "IdPeriodoCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Curso_SalasDeAula_IdSalaDeAula",
                        column: x => x.IdSalaDeAula,
                        principalTable: "SalasDeAula",
                        principalColumn: "IdSalaDeAula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CalendarioEscolar_IdInstituicao",
                table: "CalendarioEscolar",
                column: "IdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_IdPeriodoCurso",
                table: "Curso",
                column: "IdPeriodoCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Curso_IdSalaDeAula",
                table: "Curso",
                column: "IdSalaDeAula");

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeAula_IdSetor",
                table: "SalasDeAula",
                column: "IdSetor");

            migrationBuilder.CreateIndex(
                name: "IX_SalasDeAula_IdUsuario",
                table: "SalasDeAula",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Setor_IdInstituicao",
                table: "Setor",
                column: "IdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdInstituicao",
                table: "Usuario",
                column: "IdInstituicao");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdPeriodoUsuario",
                table: "Usuario",
                column: "IdPeriodoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdTipoUsuario",
                table: "Usuario",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalendarioEscolar");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "PeriodoCurso");

            migrationBuilder.DropTable(
                name: "SalasDeAula");

            migrationBuilder.DropTable(
                name: "Setor");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Instituicao");

            migrationBuilder.DropTable(
                name: "PeriodoUsuario");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
