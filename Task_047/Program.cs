Console.Write("Введите количество строк в матрице: m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: n ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] array = new double[m,n];

void FillArrayDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 2);
        }
    }
}

void PrintArrayDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

FillArrayDouble(array);
PrintArrayDouble(array);
Console.WriteLine();