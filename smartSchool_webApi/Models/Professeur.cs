using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Professeur
    {
        public Professeur() { }
        public Professeur(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;

        }
        public int Id { get; set; }
        public string Nom { get; set; }
        // public string Dicipline { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }
    }
}