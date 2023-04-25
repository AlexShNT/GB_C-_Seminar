/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


// Console.Write("Imput number: ");
// int num = Convert.ToInt32( Console.ReadLine());

// Console.WriteLine($"{num} -> {(num % 100) / 10 }");

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

// Console.Write("Input number: ");
// int num = Convert.ToInt32( Console.ReadLine());

// Console.Write($"{num} -> ");

// if (num < 100)
// {
//     Console.WriteLine($"третьей цифры нет");
// }
// else
// {
//     int con = 0;

//     int tmp = num;

//     while (tmp > 0)
//     {
//         tmp /= 10;
//         con ++;
//     }

//     con -= 3;
//     while (con > 0)
//     {
//         num /= 10;
//         con --;
//     }
    
//     Console.WriteLine($"{num % 10}");
// }

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool SayDay(int num)
{
    if (num < 6) return false;
    else return true;
}

Console.Write("Enter number of day: ");
int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num} -> {SayDay(num)}");
Console.Write($"{num} -> ");
if (SayDay(num)) Console.WriteLine("Да");
else Console.WriteLine("Нет");