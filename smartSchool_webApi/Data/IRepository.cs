using System.Threading.Tasks;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public interface IRepository
    {
        //Generale
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ELEVE
        Task<Eleve[]> GetAllElevesAsync(bool includeProffeseur);
        Task<Eleve[]> GetElevesAsyncByDisciplineId(int disciplineId, bool includeDiscipline);
        Task<Eleve> GetEleveAsyncById(int eleveId, bool includeProffeseur);

        //Professeur
        Task<Professeur[]> GetAllProfesseuresAsync(bool includeEleve);
        Task<Professeur> GetProfesseurAsyncById(int professeurId, bool includeEleve);
        Task<Professeur[]> GetProfesseuresAsyncByEleveId(int eleveId, bool includeDiscipline);
    }
}
