/*Console.Write("Введите любое число :");
int number = int.Parse(Console.ReadLine()!);

// Математический способ

int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");

// Библиотека

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number}, с применением библиотеки, равен {sqr1}");*/


Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

    if (Convert.ToInt32(Math.Pow(a,2)) == b)
{
    Console.Write($"Да, число {a} является квадратом числа {b}");
}
    else
{
Console.WriteLine($"Нет, число {a} не является квадратом числа {b}");
}





