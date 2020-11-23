using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Eleve
    {
        public Eleve() { }
        public Eleve(int id, string nom, string prenom, string telephone)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public IEnumerable<EleveDicipline> EleveDiciplines { get; set; }
    }
}