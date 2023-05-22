/*// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

// int Pow(int num, int exp)
// {
//     int res = 1;
//     for (int i = 1; i <= exp; i++)
//     {
//         res *= num;
//     }

//     return res;
// }

// Console.Write("Input num:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input exp:");
// int exp = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Num {num} in exp {exp} -> {Pow(num, exp)}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

// int SumNum(int num)
// {
//     int res = 0;

//     while (num > 0)
//     {
//         res += num % 10;

//         num /= 10;
//     }

//     return res;
// }

// Console.Write("Input num:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Sum num {num} -> {SumNum(num)}");


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] GenArr(int size, int minVal, int maxVal)
{
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = new Random().Next(minVal, maxVal + 1);
    }

    return newArr;
}

void PrintVal(int[] array)
{

    Console.Write($"{array[0]}");

    for (int i = 1; i < array.Length; i++)
    {

        Console.Write(", "+ array[i] );
    }
}

void PrintArr(int[] array)
{
    Console.Write($"[{array[0]}");

    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }

    Console.Write("]");

}

Console.Write("Input size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array:");
int minV = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array:");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] myArr = GenArr(size, minV, maxV);

PrintVal(myArr);
Console.Write( " -> ");
PrintArr(myArr);