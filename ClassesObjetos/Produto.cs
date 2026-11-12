namespace ClassesObjetos
{
    public class Produto
    {
        int Quantidade; // => Campo: é uma forma simplificada de representar atributos
        public string? Nome { get; set; }
        public decimal Preco { get; private set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - {Preco:C}");
        }

        public void AlterarPreco(decimal novoPreco)
        {
            if (novoPreco > 0)
            {
                Preco = novoPreco;
            }
            else
            {
                Console.WriteLine("Valor não permitido");
            }
        }

        public Produto() // O metodo construtor sempre terá o mesmo nome da classe
        {
            Nome = "Não informado";
            Preco = 20;
        }

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Preco = valor;
        }

       



    }
}