// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] GetMatrix(int m, int n, int min, int max)
// {
//     int [,] matrix = new int[m,n];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             matrix[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return(matrix);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0);i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             Console.Write(matrix[i,j]+"  ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] ArrangeRowElements (int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             int max = matrix[i,j];
//             int temp = 0;
//             int k=0;
//             while(k<j)
//             {
//                 if(matrix[i,k]<max)
//                 {
//                     temp=matrix[i,j];
//                     matrix[i,j]=matrix[i,k];
//                     matrix[i,k]=temp;
//                 }
//                 k++;
//             }
//         }
//     }
//     return matrix;
// }

// Console.Write("Введите количество строк и столбцов для матрицы через пробел: ");
// string [] parameters = Console.ReadLine().Split(" ");
//     int rows = int.Parse(parameters[0]);
//     int columns = int.Parse(parameters[1]);

// Console.Write("Введите минимальную и максимальную границы для значений в матрице через пробел: ");
// string [] values = Console.ReadLine().Split(" ");
//     int min = int.Parse(values[0]);
//     int max = int.Parse(values[1]);

// int [,] matrix = GetMatrix(rows, columns, min, max);
// Console.WriteLine("Сгенерированная матрица:");
// PrintMatrix(matrix);
// Console.WriteLine();
// PrintMatrix(ArrangeRowElements(matrix));



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int [,] GetMatrix(int m, int n, int min, int max)
// {
//     int [,] matrix = new int[m,n];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             matrix[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return(matrix);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0);i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             Console.Write(matrix[i,j]+"  ");
//         }
//         Console.WriteLine();
//     }
// }

// void RowWithMinSumm (int [,] matrix)
// {
//     int minSum = int.MaxValue;
//     int indexMinSumRow = 0;
//     for (int i=0; i<matrix.GetLength(0);i++)
//     {
//         int sum = 0;
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             sum += matrix[i,j];
//         }
//         if (sum<minSum)
//         {
//             minSum = sum;
//             indexMinSumRow = i;
//         }
//     }
//     Console.WriteLine($"Минимальная сумма строки в матрице = {minSum}. Это сумма строки под номером {indexMinSumRow+1}.");
// }

// Console.Write("Введите количество строк и столбцов для матрицы через пробел: ");
// string [] parameters = Console.ReadLine().Split(" ");
//     int rows = int.Parse(parameters[0]);
//     int columns = int.Parse(parameters[1]);

// Console.Write("Введите минимальную и максимальную границы для значений в матрице через пробел: ");
// string [] values = Console.ReadLine().Split(" ");
//     int min = int.Parse(values[0]);
//     int max = int.Parse(values[1]);

// int [,] matrix = GetMatrix(rows, columns, min, max);
// Console.WriteLine("Сгенерированная матрица:");
// PrintMatrix(matrix);
// Console.WriteLine();
// RowWithMinSumm(matrix);




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int [,] GetMatrix(int m, int n, int min, int max)
// {
//     int [,] matrix = new int[m,n];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             matrix[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return(matrix);
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0);i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             Console.Write(matrix[i,j]+"  ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] MultiMatrix (int [,] matrix1, int [,] matrix2)
// {
//     int [,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
//     for(int i=0; i<matrix1.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix2.GetLength(1); j++)
//         {
//             for (int k=0; k<matrix2.GetLength(0);k++)
//             {
//                 result[i,j] += matrix1[i,k]* matrix2[k,j];
//             }
//         }
//     }
//     return result;
// }

// Console.Write("Введите количество строк и столбцов для первой матрицы через пробел: ");
// string [] parameters1 = Console.ReadLine().Split(" ");
//     int rows1 = int.Parse(parameters1[0]);
//     int columns1 = int.Parse(parameters1[1]);

// Console.Write("Введите минимальную и максимальную границы для значений в первой матрице через пробел: ");
// string [] values1 = Console.ReadLine().Split(" ");
//     int min1 = int.Parse(values1[0]);
//     int max1 = int.Parse(values1[1]);

// Console.Write("Введите количество строк и столбцов для второй матрицы через пробел: ");
// string [] parameters2 = Console.ReadLine().Split(" ");
//     int rows2 = int.Parse(parameters2[0]);
//     int columns2 = int.Parse(parameters2[1]);

// Console.Write("Введите минимальную и максимальную границы для значений во второй матрице через пробел: ");
// string [] values2 = Console.ReadLine().Split(" ");
//     int min2 = int.Parse(values2[0]);
//     int max2 = int.Parse(values2[1]);

// int [,] matrix1 = GetMatrix(rows1, columns1, min1, max1);
// Console.WriteLine("Сгенерированная первая матрица:");
// PrintMatrix(matrix1);

// int [,] matrix2 = GetMatrix(rows2, columns2, min2, max2);
// Console.WriteLine("Сгенерированная вторая матрица:");
// PrintMatrix(matrix2);

// if (matrix1.GetLength(1) != matrix2.GetLength(0))
//     {
//         Console.WriteLine("Некорректные данные. Невозможно провести умножение.");
//         return;
//     }
// Console.WriteLine();
// Console.WriteLine("Результат умножения матриц:");
// PrintMatrix(MultiMatrix (matrix1, matrix2));


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int [] ValuesForMatrix (int length)
// {
//     int[] array = new int[length];
//     int i=1;
//     array[0] = new Random().Next(10,100);
//     while (i<array.Length)
//     {
//         int temp = new Random().Next(10,100);
//         bool flag = true;
//         for (int j=0; j<i; j++)
//         {
//             if (temp==array[j]) flag = false;
//         }
//         if (flag==true)
//         {
//             array[i] = temp;
//             i++;
//         }
//     }
//     return array;
// }

// int [,,] GetMatrix(int m, int n, int l, int [] values)
// {
//     int [,,] matrix = new int[m,n,l];
//     int indexValue = 0;
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             for (int k=0; k<matrix.GetLength(2);k++)
//             { 
//             matrix[i,j,k] = values[indexValue];
//             indexValue++;
//             }
//         }
//     }
//     return(matrix);
// }

// void PrintMatrix(int[,,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0);i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             for (int k=0; k<matrix.GetLength(2); k++)
//             {
//                 Console.Write($"{matrix[i,j,k]} ({i+1}, {j+1}, {k+1})  ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк, столбцов и слоёв для трехмерной матрицы через пробел: ");
// string [] parameters = Console.ReadLine().Split(" ");
//     int rows = int.Parse(parameters[0]);
//     int columns = int.Parse(parameters[1]);
//     int layers = int.Parse(parameters[2]);

// int [] array = ValuesForMatrix(rows*columns*layers);
// // Console.WriteLine($"Вспомогательный массив: {string.Join("; ", array)}");
// // Console.WriteLine();
// int [,,] matrix = GetMatrix(rows, columns, layers, array);
// Console.WriteLine("Сгенерированная матрица:");
// PrintMatrix(matrix);
// Console.WriteLine();


// Доп:
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int [,] GetMatrix()
// {
//     int len = 4;
//     int[,] matrix = new int[len,len];
//     int temp = 1;
//     for (int i=0, j=0; j<4; j++)
//     {
//         matrix[i,j] = temp;
//         temp++;
//     }
//     for (int i=1, j=3; i<4; i++)
//     {
//         matrix[i,j] = temp;
//         temp++;
//     }
//     for (int i=3, j=2; j>=0; j--)
//     {
//         matrix[i,j] = temp;
//         temp++;
//     }
//     for (int i=2, j=0; i>0; i--)
//     {
//         matrix[i,j] = temp;
//         temp++;
//     }
//     for (int i=1, j=1; j<3; j++)
//     {
//         matrix[i,j] = temp;
//         temp++;
//     }
//     for (int i=2, j=2; j>0; j--)
//     {
//         matrix[i,j] = temp;
//         temp++;
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0);i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             Console.Write(matrix[i,j]+"\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Массив 4х4, заполненный 'спиралькой':");
// PrintMatrix(GetMatrix());