// 7. Выяснить является ли число чётным.

System.Console.Write("Введите любое целое число: ");
int a = Convert.ToInt32(Console.Read());

if (a % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");

// еще такой вариант

System.Console.Write("Введите любое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    System.Console.WriteLine($"{a} четное число");
}
else
{
    System.Console.WriteLine($"{a} нечетное число");
}


