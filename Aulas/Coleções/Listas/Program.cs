
// A lista funciona como um array, porém não precisamos nos preocupar em redimencioná-la como precisamos no array

List<string> lista = new List<string>();

lista.Add("Danilo");
lista.Add("Evelyn");
lista.Add("Rogério da Academia");
lista.Add("Lula");

Console.WriteLine($"Itens na minha lista: {lista.Count} - capacidade: {lista.Capacity}");

lista.Add("Ana Paula");

Console.WriteLine($"Itens na minha lista: {lista.Count} - capacidade: {lista.Capacity}");

lista.Remove("Danilo");

Console.WriteLine($"Itens na minha lista: {lista.Count} - capacidade: {lista.Capacity}");



// for (int i = 0; i < lista.Count; i++)
// {
//     Console.WriteLine($"Posição N° {i} - {lista[i]}");
// }
