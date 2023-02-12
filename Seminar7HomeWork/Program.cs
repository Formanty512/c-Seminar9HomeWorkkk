// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/*
double[,] CreateRandom2dArray()
{
    Console.WriteLine("Input M: ");
    double M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input N: ");
    double N = Convert.ToInt32(Console.ReadLine());
   

    double[,] array = new double[(int)M, (int)N];

    for (int i = 0; i < M; i++)

        for (int j = 0; j < N; j++)

            array[i, j] = new Random().Next(-100, 100);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/



// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> элемента с такими индексами в массиве нет

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columnes: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < columns; j++)

            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void CheckIndex(int[,] array)
{
    Console.WriteLine("Print first index of element: ");
    int index1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Print second index of element: ");
    int index2 = Convert.ToInt32(Console.ReadLine());

    if (index1 > array.GetLength(0) || index2 > array.GetLength(1))
        Console.WriteLine("No such element with your indexes");
    else
        Console.WriteLine($"Your element is: {array[index1, index2]}");
    
}

int[,] array = CreateRandom2dArray();
PrintArray(array);
CheckIndex(array);
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columnes: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < columns; j++)

            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void GetAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        double avg = sum / array.GetLength(0);
        Console.Write($"{avg}; ");
    }
}

int[,] array = CreateRandom2dArray();
PrintArray(array);
Console.Write("The average if every single column is: ");
GetAverage(array);