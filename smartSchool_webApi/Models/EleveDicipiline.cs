
namespace SmartSchool_WebAPI.Models
{
    public class EleveDicipline
    {
        public EleveDicipline() { }
        public EleveDicipline(int eleveId, int disciplineId)
        {
            this.EleveId = eleveId;
            this.DisciplineId = disciplineId;
        }
        public int EleveId { get; set; }
        public Eleve Eleve { get; set; }

        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; }
    }
}