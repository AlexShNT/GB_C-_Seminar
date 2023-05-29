/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

// void PrintArr(int[] array)
// {
//     Console.Write($"{array[0]}");

//     for (int i = 1; i < array.Length; i++)
//     {
//         Console.Write($", {array[i]}");
//     }

// }

// int[] FillArr(int size)
// {
//     int[] newArr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Input {i+1} number: ");
//         newArr[i] = Convert.ToInt32(Console.ReadLine());

//     }

//     return newArr;
// }

// int CheckNum(int[] arrP)
// {
//     int res = 0;
//     for (int i = 0; i < arrP.Length; i++)
//     {
//         if (arrP[i] > 0 ) res++;
//     }

//     return res;
// }


// Console.Write("Input how many numbers: ");
// int arrLen = Convert.ToInt32(Console.ReadLine());

// int[] newArr = FillArr(arrLen);

// PrintArr(newArr);

// Console.Write($" -> {CheckNum(newArr)}");


/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 

Если k1 = k2 = 2, то прямые параллельны

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input k1: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) 
    Console.WriteLine("There is no solution. They are parallel");
else
{
    double x = (b2-b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.Write($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
    Console.Write($"intersection point: ({x}; {y})");
}