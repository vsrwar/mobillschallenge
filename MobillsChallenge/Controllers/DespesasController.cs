using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MobillsChallengeAPI.Models;
using MobillsChallengeAPI.Repositories;
using Newtonsoft.Json;

namespace MobillsChallengeAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DespesasController : ControllerBase
  {
    private IConfiguration _configuration;
    public DespesasController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    // GET: api/<DespesasController>
    [HttpGet]
    public IEnumerable<Despesa> Get()
    {
      return new DespesaRepository(_configuration).GetDespesas();
    }

    // GET api/<DespesasController>/5
    [HttpGet("{id}")]
    public Despesa Get(int id)
    {
      return new DespesaRepository(_configuration).Get(id);
    }

    // POST api/<DespesasController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
      new DespesaRepository(_configuration).Insert(JsonConvert.DeserializeObject<Despesa>(value));
    }

    // PUT api/<DespesasController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
      Despesa despesa = JsonConvert.DeserializeObject<Despesa>(value);
      despesa.Id = id;
      new DespesaRepository(_configuration).Update(despesa);
    }

    // DELETE api/<DespesasController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      new DespesaRepository(_configuration).Delete(id);
    }
  }
}
