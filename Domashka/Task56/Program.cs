// 
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,]array = GetArray(rows, columns,1,10);
PrintArray(array);
int foundedLine = SumLine(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {foundedLine} ");



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



int SumLine(int [,] array2D)
{
    Console.Write ($"Суммы строк:");
    int [] sumArr = new int [array.GetLength (0)];
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
        {
            sumArr [i] += array [i, j];
        }
        Console.Write ($" {sumArr [i]}");
    }
    Console.WriteLine ();
    int minSum = sumArr [0];
    int minLine = 1;
    for (int i = 0; i < array.GetLength (0); i++)
    {
        if (sumArr [i] < minSum) 
        {
            minSum = sumArr [i];
            minLine = i+1;
        }
    }
    return minLine;
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