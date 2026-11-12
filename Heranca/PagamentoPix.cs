namespace Heranca
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(decimal valor)
        {
            //   throw new NotImplementedException(); // Metodo para não gerar erro, caso o metodo seja utilizado
            Console.WriteLine($"Pagamento via Pix: {valor:C}");
        }

    }
}