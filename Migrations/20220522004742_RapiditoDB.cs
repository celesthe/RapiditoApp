using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapiditoWEBAPP.Migrations
{
    public partial class RapiditoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuotaPeso",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<string>(nullable: true),
                    Monto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuotaPeso", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EnvioPedido",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DireccionOrigen = table.Column<string>(nullable: true),
                    UbicacionGeograficaOrigen = table.Column<string>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    productoAentregar = table.Column<string>(nullable: true),
                    idCuotaPesoE = table.Column<int>(nullable: false),
                    DireccionDestino = table.Column<string>(nullable: true),
                    UbicacionGeograficaDestino = table.Column<string>(nullable: true),
                    NombreClienteRecibe = table.Column<string>(nullable: true),
                    doctoIdentificacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvioPedido", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MotoristaZona",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdZonaM = table.Column<int>(nullable: false),
                    IdMotoristaM = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoristaZona", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Nit = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    IdTipoPersonaP = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipoPersonas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPersona = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersonas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    idPersonaU = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaRegistro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Zonass",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zona = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Municipio = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonass", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuotaPeso");

            migrationBuilder.DropTable(
                name: "EnvioPedido");

            migrationBuilder.DropTable(
                name: "MotoristaZona");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "TipoPersonas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Zonass");
        }
    }
}
