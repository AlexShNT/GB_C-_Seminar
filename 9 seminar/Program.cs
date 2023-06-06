/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// void RecNum(int n)
// {
//     if (n > 0)
//     {
//         Console.Write($"{n}, ");
//         RecNum(n -1);
//     }
//     else 
//         Console.WriteLine();
// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// RecNum(num);

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

// int SumMtoN(int m, int n)
// {
//     if (m > n)  return SumMtoN(m - 1, n) + m;
//     else if (m < n)  return SumMtoN(m, n - 1) + n;
//     else return m;
// }

Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Sum M to N -> {SumMtoN(numM, numN)}");

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunAcer(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FunAcer(n - 1, 1);
    else
      return FunAcer(n - 1, FunAcer(n, m - 1));
}

Console.Write($"Acerman(M, N) -> {FunAcer(numM, numN)}");