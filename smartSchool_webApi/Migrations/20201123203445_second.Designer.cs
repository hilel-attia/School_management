﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool_WebAPI.Data;

namespace smartSchool_webApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201123203445_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfesseurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfesseurId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Matemática",
                            ProfesseurId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nom = "Física",
                            ProfesseurId = 2
                        },
                        new
                        {
                            Id = 3,
                            Nom = "Português",
                            ProfesseurId = 3
                        },
                        new
                        {
                            Id = 4,
                            Nom = "Inglês",
                            ProfesseurId = 4
                        },
                        new
                        {
                            Id = 5,
                            Nom = "Programação",
                            ProfesseurId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Eleve", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eleves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Marta",
                            Prenom = "Kent",
                            Telephone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Nom = "Paula",
                            Prenom = "Isabela",
                            Telephone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Nom = "Laura",
                            Prenom = "Antonia",
                            Telephone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Nom = "Luiza",
                            Prenom = "Maria",
                            Telephone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Nom = "Lucas",
                            Prenom = "Machado",
                            Telephone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Nom = "Pedro",
                            Prenom = "Alvares",
                            Telephone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Nom = "Paulo",
                            Prenom = "José",
                            Telephone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.EleveDicipline", b =>
                {
                    b.Property<int>("EleveId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("int");

                    b.HasKey("EleveId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("EleveDiciplines");

                    b.HasData(
                        new
                        {
                            EleveId = 1,
                            DisciplineId = 2
                        },
                        new
                        {
                            EleveId = 1,
                            DisciplineId = 4
                        },
                        new
                        {
                            EleveId = 1,
                            DisciplineId = 5
                        },
                        new
                        {
                            EleveId = 2,
                            DisciplineId = 1
                        },
                        new
                        {
                            EleveId = 2,
                            DisciplineId = 2
                        },
                        new
                        {
                            EleveId = 2,
                            DisciplineId = 5
                        },
                        new
                        {
                            EleveId = 3,
                            DisciplineId = 1
                        },
                        new
                        {
                            EleveId = 3,
                            DisciplineId = 2
                        },
                        new
                        {
                            EleveId = 3,
                            DisciplineId = 3
                        },
                        new
                        {
                            EleveId = 4,
                            DisciplineId = 1
                        },
                        new
                        {
                            EleveId = 4,
                            DisciplineId = 4
                        },
                        new
                        {
                            EleveId = 4,
                            DisciplineId = 5
                        },
                        new
                        {
                            EleveId = 5,
                            DisciplineId = 4
                        },
                        new
                        {
                            EleveId = 5,
                            DisciplineId = 5
                        },
                        new
                        {
                            EleveId = 6,
                            DisciplineId = 1
                        },
                        new
                        {
                            EleveId = 6,
                            DisciplineId = 2
                        },
                        new
                        {
                            EleveId = 6,
                            DisciplineId = 3
                        },
                        new
                        {
                            EleveId = 6,
                            DisciplineId = 4
                        },
                        new
                        {
                            EleveId = 7,
                            DisciplineId = 1
                        },
                        new
                        {
                            EleveId = 7,
                            DisciplineId = 2
                        },
                        new
                        {
                            EleveId = 7,
                            DisciplineId = 3
                        },
                        new
                        {
                            EleveId = 7,
                            DisciplineId = 4
                        },
                        new
                        {
                            EleveId = 7,
                            DisciplineId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Professeur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professeurs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Lauro"
                        },
                        new
                        {
                            Id = 2,
                            Nom = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Nom = "Ronaldo"
                        },
                        new
                        {
                            Id = 4,
                            Nom = "Rodrigo"
                        },
                        new
                        {
                            Id = 5,
                            Nom = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.Discipline", b =>
                {
                    b.HasOne("SmartSchool_WebAPI.Models.Professeur", "Professeur")
                        .WithMany("Disciplines")
                        .HasForeignKey("ProfesseurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool_WebAPI.Models.EleveDicipline", b =>
                {
                    b.HasOne("SmartSchool_WebAPI.Models.Discipline", "Discipline")
                        .WithMany("EleveDiciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool_WebAPI.Models.Eleve", "Eleve")
                        .WithMany("EleveDiciplines")
                        .HasForeignKey("EleveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
