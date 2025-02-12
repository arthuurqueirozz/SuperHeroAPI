using System.Reflection.Metadata;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Data;
using SuperHeroAPI.DTOs;
using SuperHeroAPI.Entities;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = await _context.SuperHeroes
                .Include(s => s.Suit)
                .Include(p => p.PlaceOfAction)
                .ToListAsync();

            return Ok(heroes);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero).FromSqlRaw($"Add_suit {}");

            await _context.SaveChangesAsync();

            if (hero is null)
                return NotFound();



            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SuperHero>>> ReturnCityHeroes(int id)
        {
            SqlParameter param1 = new SqlParameter("@id_cidade", id);

            var result = _context.Database.SqlQueryRaw<SuperHeroByCityIdDTO>("exec usp_StoredProcedure @id_cidade", param1).ToList();

            return Ok(result);
        }
    }
}
