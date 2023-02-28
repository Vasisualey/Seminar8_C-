// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Введите количество строк 1 массива: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк 2 массива: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(Console.ReadLine()!);


int[,]arrayA = GetArray(rowsA, columnsA,1,10);
PrintArray(arrayA);
int[,]arrayB = GetArray(rowsB, columnsB,1,10);
PrintArray(arrayB);

int[,]arrayC = multArray(arrayA, arrayB);

Console.WriteLine($"Результат произведения двух матриц: ");
PrintArray(arrayC);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m,n];
    for (int i = 0; i<m;i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i< inArray.GetLength(0); i++)
    {
        for (int j=0; j< inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] multArray (int [,] arrayA, int [,] arrayB)
{
    int lineC;
    int columnC;
    if (arrayA.GetLength(0) > arrayB.GetLength(0))
        {
            lineC = arrayB.GetLength(0);
        }
    else
        {
            lineC = arrayA.GetLength(0);
        }

    if (arrayA.GetLength (1) > arrayB.GetLength(1))
        {
            columnC = arrayB.GetLength(1);
        }
    else
        {
            columnC = arrayA.GetLength(1);
        }

int [,] arrayC = new int [lineC, columnC];
    for (int i = 0; i < lineC; i++)
    {
        for (int j = 0; j < columnC; j++)
        { 
            arrayC [i, j] = arrayA [i, j] * arrayB [i, j];
        }
    }
    return arrayC;
}