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

void ArithmetikalCollumns(int[,] array)
{
    double result = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result = Math.Round(sum/array.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое {j+1} столбца равно {result}");
    }
}
ArithmetikalCollumns(array);
