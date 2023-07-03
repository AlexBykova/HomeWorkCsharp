// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// string digit = Console.ReadLine();
// int digitNum;
// bool isNumeric = int.TryParse(digit, out digitNum);

// if (digit.Length==5 && isNumeric==true)
// {
//     if ((digitNum/10000 == digitNum%10) && (digitNum/1000%10 == digitNum%100/10)) Console.Write($"Число {digitNum} является палиндромом");
//     else Console.Write($"Число {digitNum} НЕ является палиндромом");
// }
// else Console.Write($"Число введено некорректно");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите коррдинату х для первой точки: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите коррдинату y для первой точки: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите коррдинату z для первой точки: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите коррдинату х для второй точки: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите коррдинату y для второй точки: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите коррдинату z для второй точки: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine();

// double distance = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)),2);
// Console.WriteLine($"Расстояние между точками = {distance}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // int count = 1;

// for (int i=1; i<=N; i++)
// {
//     Console.Write($"{Math.Pow(i,3)} ");
// }


// Для усложенения: модифицировать программу из 19 задания и сделать так, чтобы проверялись не только цифры, но и строчки.
// Console.Write("Введите пятизначное число или слово из 5 букв: ");
// string SomeString = Console.ReadLine();
// int digitNum;
// bool isNumeric = int.TryParse(SomeString, out digitNum);

// if (SomeString.Length==5 && isNumeric==true)
// {
//     if ((digitNum/10000 == digitNum%10) && (digitNum/1000%10 == digitNum%100/10)) Console.Write($"Число '{digitNum}' является палиндромом");
//     else Console.Write($"Число '{digitNum}' НЕ является палиндромом");
// }
// else if (SomeString.Length == 5 && isNumeric!=true)
// {
//     if ((SomeString[0] == SomeString[4]) && (SomeString[1] == SomeString[3])) Console.Write($"Слово '{SomeString}' является палиндромом");
//     else Console.Write($"Слово '{SomeString}' НЕ является палиндромом");
// }
// else Console.Write($"Данные введены некорректно");