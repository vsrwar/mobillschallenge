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
  public class ReceitasController : ControllerBase
  {
    private IConfiguration _configuration;
    public ReceitasController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    // GET: api/<ReceitasController>
    [HttpGet]
    public IEnumerable<Receita> Get()
    {
      return new ReceitaRepository(_configuration).GetReceitas();
    }

    // GET api/<ReceitasController>/5
    [HttpGet("{id}")]
    public Receita Get(int id)
    {
      return new ReceitaRepository(_configuration).Get(id);
    }

    // POST api/<ReceitasController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
      new ReceitaRepository(_configuration).Insert(JsonConvert.DeserializeObject<Receita>(value));
    }

    // PUT api/<ReceitasController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
      Receita receita = JsonConvert.DeserializeObject<Receita>(value);
      receita.Id = id;
      new ReceitaRepository(_configuration).Update(receita);
    }

    // DELETE api/<ReceitasController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      new ReceitaRepository(_configuration).Delete(id);
    }
  }
}
