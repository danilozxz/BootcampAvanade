Queue<int> fila = new Queue<int>();

fila.Enqueue(3);
fila.Enqueue(7);
fila.Enqueue(4);
fila.Enqueue(8);

Console.WriteLine("Itens da fila");

foreach (int itens in fila)
{
    Console.WriteLine(itens);
}

fila.Dequeue();

Console.WriteLine("Removendo o primeiro item da fila");

foreach (int itens in fila)
{
    Console.WriteLine(itens);
}

fila.Enqueue(10);

Console.WriteLine("Adicionando mais um item ao final da fila");

foreach (int itens in fila)
{
    Console.WriteLine(itens);
}