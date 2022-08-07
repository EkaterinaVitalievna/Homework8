// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] FillArray(int x, int y, int z)
{
    int[,,] arbitraryArray = new int[x, y, z];
    int[] temporaryArray = new int[arbitraryArray.Length];
    for (int i = 0; i <temporaryArray.Length; i++)
    {
        temporaryArray[i] = new Random().Next(10,100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            while (temporaryArray[i] == temporaryArray[j])
            {
                temporaryArray[i] = new Random().Next(10,100);
            }
        }
    }
    int index = 0;
    for(int i = 0; i < arbitraryArray.GetLength(0); i++)
    {
        for (int j = 0; j < arbitraryArray.GetLength(1); j++)
        {
            for (int k = 0; k < arbitraryArray.GetLength(2); k++)
            {
                arbitraryArray[i,j,k] = temporaryArray[index];
                index++;
            }
        }
    }
    return arbitraryArray;
}

void PrintArray (int[,,] arbitraryArray) // выведение индексов
{
    for(int i = 0; i < arbitraryArray.GetLength(0); i++)
    {
        for (int j = 0; j < arbitraryArray.GetLength(1); j++)
        {
            for (int k = 0; k < arbitraryArray.GetLength(2); k++)
            {
                Console.Write($" {arbitraryArray[i,j,k]} ({i};{j};{k})");
            }
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк по первой оси: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк по второй оси: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк по третьей оси: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] array = FillArray(a, b, c);
PrintArray(array);