using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebAPI.Data;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfesseurController : ControllerBase
    {
        private readonly IRepository _repo;

        public ProfesseurController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllProfesseuresAsync(true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{ProfesseurId}")]
        public async Task<IActionResult> GetByProfesseurId(int ProfessorId)
        {
            try
            {
                var result = await _repo.GetProfesseurAsyncById(ProfessorId, true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("ByEleve/{eleveId}")]
        public async Task<IActionResult> GetByAlunoId(int alunoId)
        {
            try
            {
                var result = await _repo.GetProfesseuresAsyncByEleveId(alunoId, true);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Professeur model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("{professeurId}")]
        public async Task<IActionResult> put(int professeurId, Professeur model)
        {
            try
            {
                var Professeur = await _repo.GetProfesseurAsyncById(professeurId, false);
                if (Professeur == null) return NotFound();

                _repo.Update(model);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{professeurId}")]
        public async Task<IActionResult> delete(int professeurId)
        {
            try
            {
                var Professeur = await _repo.GetProfesseurAsyncById(professeurId, false);
                if (Professeur == null) return NotFound();

                _repo.Delete(Professeur);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok(new { message = "Deleted" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }
    }
}