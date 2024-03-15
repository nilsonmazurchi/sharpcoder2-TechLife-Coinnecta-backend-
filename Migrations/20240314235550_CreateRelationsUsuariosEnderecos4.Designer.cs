﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sharpcoder2_TechLife_Coinnecta_Backend.Domain;

#nullable disable

namespace sharpcoder2_TechLife_Coinnecta_Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240314235550_CreateRelationsUsuariosEnderecos4")]
    partial class CreateRelationsUsuariosEnderecos4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("sharpcoder2_TechLife_Coinnecta_Backend.Domain.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complemento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Logradouro")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PontoRef")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uf")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("sharpcoder2_TechLife_Coinnecta_Backend.Domain.Model.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DiaNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoPessoa")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("sharpcoder2_TechLife_Coinnecta_Backend.Domain.Model.Usuario", b =>
                {
                    b.HasOne("sharpcoder2_TechLife_Coinnecta_Backend.Domain.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
