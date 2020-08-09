using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using MobillsChallengeAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MobillsChallengeAPI.Repositories
{
  public class ReceitaRepository
  {
    private IConfiguration _configuration;

    public ReceitaRepository(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    internal decimal GetTotalReceitas()
    {
      try
      {
        return this.GetReceitas().Sum(x => x.Valor);
      }
      catch (Exception)
      {
        throw;
      }
    }
    internal decimal GetTotalReceitasRecebidas()
    {
      try
      {
        return this.GetReceitas().Where(x => x.Recebido).Sum(x => x.Valor);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public bool Insert(Receita receita)
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          if (connection.Insert(receita) > 0)
          {
            return true;
          }
          return false;
        }

      }
      catch (Exception)
      {
        throw;
      }
    }

    public IEnumerable<Receita> GetReceitas()
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          return connection.GetAll<Receita>();
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    public Receita Get(int id)
    {
      Receita receita;
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          receita = connection.Get<Receita>(id);
        }

        return receita;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public bool Update(Receita receita)
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          return connection.Update(receita);
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    public bool Delete(int id)
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          return connection.Delete(new Receita() { Id = id });
        }
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
