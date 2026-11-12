
/*
Console.WriteLine("Hello, World!");
// Exibe uma mensagem no console e pula para a próxima linha.

Console.Write("Digite seu nome:");
// Exibe uma mensagem sem pular para a próxima linha.

string? nome = Console.ReadLine();
// Lê o texto digitado pelo usuário e armazena na variável nome.
// O ? indica que a variável também pode receber null.

Console.WriteLine(nome);
// Exibe o nome digitado pelo usuário.
*/

// Comentário de uma linha: utilizado para explicar o código.

// Declaração de variáveis
string nome = "Samuel";
int idade = 20;

// Concatenação
// Junta textos e variáveis utilizando o operador +.
Console.WriteLine("Meu nome é " + nome + ", tenho " + idade + " anos");

// Interpolação
// Permite inserir variáveis diretamente no texto utilizando $ e {}.
Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos");

// Formatação de valores
decimal preco = 1250.5m;
// decimal é utilizado para valores monetários.
// O sufixo m identifica um valor do tipo decimal.

// Exibe o preço com duas casas decimais.
Console.WriteLine($"Preço: {preco:F2}");

// Exibe o preço no formato de moeda conforme a cultura configurada.
Console.WriteLine($"Preço: {preco:C}");


// ======================================
// CONVERSÕES DE TIPO
// ======================================

// Conversão implícita
/*
int numero = 10;

// Converte automaticamente int para double.
// Não precisa informar o tipo de conversão.
double resultado = numero;

Console.WriteLine(resultado);
*/


// Conversão explícita
// Utiliza (int) para converter double em int.
// A parte decimal é descartada, não ocorre arredondamento.
double valor = 9.8;
int numero = (int)valor;

Console.WriteLine(numero); // Resultado: 9


// Texto que será convertido em número.
string texto = "25z";

/*
// Parse
// Converte uma string para int.
// Se o texto não for um número válido, gera uma exceção.
int i = int.Parse(texto);

Console.WriteLine(i);
*/


// TryParse
// Tenta converter o texto para int sem gerar exceção.
// Retorna true se a conversão funcionar e false se falhar.
if (int.TryParse(texto, out int resultado))
{
    // Executa quando a conversão é realizada com sucesso.
    Console.WriteLine($"Idade: {resultado}");
}
else
{
    // Executa quando o texto não pode ser convertido.
    Console.WriteLine($"Valor inválido: {texto}\n");
}


// ======================================
// SWITCH
// ======================================

/*
Console.WriteLine("""
1 - Cadastrar
2 - Consultar
3 - Excluir
""");
// Exibe um texto em várias linhas utilizando string literal.

int opcao;

// do executa o bloco pelo menos uma vez.
do
{
    Console.Write("\nDigite uma opção: ");

    // Lê o valor digitado e converte para int.
    // O ! informa ao compilador que não esperamos um valor null.
    opcao = int.Parse(Console.ReadLine()!);

// while repete enquanto a opção estiver fora do intervalo permitido.
} while (opcao < 1 || opcao > 3);


// switch verifica o valor da variável e executa o case correspondente.
switch (opcao)
{
    case 1:
        Console.WriteLine("A opção selecionada foi Cadastrar");
        break; // Encerra a execução do switch.

    case 2:
        Console.WriteLine("A opção selecionada foi Consultar");
        break;

    case 3:
        Console.WriteLine("A opção selecionada foi Excluir");
        break;

    default:
        // Executa quando nenhum case corresponde ao valor.
        Console.WriteLine("Valor inválido");
        break;
}
*/


// ======================================
// MÉTODOS
// ======================================

// void indica que o método não retorna nenhum valor.
// Saudacao é o nome do método.
void Saudacao()
{
    Console.WriteLine("Hello World!");
}

// Chama o método para executar seu conteúdo.
Saudacao();


// ======================================
// ARRAYS
// ======================================

/*
Arrays são coleções de dados do mesmo tipo.
// Possuem tamanho fixo, definido na criação.

int[] numeros = { 10, 20, 30 };
// Cria um array de inteiros com três posições.

string[] nomes = new string[5];
// Cria um array de strings com cinco posições.
// Inicialmente, as posições possuem valor null.

nomes[0] = "Ana";
nomes[1] = "Bruno da Silva Souza";
nomes[2] = "Carna";
// Adiciona valores nas posições do array.
// Os índices começam em zero.

Console.WriteLine(nomes[1]);
// Exibe o conteúdo da posição 1.

// foreach percorre todos os elementos do array.
foreach (var item in nomes)
{
    Console.WriteLine(item);
}
*/


// ======================================
// LISTS (LISTAS)
// ======================================

// List é uma coleção dinâmica.
// Diferentemente dos arrays, permite adicionar e remover elementos.

List<string> nomes = new List<string>();
// Cria uma lista vazia que armazena textos (string).

// Add adiciona elementos ao final da lista.
nomes.Add("Ana");
nomes.Add("Bruno");
nomes.Add("Carla");
nomes.Add("Cintia");
nomes.Add("Bernardo");

// Count retorna a quantidade de elementos da lista.
Console.WriteLine(nomes.Count);


// Cria uma lista de inteiros já preenchida.
List<int> numeros = new List<int> { 10, 20, 22, 5, 30 };


// Remove exclui o elemento informado da lista.
nomes.Remove("Bruno");

// Exibe a quantidade atual de elementos.
Console.WriteLine(nomes.Count);


// Contains verifica se determinado elemento existe na lista.
// Retorna true ou false.
Console.WriteLine(nomes.Contains("Daniel"));


// Find procura o primeiro elemento que atende à condição.
// n => n > 20 é uma expressão lambda.
// Significa: encontrar um número maior que 20.
int encontrado = numeros.Find(n => n > 20);

Console.WriteLine(encontrado);


// Max retorna o maior valor existente na lista.
Console.WriteLine(numeros.Max());


// Find procura o primeiro nome que começa com a letra C.
// StartsWith verifica o início de um texto.
// string? permite que o resultado seja null caso não encontre.
string? achado = nomes.Find(n => n.StartsWith("C"));

Console.WriteLine(achado);


// ======================================
// DICIONÁRIOS (DICTIONARY)
// ======================================

// Dictionary armazena dados no formato CHAVE e VALOR.
// Neste exemplo, a chave é int e o valor é string.

Dictionary<int, string> produtos = new Dictionary<int, string>();

// Add adiciona um par de chave e valor.
// Cada chave deve ser única.
produtos.Add(101, "Notebook");
produtos.Add(102, "Mouse");
produtos.Add(103, "Teclado");


// Acessa diretamente o valor utilizando sua chave.
Console.WriteLine(produtos[101]);


// ContainsKey verifica se determinada chave existe.
if (produtos.ContainsKey(103))
{
    // Se a chave existir, exibe o produto correspondente.
    Console.WriteLine(produtos[103]);
}
else
{
    // Executa caso a chave não seja encontrada.
    Console.WriteLine("Produto não encontrado");
}


// foreach percorre todos os pares de chave e valor.
foreach (var produto in produtos)
{
    // Key representa a chave.
    // Value representa o valor associado à chave.
    Console.WriteLine(
        $"Código: {produto.Key} - Nome: {produto.Value}"
    );
}
