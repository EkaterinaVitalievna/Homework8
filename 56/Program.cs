// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j] = new Random().Next(1, 20)}");
        }
        Console.WriteLine();
    }
}

void MinSumLineArray(int[,] arr)
{
    int indexLine = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {indexLine} строке");
}

int[,] array = new int[3, 5];
FillArray(array);
MinSumLineArray(array);
