// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a == b || b == c)
{
    System.Console.WriteLine("Числа равны");
}
else
{

    if (b > max)
    {
        max = b;
    }
    if (c > max)
    {
        max = c;
    }
    System.Console.WriteLine($"Максимальное число из {a}, {b}, {c}, является {max}");
}
