// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] GetMatrix(int m, int n)
// {
//     double[,] matrix = new double[m,n];
//     int[] multiplier = { -100000, -10000, -1000, -100, -10, 10, 100, 1000, 10000, 100000};
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             double num = new Random().NextDouble();
//             int index = new Random().Next(0, multiplier.Length);
//             matrix[i,j] =  Math.Round((num * multiplier[index]), 3);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Полученная матрица:");
// PrintMatrix(GetMatrix(rows, columns));




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] GetMatrix (int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m,n];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= new Random().Next(min,max+1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             Console.Write(matrix[i,j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindNumberInMatrix (int[,] matrix, int row, int column)
// {
//     if (row>=matrix.GetLength(0) || column>=matrix.GetLength(1))
//     {
//         Console.WriteLine("Элемента с данными параметрами нет.");
//     }
//     else 
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1); j++)
//             {
//                 if (i==row && j==column)
//                 {
//                     Console.WriteLine($"Искомый элемент = {matrix[i,j]}");
//                 }
//             }
//         }
//     }
// }

// Console.Write("Введите число строк и столбцов через пробел: ");
// string[] parameters = Console.ReadLine().Split(' '); //прошу прощения, мне понравилась эта страшненькая штука с семинара! я решила ее попробовать :)
//                int rows = int.Parse(parameters[0]);
//                int columns = int.Parse(parameters[1]);
// Console.Write("Введите число минимальное и максимальное значениядля чисел в матрице: ");
// string[] limits = Console.ReadLine().Split(' ');
//                int min = int.Parse(limits[0]);
//                int max = int.Parse(limits[1]);

// Console.WriteLine("Сгенерированная матрица:");
// int[,] matrix = GetMatrix(rows, columns, min, max);
// PrintMatrix(matrix);

// Console.Write("Введите номера столбца и строки через пробел(учитывая, что строки и столбцы нумеруются с нуля): ");
// string[] find = Console.ReadLine().Split(' ');
//                int findRow = int.Parse(find[0]);
//                int findColumn = int.Parse(find[1]);
// FindNumberInMatrix(matrix, findRow, findColumn);




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] GetMatrix (int m, int n, int min, int max)
// {
//     int [,] matrix = new int[m,n];
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j] + "  ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumNumberInColumns(int[,] matrix)
// {
//     for (int j=0; j<matrix.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             sum+=matrix[i,j];
//         }
//         Console.WriteLine($"Сумма элементов {j}-го столбца = {sum}");
//     }
// }

// Console.Write("Введите число строк и столбцов через пробел: ");
// string[] parameters = Console.ReadLine().Split(" ");
//         int rows = int.Parse(parameters[0]);
//         int columns = int.Parse(parameters[1]);
// Console.Write("Введите число минимальное и максимальное значениядля чисел в матрице: ");
// string [] limits = Console.ReadLine().Split(" ");
//         int min = int.Parse(limits[0]);
//         int max = int.Parse(limits[1]);
// Console.WriteLine("Сгенерированная матрица:");


// int[,] matrix = GetMatrix(rows, columns, min, max);
// PrintMatrix(matrix);
// Console.WriteLine();
// SumNumberInColumns(matrix);