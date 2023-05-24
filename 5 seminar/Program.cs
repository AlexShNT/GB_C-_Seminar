int[] GenArr(int size, int minVal, int maxVal)
{
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = new Random().Next(minVal, maxVal + 1);
    }

    return newArr;
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


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// int CountPos(int[] array)
// {
//     int con = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) con ++;
//     }

//     return con;
// }


// Console.Write("Input size of array: ");
// int sizeArr = Convert.ToInt32(Console.ReadLine());

// int[] myArr = GenArr(sizeArr, 100, 999);

// PrintArr(myArr);

// Console.Write($" -> {CountPos(myArr)}");


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

// int SummNegPos(int[] array)
// {
//     int res = 0;

//     for (int i = 1; i < array.Length; i+=2)
//     {
//         res += array[i];
//     }

//     return res;
// }

// Console.Write("Input size of array: ");
// int sizeArr = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min value of array:");
// int minV = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max value of array:");
// int maxV = Convert.ToInt32(Console.ReadLine());

// int[] myArr = GenArr(sizeArr, minV, maxV);

// PrintArr(myArr);

// Console.Write($" -> {SummNegPos(myArr)}");

/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

void PrintArrD(double[] array)
{
    Console.Write($"[{array[0]}");

    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }

    Console.Write("]");

}

double[] GenArrD(int size, int minVal, int maxVal)
{
    double[] newArr = new double[size];

    for (int i = 0; i < size; i++)
    {     
        double rndTmp = new Random().NextDouble() * (maxVal - minVal) + minVal;   
        newArr[i] = Math.Round(rndTmp, 2);
    }

    return newArr;

}

double MinArrD(double[] array)
{
    double minR = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (minR > array[i]) minR = array[i];
    }

    return minR;

}

double MaxArrD(double[] array)
{
    double maxR =  array[0];


    for (int i = 1; i < array.Length; i++)
    {
        if (maxR < array[i]) maxR = array[i];
    }

    return maxR;

}

Console.Write("Input size of array: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array:");
int minV = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array:");
int maxV = Convert.ToInt32(Console.ReadLine());

double[] myArr = GenArrD(sizeArr, minV, maxV);

PrintArrD(myArr);

double minArr = MinArrD(myArr);
double maxArr = MaxArrD(myArr);

Console.WriteLine("");

Console.Write($" min {minArr} max {maxArr} -> {Math.Round(maxArr - minArr, 2)}");





