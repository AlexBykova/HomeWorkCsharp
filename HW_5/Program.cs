// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateArray(int size)
// {
//     int[] result = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         result[i] = new Random().Next(100, 1000);
//     }
//     return result;
// }

// int numberOfEven (int[] array)
// {
//     int count = 0;
//     for (int i=0; i<array.Length;i++)
//     {
//         if (array[i]%2 == 0) count+=1;
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// Console.WriteLine($"Сгенерированный массив: {string.Join("; ", array)}");
// Console.WriteLine($"В сгенерированном массиве чётных элементов - {numberOfEven(array)}.");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] MakeArray(int size, int min, int max)
// {
//     int[] collection = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         collection[i]=new Random().Next(min,max+1);
//     }
//     return collection;
// }

// int sumOfOddPositions(int[]array)
// {
//     int sum = 0;
//     for (int i=0; i<array.Length; i++)
//     {
//         if (i%2 == 1) sum+=array[i];
//     }
//     return sum;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальную границу для элементов массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальную границу для элементов массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array = MakeArray(size, min, max);
// Console.WriteLine($"Сгенерированный массив: {string.Join("; ", array)}");
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов массива с нечётными индеками = {sumOfOddPositions(array)}.");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] generatingAnArray(int size)
// {
//     double[] array = new double[size];
//     int[] multiplier = { -100000, -10000, -1000, -100, -10, 10, 100, 1000, 10000, 100000};
//     for (int i=0; i<size; i++)
//     {
//         double mul1 = new Random().NextDouble();
//         Random rnd = new Random();
//         int index = rnd.Next(0, multiplier.Length);
//         array[i] =  Math.Round((mul1 * multiplier[index]), 3);

//     }
//     return array;
// }

// double diffBeetweenMinMax(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i=0; i<array.Length; i++)
//     {
//         if (min > array[i]) min = array[i];
//         if (max < array[i]) max = array[i];
//     }
//     // Console.WriteLine(min);
//     // Console.WriteLine(max);
//     double difference = max - min;
//     return difference;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Сгенерированный массив: ");
// double[] array = generatingAnArray(size);
// for (int i=0; i<array.Length; i++)
// {
//     Console.Write($"{array[i]}; ");
// }
// Console.WriteLine();

// // Console.WriteLine($"Сгенерированный массив: {string.Join(array)}"); //<- не сработала с типом double: Аргумент 1: не удается преобразовать из "double[]" в "char"
// Console.WriteLine($"Разница между max и min элементами массива = {diffBeetweenMinMax(array)}");