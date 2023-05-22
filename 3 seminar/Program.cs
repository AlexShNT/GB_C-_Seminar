/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

// bool Poly(int num)
// {
//     int tmp = num;
//     int res = tmp % 10 * 10;
    
//     tmp /=  10;
//     res += tmp % 10;

//     tmp /= 100;

//     if (tmp == res) return true;
//     else return false;
// } 

// Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Poly(num));


/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Round((Math.Pow((Math.Pow((x1 + x2), 2) +
//                         Math.Pow((y1 + y2),2) +
//                         Math.Pow((z1 + z2),2)), 0.5)), 2);

// }

// Console.Write("Input X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input Z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input Z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"The distance between point {x1}, {y1}, {z1} and point {x2}, {y2}, {z2} is {Dist(x1, y1, z1, x2, y2, z2)}");

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Sq(int num)
{
    int c = 2;
    Console.Write($"{num} -> 1");
    while (c <= num)
    {
        Console.Write($", {c * c * c}");
        c ++;
    }

}

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

Sq(num);