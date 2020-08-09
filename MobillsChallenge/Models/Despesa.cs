﻿using System;

namespace MobillsChallengeAPI.Models
{
  public class Despesa
  {
    public int Id { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public bool Pago { get; set; }
  }
}
