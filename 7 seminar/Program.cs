/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] Gen2DArr(int rows, int columns, int minVal, int maxVal)
{
    double[,] newArr = new double[rows, columns];

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            double rndTmp = new Random().NextDouble() * (maxVal - minVal) + minVal;   
            newArr[r, c] = Math.Round(rndTmp, 1);
        }
    }

    return newArr;
}

void Print2DArr(double[,] array)
{
    // Console.Write($"[{array[0]}");

    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write(array[r,c]+ "\t");
        }
        Console.WriteLine();
    }

    // Console.Write("]");

}

Console.Write("Input number of rows: ");
int sizeRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of colums: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value of array:");
int minV = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value of array:");
int maxV = Convert.ToInt32(Console.ReadLine());

double[,] myArr = Gen2DArr(sizeRows, sizeColumns, minV, maxV);

Print2DArr(myArr);

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.Write("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input colum: ");
int column = Convert.ToInt32(Console.ReadLine()); 

if ((row > myArr.GetLength(0)) || (column > myArr.GetLength(1)))
{
    Console.WriteLine("there is no such number in the array");
}
else
{
    Console.WriteLine($"{row}, {column} -> {myArr[row - 1, column - 1]}" );
}

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

void PrintArrD(double[] array)
{
    Console.Write($"{array[0]}");

    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"; {array[i]}");
    }

    // Console.Write("]");

}

double[] ArithmeticMeanColums(double[,] array, int round)
{
    double[] res = new double[array.GetLength(1)];

    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            res[c] += array[r,c];
        }
    }

    for (int c = 0; c < array.GetLength(1); c++)
    {
        res[c] /= array.GetLength(0);
        res[c] = Math.Round(res[c], round);
    }

    return res;
}

Console.Write($"Arithmetic mean of each column -> ");

double[] arithMeanCol = ArithmeticMeanColums(myArr, 2);

PrintArrD(arithMeanCol);