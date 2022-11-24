// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

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

int [,] ArrayProduct(int [,] array1, int [,] array2)
{
    /*if(array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("OMG");
    }
    */

    int [,] ResultArray = new int [array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for(int l = 0; l < array1.GetLength(1); l++)
            {
                sum += array1[i, l] * array2[l, j];
            }
            ResultArray [i, j] = sum;
        }
    }
    return ResultArray;
}

Console.Write("Input number of rows for 1st matrix: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns for 1st matrix and number of rows for 2nd matrix: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns for 2nd matrix: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Input minimal possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input maximum possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array1 = Create2DArray(m, n, min, max);
int [,] array2 = Create2DArray(n, k, min, max);


Console.WriteLine("First matrix::");
ShowArray(array1);
Console.WriteLine("Second matrix:");
ShowArray(array2);

Console.WriteLine("The result of 1st matrix * 2nd matrix is: ");
int [,] result = ArrayProduct(array1, array2);
ShowArray(result);

