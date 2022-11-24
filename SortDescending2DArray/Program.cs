// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // интересны габариты массива
{
    int [,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void ShowArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1); j++) 
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortDescending(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2dArray(m, n, min, max);
ShowArray(array);
SortDescending(array);
ShowArray(array);