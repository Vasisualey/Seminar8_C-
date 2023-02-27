// Задача 57. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.
// {1,9,9,0,2,8,0,9}
// 0 встречается 2 раза,
// 1 встречается 1 раз, 
// 2 встречается 1 раз и т д

Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,]array = GetArray(rows, columns,1,10);
PrintArray(array);
int[] newArray =ArrayToString(array, rows,columns);
BubbleSort(newArray,rows,columns);
Quantity(newArray);




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
}

// void CounterElemets(int[,] array)
// {
//     for (int i = 0; i< array.GetLength(0); i++)
//     {
//         for (int j=0; j< array.GetLength(1); j++)
//         {
//             int k = array[i,j];
//             int count = 0;
//             for (int m = 0; m < array.GetLength(0); m++)
//             {
//                 for (int n = 0; n < array.GetLength(1); n++)
//                 {
//                     if(array[m,n] == k)
//                     {
//                         count++;
//                     }
//                 }
//             }
//             Console.WriteLine($"{array[i,j]} встречается {count} раз");
//         }
//     }
// Console.WriteLine();
// }
int[] ArrayToString(int[,] array, int rows, int columns)
{
    int[] stringArray = new int [rows * columns+1];
    int k = 0;
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            stringArray[k] = array[i,j];
            k++;
        }
    }
    return stringArray;
}
void BubbleSort(int[] data, int rows, int columns)
{
  int lenD = rows*columns+1;
  int tmp = 0;
  for(int i = 0;i<lenD-1;i++)
  {
    for(int j = (lenD-2);j>=(i+1);j--){
      if(data[j]<data[j-1])
      {
        tmp = data[j];
        data[j]=data[j-1];
        data[j-1]=tmp;
      }
    }
  }
}
// void BubbleSort(int[] data, int lenD)
// {
//   int tmp = 0;
//   for(int i = 0;i<lenD;i++)
//   {
//     for(int j = (lenD-1);j>=(i+1);j--){
//       if(data[j]<data[j-1])
//       {
//         tmp = data[j];
//         data[j]=data[j-1];
//         data[j-1]=tmp;
//       }
//     }
//   }
// }

// void Print(int[] Somearray)
// {
//     Console.Write("[");
//     for(int i = 0; i<Somearray.Length-1;i++)
//     {
//         Console.Write($"{Somearray[i]}, ");
//     }
//         Console.Write($"{Somearray[Somearray.Length-1]}");
//     Console.Write("]");
//     Console.WriteLine();
// }
void Quantity(int[] array)
{
    int count = 1;
    for(int i =0; i<array.Length-1; i++)
        {
            if (array[i]==array[i+1])
            {
                count++;
            }
            else
            {
                Console.WriteLine($"{array[i]} встречается {count} раз");
                count = 1;
            }
        }
}




