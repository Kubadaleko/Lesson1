// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. 
// Показать наибольшую цифру числа

System.Console.Write("Введите число от 10 до 99 включительно: ");
int a = Convert.ToInt32(Console.ReadLine());

int b;
int c;
if (a >= 10 && a <= 99)
{
    b = a / 10;
    c = a % 10;

    if (b > c)
    {
        System.Console.WriteLine($"{b} наибольшее");
    }
    else if (c > b)
    {
        System.Console.WriteLine($"{c} наибольшее");
    }
    else if (c == b)
    {
        System.Console.WriteLine("Числа равны");
    }
}
else
{
    System.Console.WriteLine("Введенное число вне указанного диапазона");
}
