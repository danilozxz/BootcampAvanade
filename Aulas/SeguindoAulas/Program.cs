using Projeto.Models;

Console.WriteLine("Insira o tamanho do vetor");
int tamanhoVetor = Convert.ToInt32(Console.ReadLine());
int[] vetor = new int[tamanhoVetor];

Console.WriteLine("Inserindo valores no vetor");
for(int contador = 0; contador < vetor.Length; contador++)
{
    Console.WriteLine($"Insira o valor {contador + 1}: ");
    vetor[contador] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Exibindo vetor com for");
for(int contador = 0; contador < vetor.Length; contador++)
{
    Console.WriteLine($"[{vetor[contador]}]");
}

Console.WriteLine("Exibindo vetor com Foreach");
foreach(int valor in vetor)
{
    Console.WriteLine(valor);
}




























// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Escolha uma opção (0 para encerrar)");
//     Console.WriteLine("1-Cadastrar funcionário");
//     Console.WriteLine("2-Verificar funcionários");
//     Console.WriteLine("3-Remover funcionário");
//     Console.WriteLine("4-Encerrar");
    
//     opcao = Console.ReadLine();

//     switch(opcao) 
//     {
//         case "1":
//         Console.WriteLine("Funcionário cadastrado");
//         break;
//         case "2":
//         Console.WriteLine("Verificando funcionários");
//         break;
//         case "3":
//         Console.WriteLine("Removendo funcionários");
//         break;
//         case "4":
//         Console.WriteLine("Programa encerrado");
//         exibirMenu = false; //Essa opção garante a continuação do programa após o loop
//         // Environment.Exit(0); Essa opção encerra o programa
//         break;

//         default: 
//         Console.WriteLine("Número inválido!");
//         break;
//     }

// }

// Console.WriteLine("teste");























// Calculadora calc = new Calculadora();

// calc.Somar(10, 5);
// calc.Subtrair(10, 5);
// calc.Multiplicar(10, 5);
// calc.Dividir(10, 5);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(100);



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal!");
//         break;


//     default:
//         Console.WriteLine("Não é uma vogal!");
//         break;
// }







// using Projeto.Models;

// Pessoa p1 = new Pessoa();

// p1.Nome = "Danilo";
// p1.Idade = 21;
// p1.Apresentar();


// int quantidadeEmEstoque = 100;
// int quantidadeCompra = 200;
// bool verificaCompra = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade desejada: {quantidadeCompra}");
// Console.WriteLine($"É possível fazer a compra? {verificaCompra}");
// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Compra inválida!");
// }
// else if (verificaCompra)
// {
//     Console.WriteLine("Compra realizada!");
// }
// else
// {
//     Console.WriteLine("A quantidade em estoque não é suficiente para a venda.");
// }