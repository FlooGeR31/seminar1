/*Console.Write("Введите любое число :");
int number = int.Parse(Console.ReadLine()!);

// Математический способ

int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");

// Библиотека

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number}, с применением библиотеки, равен {sqr1}");*/


/*Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

if (Convert.ToInt32(Math.Pow(a, 2)) == b)
{
    Console.Write($"Да, число {a} является квадратом числа {b}");
}
else
{
    Console.WriteLine($"Нет, число {a} не является квадратом числа {b}");
}
*/

/*Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница*/

/*Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;

if (number == Monday){Console.WriteLine("Понедельник");}
else if (number == Tuesday){Console.WriteLine("Вторник");}
else if (number == Wednesday){ Console.WriteLine("Cреда");}
else if (number == Thursday){Console.WriteLine("Четверг");}
else if (number == Friday){Console.WriteLine("Пятница");}
else if (number == Saturday){Console.WriteLine("Суббота");}
else if (number == Sunday){ Console.WriteLine("Воскресенье");}
else if (number<1 || number>7){Console.WriteLine("В неделе всего 7 дней, введи корректное число!");}*/

//Написать программу, в которую принимается одно число и выводится на экран все целые числа в промежутке от - N до N

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int number2 = -number;

while (number2<= number)
{
    Console.Write($"{number2} ");
    number2++;
}
