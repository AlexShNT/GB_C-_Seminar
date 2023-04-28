/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

bool Poly(int num)
{
    int tmp = num;
    int res = tmp % 10 * 10;

    Console.WriteLine(tmp, res);
    
    tmp /=  10;
    res += tmp % 10;
    Console.WriteLine(tmp, res);

    tmp /= 100;
    Console.WriteLine(tmp, res);

}

Console.Write("Input num");
int num = Console.Convert.ToInt32(Console.ReadLine());

Poly(num);
