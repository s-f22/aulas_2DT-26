namespace Heranca
{
  public class PagamentoCartao : IPagamento
  {
    public void Pagar(decimal valor)
    {
      Console.WriteLine($"Pagamento via cartão: {valor:C}");
    }
  }
}