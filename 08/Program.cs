﻿// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли 
// число a числу b, // если нет, вывести остаток от деления a на b

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
{
    System.Console.Write($"{a} кратно числу {b}");
}
else
{
    System.Console.Write($"Остаток от деления {a} на {b} равен {a % b}");
}
