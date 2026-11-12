using Heranca;

// Funcionario f = new Funcionario();

Gerente gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Codigo = 123;
// gerente.Salario = 5000m;
gerente.DefinirSalario(5000m);

gerente.Trabalhar();
gerente.GerenciarEquipe();

Gerente gerente2 = new Gerente("Maria", 7000m, 456);

gerente.ExibirSalario();
gerente2.ExibirSalario();





Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

f1.Trabalhar();
f2.Trabalhar();

Console.WriteLine(f1.CalcularBonus());
Console.WriteLine(f2.CalcularBonus());

Desenvolvedor d1 = new Desenvolvedor();

IPagamento pix = new PagamentoPix();
IPagamento cartao = new PagamentoCartao();

pix.Pagar(150m);
cartao.Pagar(200m);



