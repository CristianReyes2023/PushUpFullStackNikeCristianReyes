﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(NikeContext))]
    [Migration("20231214170109_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int")
                        .HasColumnName("id_departamento_fk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique();

                    b.HasIndex(new[] { "IdDepartamentoFk" }, "id_departamento_fk");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique();

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<int>("IdDireccionFk")
                        .HasColumnType("int")
                        .HasColumnName("id_direccion_fk");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int")
                        .HasColumnName("id_persona");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<int>("Telefono")
                        .HasColumnType("int")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id1");

                    b.HasIndex(new[] { "IdDireccionFk" }, "id_direccion_fk");

                    b.HasIndex(new[] { "IdPersona" }, "id_persona")
                        .IsUnique();

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int")
                        .HasColumnName("id_pais_fk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id2");

                    b.HasIndex(new[] { "IdPaisFk" }, "id_pais_fk");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique()
                        .HasDatabaseName("nombre1");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Bis")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("bis")
                        .IsFixedLength();

                    b.Property<string>("CardinalPrimario")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinal_primario")
                        .IsFixedLength();

                    b.Property<string>("CardinalSecundario")
                        .HasMaxLength(10)
                        .HasColumnType("char(10)")
                        .HasColumnName("cardinal_secundario")
                        .IsFixedLength();

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("complemento");

                    b.Property<int?>("IdCiudadFk")
                        .HasColumnType("int")
                        .HasColumnName("id_ciudad_fk");

                    b.Property<string>("LetraPrincipal")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letra_principal")
                        .IsFixedLength();

                    b.Property<string>("LetraSecundaria")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)")
                        .HasColumnName("letra_secundaria")
                        .IsFixedLength();

                    b.Property<short>("NumeroPrincipal")
                        .HasColumnType("smallint")
                        .HasColumnName("numero_principal");

                    b.Property<short>("NumeroSecundario")
                        .HasColumnType("smallint")
                        .HasColumnName("numero_secundario");

                    b.Property<string>("TipoVia")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("tipo_via");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id3");

                    b.HasIndex(new[] { "IdCiudadFk" }, "id_ciudad_fk");

                    b.ToTable("direccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id4");

                    b.ToTable("forma_pago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int>("IdProductoFk")
                        .HasColumnType("int")
                        .HasColumnName("id_producto_fk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id5");

                    b.HasIndex(new[] { "IdProductoFk" }, "id_producto_fk");

                    b.ToTable("orden", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OrdenPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdOrdenFk")
                        .HasColumnType("int")
                        .HasColumnName("id_orden_fk");

                    b.Property<int>("IdPedidoFk")
                        .HasColumnType("int")
                        .HasColumnName("id_pedido_fk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id6");

                    b.HasIndex(new[] { "IdOrdenFk" }, "id_orden_fk");

                    b.HasIndex(new[] { "IdPedidoFk" }, "id_pedido_fk");

                    b.ToTable("orden_pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateOnly>("FechaPago")
                        .HasColumnType("date")
                        .HasColumnName("fecha_pago");

                    b.Property<int>("IdFormaPagoFk")
                        .HasColumnType("int")
                        .HasColumnName("id_forma_pago_fk");

                    b.Property<int>("Total")
                        .HasColumnType("int")
                        .HasColumnName("total");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id7");

                    b.HasIndex(new[] { "IdFormaPagoFk" }, "id_forma_pago_fk");

                    b.ToTable("pago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id8");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique()
                        .HasDatabaseName("nombre2");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("id_cliente_fk");

                    b.Property<int>("IdPagoFk")
                        .HasColumnType("int")
                        .HasColumnName("id_pago_fk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id9");

                    b.HasIndex(new[] { "IdClienteFk" }, "id_cliente_fk");

                    b.HasIndex(new[] { "IdPagoFk" }, "id_pago_fk");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdTipoProductoFk")
                        .HasColumnType("int")
                        .HasColumnName("id_tipo_producto_fk");

                    b.Property<string>("Imagen")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("imagen");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<double>("Precio")
                        .HasColumnType("double")
                        .HasColumnName("precio");

                    b.Property<int>("StockActual")
                        .HasColumnType("int")
                        .HasColumnName("stock_actual");

                    b.Property<int>("StockMax")
                        .HasColumnType("int")
                        .HasColumnName("stock_max");

                    b.Property<int>("StockMin")
                        .HasColumnType("int")
                        .HasColumnName("stock_min");

                    b.Property<string>("Talla")
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("talla");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id10");

                    b.HasIndex(new[] { "IdTipoProductoFk" }, "id_tipo_producto_fk");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id11");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique()
                        .HasDatabaseName("nombre3");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoProducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id12");

                    b.ToTable("tipo_producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Email" }, "email")
                        .IsUnique();

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id13");

                    b.HasIndex(new[] { "Password" }, "password")
                        .IsUnique();

                    b.HasIndex(new[] { "Username" }, "username")
                        .IsUnique();

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Userrol", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int")
                        .HasColumnName("id_user_fk");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int")
                        .HasColumnName("id_rol_fk");

                    b.HasKey("IdUserFk", "IdRolFk")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "IdRolFk" }, "id_rol_fk");

                    b.ToTable("userrol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "IdDepartamentoFkNavigation")
                        .WithMany("Ciudads")
                        .HasForeignKey("IdDepartamentoFk")
                        .IsRequired()
                        .HasConstraintName("ciudad_ibfk_1");

                    b.Navigation("IdDepartamentoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Direccion", "IdDireccionFkNavigation")
                        .WithMany("Clientes")
                        .HasForeignKey("IdDireccionFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("cliente_ibfk_1");

                    b.Navigation("IdDireccionFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisFkNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .IsRequired()
                        .HasConstraintName("departamento_ibfk_1");

                    b.Navigation("IdPaisFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "IdCiudadFkNavigation")
                        .WithMany("Direccions")
                        .HasForeignKey("IdCiudadFk")
                        .HasConstraintName("direccion_ibfk_1");

                    b.Navigation("IdCiudadFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Orden", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "IdProductoFkNavigation")
                        .WithMany("Ordens")
                        .HasForeignKey("IdProductoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("orden_ibfk_1");

                    b.Navigation("IdProductoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.OrdenPedido", b =>
                {
                    b.HasOne("Domain.Entities.Orden", "IdOrdenFkNavigation")
                        .WithMany("OrdenPedidos")
                        .HasForeignKey("IdOrdenFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("orden_pedido_ibfk_1");

                    b.HasOne("Domain.Entities.Pedido", "IdPedidoFkNavigation")
                        .WithMany("OrdenPedidos")
                        .HasForeignKey("IdPedidoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("orden_pedido_ibfk_2");

                    b.Navigation("IdOrdenFkNavigation");

                    b.Navigation("IdPedidoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.HasOne("Domain.Entities.FormaPago", "IdFormaPagoFkNavigation")
                        .WithMany("Pagos")
                        .HasForeignKey("IdFormaPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pago_ibfk_1");

                    b.Navigation("IdFormaPagoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pedido_ibfk_1");

                    b.HasOne("Domain.Entities.Pago", "IdPagoFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("pedido_ibfk_2");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdPagoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.TipoProducto", "IdTipoProductoFkNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdTipoProductoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("producto_ibfk_1");

                    b.Navigation("IdTipoProductoFkNavigation");
                });

            modelBuilder.Entity("Userrol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", null)
                        .WithMany()
                        .HasForeignKey("IdRolFk")
                        .IsRequired()
                        .HasConstraintName("userrol_ibfk_2");

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("IdUserFk")
                        .IsRequired()
                        .HasConstraintName("userrol_ibfk_1");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Direccions");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudads");
                });

            modelBuilder.Entity("Domain.Entities.Direccion", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Domain.Entities.FormaPago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("Domain.Entities.Orden", b =>
                {
                    b.Navigation("OrdenPedidos");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Navigation("OrdenPedidos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("Ordens");
                });

            modelBuilder.Entity("Domain.Entities.TipoProducto", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
