﻿// <auto-generated />
using Keypear.Server.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Keypear.Server.Shared.Migrations
{
    [DbContext(typeof(KyprDbContext))]
    [Migration("20220318174116_RemovedVaultFastAndFullContent")]
    partial class RemovedVaultFastAndFullContent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Keypear.Shared.Models.Persisted.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("MasterKeySalt")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PrivateKeyEnc")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PublicKey")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("SigPrivateKeyEnc")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("SigPublicKey")
                        .HasColumnType("BLOB");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Verifier")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasAlternateKey("Username");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Keypear.Shared.Models.Persisted.Grant", b =>
                {
                    b.Property<Guid>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("VaultId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("SecretKeyEnc")
                        .HasColumnType("BLOB");

                    b.HasKey("AccountId", "VaultId");

                    b.HasIndex("VaultId");

                    b.ToTable("Grants");
                });

            modelBuilder.Entity("Keypear.Shared.Models.Persisted.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ContentEnc")
                        .HasColumnType("BLOB");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("SummaryEnc")
                        .HasColumnType("BLOB");

                    b.Property<Guid>("VaultId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("Keypear.Shared.Models.Persisted.Vault", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("SummaryEnc")
                        .HasColumnType("BLOB");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vaults");
                });

            modelBuilder.Entity("Keypear.Shared.Models.Persisted.Grant", b =>
                {
                    b.HasOne("Keypear.Shared.Models.Persisted.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Keypear.Shared.Models.Persisted.Vault", "Vault")
                        .WithMany()
                        .HasForeignKey("VaultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Vault");
                });
#pragma warning restore 612, 618
        }
    }
}
