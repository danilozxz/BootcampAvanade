Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(3);
pilha.Push(9);


foreach (int itens in pilha)
{
    Console.WriteLine(itens);
}

pilha.Pop();

Console.WriteLine("Removendo o último elemento adicionado na pilha");

foreach (int itens in pilha)
{
    Console.WriteLine(itens);
}

// Método que aprendi sozinho para exibir pilhas
/*
int[] array = pilha.ToArray();

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
*/