
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Eleve[]> GetAllElevesAsync(bool includeDiscipline = false)
        {
            IQueryable<Eleve> query = _context.Eleves;

            if (includeDiscipline)
            {
                query = query.Include(pe => pe.EleveDiciplines)
                             .ThenInclude(ad => ad.Discipline)
                             .ThenInclude(d => d.Professeur);
            }

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Eleve> GetEleveAsyncById(int eleveId, bool includeDiscipline)
        {
            IQueryable<Eleve> query = _context.Eleves;

            if (includeDiscipline)
            {
                query = query.Include(a => a.EleveDiciplines)
                             .ThenInclude(ad => ad.Discipline)
                             .ThenInclude(d => d.Professeur);
            }

            query = query.AsNoTracking()
                         .OrderBy(eleve => eleve.Id)
                         .Where(eleve => eleve.Id == eleveId);

            return await query.FirstOrDefaultAsync();
        }
        public async Task<Eleve[]> GetElevesAsyncByDisciplinaId(int disciplineId, bool includeDiscipline)
        {
            IQueryable<Eleve> query = _context.Eleves;

            if (includeDiscipline)
            {
                query = query.Include(a => a.EleveDiciplines)
                             .ThenInclude(ad => ad.Discipline)
                             .ThenInclude(d => d.Professeur);
            }

            query = query.AsNoTracking()
                         .OrderBy(eleve => eleve.Id)
                         .Where(eleve => eleve.EleveDiciplines.Any(ad => ad.DisciplineId == disciplineId));

            return await query.ToArrayAsync();
        }

        public async Task<Professeur[]> GetProfesseurAsyncByEleveId(int eleveId, bool includeDiscipline)
        {
            IQueryable<Professeur> query = _context.Professeurs;

            if (includeDiscipline)
            {
                query = query.Include(p => p.Disciplines);
            }

            query = query.AsNoTracking()
                         .OrderBy(eleve => eleve.Id)
                         .Where(eleve => eleve.Disciplines.Any(d =>
                            d.EleveDiciplines.Any(ad => ad.EleveId == eleveId)));

            return await query.ToArrayAsync();
        }

        public async Task<Professeur[]> GetAllProfesseuresAsync(bool includeDisciplines = true)
        {
            IQueryable<Professeur> query = _context.Professeurs;

            if (includeDisciplines)
            {
                query = query.Include(c => c.Disciplines);
            }

            query = query.AsNoTracking()
                         .OrderBy(professeur => professeur.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Professeur> GetProfesseurAsyncById(int professeurId, bool includeDisciplines = true)
        {
            IQueryable<Professeur> query = _context.Professeurs;

            if (includeDisciplines)
            {
                query = query.Include(pe => pe.Disciplines);
            }

            query = query.AsNoTracking()
                         .OrderBy(professeur => professeur.Id)
                         .Where(professeur => professeur.Id == professeurId);

            return await query.FirstOrDefaultAsync();
        }

        public Task<Eleve[]> GetElevesAsyncByDisciplineId(int disciplineId, bool includeDiscipline)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professeur[]> GetProfesseuresAsyncByEleveId(int eleveId, bool includeDiscipline)
        {
            throw new System.NotImplementedException();
        }
    }
}