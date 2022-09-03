void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в матрице: m ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: n ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите номер строки искомого элемента: k ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента: l ");
int l = int.Parse(Console.ReadLine());


if ((k > m) ^ (l > n))
{
    Console.WriteLine("Такого элемента нет");
}
Console.WriteLine($"Искомый элемент массива: {array[k, l]} ({k},{l})");
