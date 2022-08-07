// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

void FillArrayNew(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j] = new Random().Next(1, 9)}");
        }
        Console.WriteLine();
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplexerArray(int[,] arr1, int[,] arr2, int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            {
                newArray[i, j] += arr1[i, j] * arr2[i, j];
            }
        }
    }
}

int[,] array1 = new int[3, 3];
int[,] array2 = new int[3, 3];
int[,] resultArray = new int[3, 3];
Console.WriteLine("Первая матрица:");
FillArrayNew(array1);
Console.WriteLine("Вторая матрица:");
FillArrayNew(array2);
Console.WriteLine("Произведение матриц:");
MultiplexerArray(array1, array2, resultArray);
PrintArray(resultArray);