using System;

namespace MobillsChallengeAPI.Models
{
  public class Receita
  {
    public int Id { get; set;  }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public bool Recebido { get; set; }
  }
}
