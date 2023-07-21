// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// string PrintNumbers(int number)
// {
//     if (number == 1) return number.ToString();
//     return number + ", " + PrintNumbers(number-1);
// }

// Console.Write("Введите число = ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Числа от {number} до 1: {PrintNumbers(number)}");



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers(int start, int end)
// {
//     if (start == end) return end;
//     int sum = start + SumNumbers(start+1, end);
//     return sum;
// }

// Console.Write("Введите начальное число диапазона суммирования: ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное число диапазона суммирования: ");
// int end = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел от {start} до {end}: {SumNumbers(start, end)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Accerman (int M, int N)
// {
//     if (N == 0) return M+1;
//     if (M == 0) return Accerman(N-1, 1);
//     return Accerman(N-1, Accerman(N,M-1));
// }

// Console.Write("Введите параметр M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите gfhfvtnh N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M<0 && N<0) 
// {
//     Console.WriteLine("Некорректные данные.");
//     return;
// }
// Console.WriteLine($"Функция Аккермана для введённых чисел = {Accerman(M, N)}");