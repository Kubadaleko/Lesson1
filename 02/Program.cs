// 4. По заданному с клавиатуры номеру дня недели вывести его название

System.Console.WriteLine("Введите номер дня недели (от 1 до 7) : ");
int a = Convert.ToInt32(Console.ReadLine());
string a1 = "Понедельник";
string a2 = "Вторник";
string a3 = "Среда";
string a4 = "Четверг";
string a5 = "Пятница";
string a6 = "Суббота";
string a7 = "Воскресенье";

if (a == 1)
{
    System.Console.WriteLine($"{a} день недели это {a1}");
}
else if (a == 2)
{
    System.Console.WriteLine($"{a} день недели это {a2}");
}
else if (a == 3)
{
    System.Console.WriteLine($"{a} день недели это {a3}");
}
else if (a == 4)
{
    System.Console.WriteLine($"{a} день недели это {a4}");
}
else if (a == 5)
{
    System.Console.WriteLine($"{a} день недели это {a5}");
}
else if (a == 6)
{
    System.Console.WriteLine($"{a} день недели это {a6}");
}
else if (a == 7)
{
    System.Console.WriteLine($"{a} день недели это {a7}");
}
else System.Console.WriteLine("Вы ввели не то что просили");
