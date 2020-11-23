using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebAPI.Data;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EleveController : ControllerBase
    {
        private readonly IRepository _repo;

        public EleveController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _repo.GetAllElevesAsync(true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{EleveId}")]
        public async Task<IActionResult> GetByEleveId(int EleveId)
        {
            try
            {
                var result = await _repo.GetEleveAsyncById(EleveId, true);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("ByDiscipline/{disciplineId}")]
        public async Task<IActionResult> GetByDisciplineId(int disciplineId)
        {
            try
            {
                var result = await _repo.GetElevesAsyncByDisciplineId(disciplineId, false);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Eleve model)
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

        [HttpPut("{eleveId}")]
        public async Task<IActionResult> put(int eleveId, Eleve model)
        {
            try
            {
                var eleve = await _repo.GetEleveAsyncById(eleveId, false);
                if (eleve == null) return NotFound();

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

        [HttpDelete("{eleveId}")]
        public async Task<IActionResult> delete(int eleveId)
        {
            try
            {
                var eleve = await _repo.GetEleveAsyncById(eleveId, false);
                if (eleve == null) return NotFound();

                _repo.Delete(eleve);

                if (await _repo.SaveChangesAsync())
                {
                    return Ok( new { message = "deleted??" });
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