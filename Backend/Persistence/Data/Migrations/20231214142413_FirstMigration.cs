using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "forma_pago",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "pais",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "rol",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "tipo_producto",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "user",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         password = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "pago",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         fecha_pago = table.Column<DateOnly>(type: "date", nullable: false),
            //         total = table.Column<int>(type: "int", nullable: false),
            //         id_forma_pago_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "pago_ibfk_1",
            //             column: x => x.id_forma_pago_fk,
            //             principalTable: "forma_pago",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "departamento",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         id_pais_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "departamento_ibfk_1",
            //             column: x => x.id_pais_fk,
            //             principalTable: "pais",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "producto",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         imagen = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         talla = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         stock_min = table.Column<int>(type: "int", nullable: false),
            //         stock_actual = table.Column<int>(type: "int", nullable: false),
            //         stock_max = table.Column<int>(type: "int", nullable: false),
            //         precio = table.Column<double>(type: "double", nullable: false),
            //         id_tipo_producto_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "producto_ibfk_1",
            //             column: x => x.id_tipo_producto_fk,
            //             principalTable: "tipo_producto",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "userrol",
            //     columns: table => new
            //     {
            //         id_user_fk = table.Column<int>(type: "int", nullable: false),
            //         id_rol_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => new { x.id_user_fk, x.id_rol_fk })
            //             .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            //         table.ForeignKey(
            //             name: "userrol_ibfk_1",
            //             column: x => x.id_user_fk,
            //             principalTable: "user",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "userrol_ibfk_2",
            //             column: x => x.id_rol_fk,
            //             principalTable: "rol",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "ciudad",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         id_departamento_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "ciudad_ibfk_1",
            //             column: x => x.id_departamento_fk,
            //             principalTable: "departamento",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "orden",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         cantidad = table.Column<int>(type: "int", nullable: false),
            //         id_producto_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "orden_ibfk_1",
            //             column: x => x.id_producto_fk,
            //             principalTable: "producto",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "direccion",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         tipo_via = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_principal = table.Column<short>(type: "smallint", nullable: false),
            //         letra_principal = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         bis = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         letra_secundaria = table.Column<string>(type: "char(2)", fixedLength: true, maxLength: 2, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         cardinal_primario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         numero_secundario = table.Column<short>(type: "smallint", nullable: false),
            //         cardinal_secundario = table.Column<string>(type: "char(10)", fixedLength: true, maxLength: 10, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         id_ciudad_fk = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "direccion_ibfk_1",
            //             column: x => x.id_ciudad_fk,
            //             principalTable: "ciudad",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "cliente",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         id_persona = table.Column<int>(type: "int", nullable: false),
            //         nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         telefono = table.Column<int>(type: "int", nullable: false),
            //         id_direccion_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "cliente_ibfk_1",
            //             column: x => x.id_direccion_fk,
            //             principalTable: "direccion",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "pedido",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         id_estado_fk = table.Column<int>(type: "int", nullable: false),
            //         id_pago_fk = table.Column<int>(type: "int", nullable: false),
            //         id_cliente_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "pedido_ibfk_1",
            //             column: x => x.id_cliente_fk,
            //             principalTable: "cliente",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "pedido_ibfk_2",
            //             column: x => x.id_pago_fk,
            //             principalTable: "pago",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "orden_pedido",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         id_orden_fk = table.Column<int>(type: "int", nullable: false),
            //         id_pedido_fk = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "orden_pedido_ibfk_1",
            //             column: x => x.id_orden_fk,
            //             principalTable: "orden",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "orden_pedido_ibfk_2",
            //             column: x => x.id_pedido_fk,
            //             principalTable: "pedido",
            //             principalColumn: "id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "id",
            //     table: "ciudad",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_departamento_fk",
            //     table: "ciudad",
            //     column: "id_departamento_fk");

            // migrationBuilder.CreateIndex(
            //     name: "nombre",
            //     table: "ciudad",
            //     column: "nombre",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id1",
            //     table: "cliente",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_direccion_fk",
            //     table: "cliente",
            //     column: "id_direccion_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id_persona",
            //     table: "cliente",
            //     column: "id_persona",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id2",
            //     table: "departamento",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_pais_fk",
            //     table: "departamento",
            //     column: "id_pais_fk");

            // migrationBuilder.CreateIndex(
            //     name: "nombre1",
            //     table: "departamento",
            //     column: "nombre",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id3",
            //     table: "direccion",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_ciudad_fk",
            //     table: "direccion",
            //     column: "id_ciudad_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id4",
            //     table: "forma_pago",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id5",
            //     table: "orden",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_producto_fk",
            //     table: "orden",
            //     column: "id_producto_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id6",
            //     table: "orden_pedido",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_orden_fk",
            //     table: "orden_pedido",
            //     column: "id_orden_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id_pedido_fk",
            //     table: "orden_pedido",
            //     column: "id_pedido_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id7",
            //     table: "pago",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_forma_pago_fk",
            //     table: "pago",
            //     column: "id_forma_pago_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id8",
            //     table: "pais",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "nombre2",
            //     table: "pais",
            //     column: "nombre",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id9",
            //     table: "pedido",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_cliente_fk",
            //     table: "pedido",
            //     column: "id_cliente_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id_pago_fk",
            //     table: "pedido",
            //     column: "id_pago_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id10",
            //     table: "producto",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_tipo_producto_fk",
            //     table: "producto",
            //     column: "id_tipo_producto_fk");

            // migrationBuilder.CreateIndex(
            //     name: "id11",
            //     table: "rol",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "nombre3",
            //     table: "rol",
            //     column: "nombre",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id12",
            //     table: "tipo_producto",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "email",
            //     table: "user",
            //     column: "email",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id13",
            //     table: "user",
            //     column: "id",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "password",
            //     table: "user",
            //     column: "password",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "username",
            //     table: "user",
            //     column: "username",
            //     unique: true);

            // migrationBuilder.CreateIndex(
            //     name: "id_rol_fk",
            //     table: "userrol",
            //     column: "id_rol_fk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "orden_pedido");

            // migrationBuilder.DropTable(
            //     name: "userrol");

            // migrationBuilder.DropTable(
            //     name: "orden");

            // migrationBuilder.DropTable(
            //     name: "pedido");

            // migrationBuilder.DropTable(
            //     name: "user");

            // migrationBuilder.DropTable(
            //     name: "rol");

            // migrationBuilder.DropTable(
            //     name: "producto");

            // migrationBuilder.DropTable(
            //     name: "cliente");

            // migrationBuilder.DropTable(
            //     name: "pago");

            // migrationBuilder.DropTable(
            //     name: "tipo_producto");

            // migrationBuilder.DropTable(
            //     name: "direccion");

            // migrationBuilder.DropTable(
            //     name: "forma_pago");

            // migrationBuilder.DropTable(
            //     name: "ciudad");

            // migrationBuilder.DropTable(
            //     name: "departamento");

            // migrationBuilder.DropTable(
            //     name: "pais");
        }
    }
}
