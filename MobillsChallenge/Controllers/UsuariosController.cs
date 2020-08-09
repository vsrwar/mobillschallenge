using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MobillsChallengeAPI.Models;
using MobillsChallengeAPI.Repositories;

namespace MobillsChallengeAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsuariosController : ControllerBase
  {
    private Usuario usuario;
    private IConfiguration _configuration;

    public UsuariosController(IConfiguration configuration)
    {
      _configuration = configuration;
      usuario = new Usuario()
      {
        Id = 1,
        Nome = "Vinicius Rocha",
        TotalReceitas = new ReceitaRepository(_configuration).GetTotalReceitas(),
        TotalReceitasRecebidas = new ReceitaRepository(_configuration).GetTotalReceitasRecebidas(),
        TotalDespesas = new DespesaRepository(_configuration).GetTotalDespesas(),
        TotalDespesasPagas = new DespesaRepository(_configuration).GetTotalDespesasPagas(),
        SaldoAtual = new ReceitaRepository(_configuration).GetTotalReceitasRecebidas() - new DespesaRepository(_configuration).GetTotalDespesasPagas()
      };
    }

    // GET: api/<UsuariosController>
    [HttpGet]
    public Usuario Get()
    {
      return usuario;
    }

    // GET api/<UsuariosController>/5
    [HttpGet("{id}")]
    public Usuario Get(int id)
    {
      return usuario;
    }

    // POST api/<UsuariosController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<UsuariosController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UsuariosController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
