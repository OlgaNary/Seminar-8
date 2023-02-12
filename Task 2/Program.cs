// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

var arr = Generate2DArray(3, 4);
Print2DArray(arr);
System.Console.WriteLine();
GetRowWithMinSum(arr);

//Метод находит строку с наименьшей суммой элементов:
void GetRowWithMinSum(int[,] array)
{
    int minSum = 0;
    int sumNextRow = 0;
    int rowMinSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumNextRow += array[i, j];
        if (sumNextRow < minSum)
        {
            minSum = sumNextRow;
            rowMinSum = i;
        }
        sumNextRow = 0;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {rowMinSum + 1} строка");
}

//Метод задает рандомный двумерный массив:
int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

//Метод выводит массив на печать:
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}