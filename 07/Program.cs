﻿// 15. С клавиатуры вводится целое число. Вывести третью цифру // числа или сообщить, что её нет (Вывести: NO).

System.Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 99)
{
    System.Console.WriteLine("NO");
}
else
{
    while (a > 1000)
    {
        a = a / 10;
    }
    System.Console.WriteLine(a % 10);
}
