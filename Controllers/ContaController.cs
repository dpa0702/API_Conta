using Banco.Data;
using Banco.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Banco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly DataContext _context;

        public ContaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Conta>>> Get()
        {
            return Ok(await _context.Contas.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Conta>> Get(int id)
        {
            var hero = await _context.Contas.FindAsync(id);
            if (hero == null)
                return BadRequest("Account not found.");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<Conta>>> AddAccount(Conta conta)
        {
            _context.Contas.Add(conta);
            await _context.SaveChangesAsync();

            return Ok(await _context.Contas.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Conta>>> UpdateAccount(Conta request)
        {
            var dbAccount = await _context.Contas.FindAsync(request.Id);
            if (dbAccount == null)
                return BadRequest("Account not found.");

            dbAccount.Nome = request.Nome;
            dbAccount.Descricao = request.Descricao;

            await _context.SaveChangesAsync();

            return Ok(await _context.Contas.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Conta>>> Delete(int id)
        {
            var dbAccount = await _context.Contas.FindAsync(id);
            if (dbAccount == null)
                return BadRequest("Account not found.");

            _context.Contas.Remove(dbAccount);
            await _context.SaveChangesAsync();

            return Ok(await _context.Contas.ToListAsync());
        }
    }
}
