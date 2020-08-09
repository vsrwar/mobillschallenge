using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using MobillsChallengeAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MobillsChallengeAPI.Repositories
{
  public class DespesaRepository
  {
    private IConfiguration _configuration;

    public DespesaRepository(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    internal decimal GetTotalDespesas()
    {
      try
      {
        return this.GetDespesas().Sum(x => x.Valor);
      }
      catch (Exception)
      {
        throw;
      }
    }
    internal decimal GetTotalDespesasPagas()
    {
      try
      {
        return this.GetDespesas().Where(x => x.Pago).Sum(x => x.Valor);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public bool Insert(Despesa despesa)
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          if (connection.Insert(despesa) > 0)
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

    public IEnumerable<Despesa> GetDespesas()
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          return connection.GetAll<Despesa>();
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

    public Despesa Get(int id)
    {
      Despesa despesa;
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          despesa = connection.Get<Despesa>(id);
        }

        return despesa;
      }
      catch (Exception)
      {
        throw;
      }
    }

    public bool Update(Despesa despesa)
    {
      try
      {
        using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
        {
          return connection.Update(despesa);
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
          return connection.Delete(new Despesa() { Id = id });
        }
      }
      catch (Exception)
      {
        throw;
      }
    }

  }
}
