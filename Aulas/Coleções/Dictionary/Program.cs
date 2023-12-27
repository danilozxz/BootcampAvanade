
Dictionary<int, string> alunos = new Dictionary<int, string>();

alunos.Add(1, "Danilo Fernandes");
alunos.Add(2, "Evelyn Sabrina");
alunos.Add(3, "Paulo Henrique");
alunos.Add(4, "Bruna Andrade");

foreach (var item in alunos)
{
    Console.WriteLine($"RA: {item.Key} - Nome do aluno: {item.Value}");

    // if (item.Key == 3)
    // {
    //     Console.WriteLine(item.Value);
    // }
}


Console.WriteLine("\n===== Removendo um item por sua key =====\n");

alunos.Remove(3);

foreach (var item in alunos)
{
    Console.WriteLine($"RA: {item.Key} - Nome do aluno: {item.Value}");

}

Console.WriteLine("\n===== Editando item por sua key =====\n");

alunos[2] = "Evelyn Sabrina ------ Item alterado";

foreach (var item in alunos)
{
    Console.WriteLine($"RA: {item.Key} - Nome do aluno: {item.Value}");

}

Console.WriteLine("\n=============\n");

var busca = 9;

if (alunos.ContainsKey(busca))
{
    Console.WriteLine($"O valor já existe: {busca}");
}
else
{
    Console.WriteLine($"O valor {busca} está disponível");
}