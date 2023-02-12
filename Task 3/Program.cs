// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

var firstArray = Generate2DArray(2, 2);
System.Console.WriteLine("Первая матрица:");
Print2DArray(firstArray);
var secondArray = Generate2DArray(2, 2);
System.Console.WriteLine("Вторая матрица:");
Print2DArray(secondArray);
var sumArray = GetDivArray(firstArray, secondArray);
System.Console.WriteLine("Произведение двух матриц:");
Print2DArray(sumArray);

//Метод находит произведение двух матриц:
int[,] GetDivArray(int[,] arr1, int[,] arr2)
{
    var sumArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < sumArray.GetLength(0); i++)
        {
            for (int j = 0; j < sumArray.GetLength(1); j++)
            {
                sumArray[i, j] = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    sumArray[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
    }
    return sumArray;
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
