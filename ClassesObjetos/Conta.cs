
namespace ClassesObjetos
{
    public class Conta
    {
        public decimal Saldo = 0;

        public void Depositar(decimal valor)
        {
            Saldo += valor; // Saldo = Saldo + valor;
            Console.WriteLine($"Saldo atualizado: {Saldo:C}");
        }
    }
}