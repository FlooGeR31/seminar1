Console.Write("Введите любое число :");
int number = int.Parse(Console.ReadLine()!);

// Математический способ

int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");

// Библиотека

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number}, с применением библиотеки, равен {sqr1}");

