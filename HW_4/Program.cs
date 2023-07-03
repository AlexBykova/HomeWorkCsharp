// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int exponent = 1;
// int i = 1;
// for (i=1; i<=B; i++)
// {
//     exponent *= A;
//     // Console.WriteLine(exponent);
// }

// Console.Write($"{B} степень числа {A} = {exponent}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int Copynumber = number;
// int digit;
// int count = 0;
// int sum = 0;
// while (number > 0)
// {
//     digit = number % 10;
//     number/=10;
//     sum += digit;
//     count++;
// }
// Console.Write($"Во введённом числе '{Copynumber}' сумма цифр = {sum}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите {i+1} число массива: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine($"Ваш массив: [{string.Join("; ", array)}]");