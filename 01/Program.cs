// 3. С клавиатуры вводятся два числа a и b. Найти максимальное из них.

System.Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a - b > 0)
{
    System.Console.WriteLine($"Максимальное число {a}");
}
else System.Console.WriteLine($"Максимальное число {b}");

