// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] MakeArray (int size)
// {
//     int[] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         Console.Write("Введите элемент массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int GetQuantityOfPositive (int[] arr)
// {
//     int count = 0;
//     foreach (int item in arr)
//     {
//         if (item >0) count++;
//     }
//     return count;
// }

// Console.Write("Введите количество элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[]array = MakeArray(size);
// Console.WriteLine($"Ваш массив: {string.Join("; ", array)}");
// Console.WriteLine($"Количество чисел >0 в Вашем массиве = {GetQuantityOfPositive(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.Write("Введите коэффициент k для первой прямой = ");
// double k1= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент b для первой прямой = ");
// double b1= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент k для второй прямой = ");
// double k2= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите коэффициент b для второй прямой = ");
// double b2= Convert.ToInt32(Console.ReadLine());

// double x = (b2-b1)/(k1-k2);
// double y = k1*x + b1;

// if ((k1==k2)&&(b1==b2)) Console.WriteLine($"Вы задали одну прямую. Проверьте корректность задания коэффициентов!");
// else if (k1==k2) Console.WriteLine($"Заданные прямые параллельны - у них нет точек пересечения");
// else if (k1/k2 == b1/b2) Console.WriteLine($"Заданные прямые совпадают. У них бесконечное количество точек пересечения");
// else Console.WriteLine($"Координаты точки пересечения прямых с заданными коэффициентами: ({x}; {y})");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int[] ConvertToBin(int N)
// {
//     List<int> result = new List<int>();
//     int i=0;
//     while (N>=1)
//     {
//         result.Add(N % 2);
//         N /=2;
//         i++;
//     }
//     result.Reverse();
//     int[] resultArray = result.ToArray();
//     return resultArray;
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вашe число в двоичной системе: {string.Join("", ConvertToBin(num))}");

