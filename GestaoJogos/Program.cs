// Program => Services => Repositories => Models + dados (DB)

using GestaoJogos.Models;
using GestaoJogos.Repositories;
using GestaoJogos.Services;

var repository = new JogoRepository();
var service = new JogoService(repository);

bool executando = true;

while (executando)
{
  Console.Clear();
  Console.WriteLine("===== GESTÃO DE JOGOS =====");
  Console.WriteLine("1 - CADASTRAR JOGO");
  Console.WriteLine("2 - LISTAR JOGOS");
  Console.WriteLine("0 - SAIR");
  Console.WriteLine("\nEscolha uma opção: ");

  string? opcao = Console.ReadLine();

  try
  {
    switch (opcao)
    {
      case "1":
        Cadastrar();
        break;
      case "2":
        Listar();
        break;
      case "0":
        executando = false;
        break;
      default:
        Console.WriteLine("Opção inválida.");
        Pausar();
        break;
    }
  }
  catch (ArgumentException ex)
  {
    Console.WriteLine($"\nErro: {ex.Message}");
    throw;
  }
}

void Listar()
{
  Console.Clear();
  Console.WriteLine("====== Jogos Cadastrados ======");

  var jogos = service.Listar();

  if (jogos.Count == 0)
  {
    Console.WriteLine("Nenhum jogo cadastrado");
  }
  else
  {
    foreach (var jogo in jogos)
    {
      ExibirJogo(jogo);
    }
  }
  Pausar();

}

void ExibirJogo(Jogo jogo)
{
  Console.WriteLine($"""
  -------------------------------
  ID: {jogo.Id}
  Nome: {jogo.Nome}
  Desenvolvedora: {jogo.Desenvolvedora}
  Gênero: {jogo.Genero}
  Ano: {jogo.AnoLancamento}
  Preço: {jogo.Preco}
  """);
}

void Pausar()
{
  Console.WriteLine("\nPressione ENTER para continuar...");
  Console.ReadLine();
}


void Cadastrar()
{
  Console.Clear();
  Console.WriteLine("========= CADASTRAR JOGO ==========");

  var jogo = LerDadosJogo();

  service.Cadastrar(jogo);

  Console.WriteLine("\nJogo cadastrado com sucesso!");
  Pausar();
}


Jogo LerDadosJogo()
{
  Console.Write("Nome: ");
  string nome = Console.ReadLine()!;

  Console.Write("Desenvolvedora: ");
  string desenvolvedora = Console.ReadLine()!;

  Console.Write("Gênero: ");
  string genero = Console.ReadLine()!;

  Console.Write("Ano lançamento: ");
  int ano = int.Parse(Console.ReadLine()!);

  Console.Write("Preço: ");
  decimal preco = decimal.Parse(Console.ReadLine()!);

  return new Jogo
  {
    Nome = nome,
    Desenvolvedora = desenvolvedora,
    Genero = genero,
    AnoLancamento = ano,
    Preco = preco
  };

}

