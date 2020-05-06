﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wepApi.Models;

namespace wepApi.Models
{
    [DbContext(typeof(appContext))]
    partial class appContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("wepApi.Models.Mesaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("content")
                        .HasColumnType("text");

                    b.Property<int>("isRead")
                        .HasColumnType("integer");

                    b.Property<string>("subject")
                        .HasColumnType("text");

                    b.Property<int>("userID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("userID");

                    b.ToTable("Mesajs");
                });

            modelBuilder.Entity("wepApi.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("pass")
                        .HasColumnType("text");

                    b.Property<string>("userLastName")
                        .HasColumnType("text");

                    b.Property<string>("userName")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("wepApi.Models.Mesaj", b =>
                {
                    b.HasOne("wepApi.Models.User", null)
                        .WithMany("Mesajs")
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
