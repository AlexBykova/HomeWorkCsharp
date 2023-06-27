// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int digit = Convert.ToInt32(Console.ReadLine());

// int dozen = (digit / 10) % 10;
// Console.WriteLine($"В Вашем числе десятков - {dozen}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. До 10 символов
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите произвольное число (до 10 символов): ");
// string digit = Console.ReadLine();
// int digitNum;
// bool isNumeric = int.TryParse(digit, out digitNum);

// if (digitNum>99 && isNumeric==true)
// {
//     Console.WriteLine($"В Вашем числе третья цифра = {digit[2]}");
// }
// else if (digitNum<-99 && isNumeric==true)
// {
//     Console.WriteLine($"В Вашем числе третья цифра = {digit[3]}");
// }
// else if (Math.Abs(digitNum)<99 && isNumeric==true)
// {
//     Console.WriteLine($"В Вашем числе третья цифра = {digit[2]}");
// }
// else
// {
//     Console.WriteLine("Введенные данные не корректны");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите номер дня недели (число от 1 до 7): ");
// int dayWeek = Convert.ToInt32(Console.ReadLine());

// if (dayWeek >= 1 && dayWeek<=5)
// {
//     Console.Write("Выбранный Вами день - будний.");
// }
// else if (dayWeek >= 6 && dayWeek<=7)
// {
//     Console.Write("Выбранный Вами день - выходной!");
// }
// else
// {
//     Console.Write("Внимательно смотрите условие!");
// }


// Дополнительное:
// Назовём число «интересным» если его произведение цифр делится на их сумму БЕЗ остатка. 
// Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000(999 - последнее). (каждый эл-т массива – 
// сгенерирован случайно)
// Пример для 1 элемента массива: 591, сумма: 5+9+1 = 15; 
// произведение: 5*9*1 = 45; 45 / 15 - делится НАЦЕЛО, число "интересное"
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]


// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         int challenger = new Random().Next(10, 1000);
//         int mul = (challenger/100) * (challenger/10%10) * (challenger%10);
//         int sum = (challenger/100) + (challenger/10%10) + (challenger%10);
//         if (mul%sum==0 && mul!=0)
//         {
//             collection[index] = challenger;
//             index++;
//         }
        
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] + " ");
//         position++;
//     }
// }

// int[] array = new int[10];

// FillArray(array);
// Console.WriteLine("Массив 'интересных' чисел:" );
// PrintArray(array);