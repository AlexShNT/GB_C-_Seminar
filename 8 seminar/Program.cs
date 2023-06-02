int[,] Gen2DArr(int rows, int columns, int minVal, int maxVal)
{
    int[,] newArr = new int[rows, columns];

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            // double rndTmp = new Random().NextDouble() * (maxVal - minVal) + minVal;   
            // newArr[r, c] = Math.Round(rndTmp, 1);

            newArr [r,c] = new Random().Next(minVal, maxVal);
        }
    }

    return newArr;
}

void Print2DArr(int[,] array)
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

int[,] myArr = Gen2DArr(sizeRows, sizeColumns, minV, maxV);

Console.WriteLine();

Print2DArr(myArr);

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// int[,] RowMin(int[,] array)
// {
//     for (int r = 0; r < array.GetLength(0); r++)
//     {
        
//         for (int c = 0; c < array.GetLength(1)-1; c++)
//         {
//             int mc = array[r,c];
//             for (int m = c + 1; m < array.GetLength(1); m++)
//             {
//                 if (mc < array[r, m])
//                 {
//                    array[r,c] = array[r, m];                
//                    array[r, m] = mc;
//                    mc = array[r,c];
//                 }

//             }

//         }
//     }
//     return array;

// }

// myArr = RowMin(myArr);
// Console.WriteLine();
// Print2DArr(myArr);

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// int MinSummRow(int[,] array)
// {
//     int res = 0;
//     int ms = 0;
//     int tmp = 0;
//     for (int r = 0; r < array.GetLength(0); r ++)
//     {
        
//         for (int c = 0; c < array.GetLength(1); c ++)
//         {
//             tmp += array[r,c];
//         }

//         if (r == 0) ms = tmp;

//         if (ms > tmp)
//         {
//             ms = tmp;
//             res = r;        
//         }
        
//         tmp = 0;
//     }

//     return res;
// }

// Console.WriteLine(MinSummRow(myArr));

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
// int[,] MutArr(int[,] array1, int[,] array2)
// {
    
//     int[,] res = new int[array1.GetLength(0), array2.GetLength(1)];

//     for (int r = 0; r < array1.GetLength(0); r ++)
//     {
//         for (int c = 0; c < array2.GetLength(1); c ++)
//         {
//             for (int t = 0; t < array2.GetLength(0); t ++)
//                 res[r,c] += array1[r,t] * array2[t,c];
//         }
//     }

//     return res;
// }

// Console.Write("Input number of rows2: ");
// sizeRows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input number of colums2: ");
// sizeColumns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min value of array2:");
// minV = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max value of array2:");
// maxV = Convert.ToInt32(Console.ReadLine());

// int[,] myArr2 = Gen2DArr(sizeRows, sizeColumns, minV, maxV);

// Console.WriteLine();

// Print2DArr(myArr2);

// int[,] res = MutArr(myArr, myArr2);

// Console.WriteLine();
// Print2DArr(res);

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/