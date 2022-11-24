// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int [,] Create2DArray(int rows, int columns, int minValue, int maxValue)
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
            Console.Write(array[i, j] + "    ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SearchLeastString (int [,] array)
{
    int min = 1000;
    int sum = 0;
    int index_row = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        int temp = sum;
        sum = 0;
        if (temp < min)
        {
            min = temp;
            index_row = i;
        }
    }
 Console.WriteLine(index_row + 1);
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = Create2DArray(m, n, min, max);
ShowArray(myArray);

Console.WriteLine("The least number of elements is: ");
SearchLeastString(myArray);

