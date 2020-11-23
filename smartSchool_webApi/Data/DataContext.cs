using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Eleve> Eleves { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<EleveDicipline> EleveDiciplines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EleveDicipline>()
                .HasKey(AD => new { AD.EleveId, AD.DisciplineId });

            builder.Entity<Professeur>()
                .HasData(new List<Professeur>(){
                    new Professeur(1, "Lauro"),
                    new Professeur(2, "Roberto"),
                    new Professeur(3, "Ronaldo"),
                    new Professeur(4, "Rodrigo"),
                    new Professeur(5, "Alexandre"),
                });

            builder.Entity<Discipline>()
                .HasData(new List<Discipline>{
                    new Discipline(1, "Matemática", 1),
                    new Discipline(2, "Física", 2),
                    new Discipline(3, "Português", 3),
                    new Discipline(4, "Inglês", 4),
                    new Discipline(5, "Programação", 5)
                });

            builder.Entity<Eleve>()
                .HasData(new List<Eleve>(){
                    new Eleve(1, "Marta", "Kent", "33225555"),
                    new Eleve(2, "Paula", "Isabela", "3354288"),
                    new Eleve(3, "Laura", "Antonia", "55668899"),
                    new Eleve(4, "Luiza", "Maria", "6565659"),
                    new Eleve(5, "Lucas", "Machado", "565685415"),
                    new Eleve(6, "Pedro", "Alvares", "456454545"),
                    new Eleve(7, "Paulo", "José", "9874512")

                });

            builder.Entity<EleveDicipline>()
                .HasData(new List<EleveDicipline>() {

                    new EleveDicipline() {EleveId = 1, DisciplineId = 2 },
                    new EleveDicipline() {EleveId = 1, DisciplineId = 4 },
                    new EleveDicipline() {EleveId = 1, DisciplineId = 5 },
                    new EleveDicipline() {EleveId = 2, DisciplineId = 1 },
                    new EleveDicipline() {EleveId = 2, DisciplineId = 2 },
                    new EleveDicipline() {EleveId = 2, DisciplineId = 5 },
                    new EleveDicipline() {EleveId = 3, DisciplineId = 1 },
                    new EleveDicipline() {EleveId = 3, DisciplineId = 2 },
                    new EleveDicipline() {EleveId = 3, DisciplineId = 3 },
                    new EleveDicipline() {EleveId = 4, DisciplineId = 1 },
                    new EleveDicipline() {EleveId = 4, DisciplineId = 4 },
                    new EleveDicipline() {EleveId = 4, DisciplineId = 5 },
                    new EleveDicipline() {EleveId = 5, DisciplineId = 4 },
                    new EleveDicipline() {EleveId = 5, DisciplineId = 5 },
                    new EleveDicipline() {EleveId = 6, DisciplineId = 1 },
                    new EleveDicipline() {EleveId = 6, DisciplineId = 2 },
                    new EleveDicipline() {EleveId = 6, DisciplineId = 3 },
                    new EleveDicipline() {EleveId = 6, DisciplineId = 4 },
                    new EleveDicipline() {EleveId = 7, DisciplineId = 1 },
                    new EleveDicipline() {EleveId = 7, DisciplineId = 2 },
                    new EleveDicipline() {EleveId = 7, DisciplineId = 3 },
                    new EleveDicipline() {EleveId = 7, DisciplineId = 4 },
                    new EleveDicipline() {EleveId = 7, DisciplineId = 5 }
                });
        }
    }
}