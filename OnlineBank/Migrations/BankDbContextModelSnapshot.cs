﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBank.Models;

namespace OnlineBank.Migrations
{
    [DbContext(typeof(BankDbContext))]
    partial class BankDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineBank.Models.Account", b =>
                {
                    b.Property<long>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("OnlineBank.Models.Operation", b =>
                {
                    b.Property<int>("OperationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<bool>("ConfirmOnPhone")
                        .HasColumnType("bit");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Delivered")
                        .HasColumnType("bit");

                    b.HasKey("OperationID");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("OnlineBank.Models.Transfer+TransferLine", b =>
                {
                    b.Property<int>("TransferLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AccountID")
                        .HasColumnType("bigint");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("OperationID")
                        .HasColumnType("int");

                    b.Property<double>("UsdExchangeRate")
                        .HasColumnType("float");

                    b.HasKey("TransferLineID");

                    b.HasIndex("AccountID");

                    b.HasIndex("OperationID");

                    b.ToTable("TransferLine");
                });

            modelBuilder.Entity("OnlineBank.Models.Transfer+TransferLine", b =>
                {
                    b.HasOne("OnlineBank.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("OnlineBank.Models.Operation", null)
                        .WithMany("Lines")
                        .HasForeignKey("OperationID");
                });
#pragma warning restore 612, 618
        }
    }
}
