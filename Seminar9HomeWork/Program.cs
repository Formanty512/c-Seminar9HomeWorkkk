// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num -1);
}

ShowNums(7);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SumNum(int M, int N)
{
    if (M == N) return M;
    else if (M < N) return (M + SumNum(M + 1, N));
    else return (M + SumNum(M - 1, N));
}



Console.WriteLine("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNum(M, N));
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if ((M > 0 && N == 0)) return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}

Console.WriteLine("Input M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(M, N));

