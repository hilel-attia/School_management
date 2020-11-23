using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Discipline
    {
        public Discipline() { }
        public Discipline(int id, string Nom, int professeurId)
        {
            this.Id = id;
            this.Nom = Nom;
            this.ProfesseurId = professeurId;
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public int ProfesseurId { get; set; }
        public Professeur Professeur { get; set; }
        public IEnumerable<EleveDicipline> EleveDiciplines { get; set; }
    }
}