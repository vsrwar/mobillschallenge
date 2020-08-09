namespace MobillsChallengeAPI.Models
{
  public class Usuario
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal SaldoAtual { get; set; }
    public decimal TotalReceitas { get; set; }
    public decimal TotalReceitasRecebidas { get; set; }
    public decimal TotalDespesas { get; set; }
    public decimal TotalDespesasPagas { get; set; }
  }
}
