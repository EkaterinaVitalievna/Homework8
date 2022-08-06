//  Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j] = new Random().Next(10, 99)}");
        }
        Console.WriteLine();
    }
}


void Sort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int x = 0; x < arr.GetLength(1) - 1; x++)
            {
                if (arr[i, x] > arr[i, x + 1])    // смена знака для выбора возрастания или убывания сортировки
                {
                    int temp = arr[i, x + 1];
                    arr[i, x + 1] = arr[i, x];
                    arr[i, x] = temp;
                }
            }
        }
    }
}

void PrintSortArray(int[,] arr)
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

int[,] matrix = new int[5, 5];
Console.WriteLine("Сгенерированный рандомный массив: ");
FillArray(matrix);
Console.WriteLine("Массив после сортировки: ");
Sort(matrix);
PrintSortArray(matrix);