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

/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int number2 = -number;

while (number2<= number)
{
    Console.Write($"{number2} ");
    number2++;
}*/

/*Console.Write ("Введите любое число: ");
int number = int.Parse(Console.ReadLine()!); //         деление с остатком - %    456%10 = 45.6 получаем 6 ЕСЛИ             / - целочиссленное деление 456/10= 45
int num = number%10;
Console.WriteLine($"Последняя цифра числа {number} равна {num}");*/


/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number > number2)
{
    Console.WriteLine($"Большее число {number}, а меньшее число {number2} ");

}
else {
    Console.WriteLine($"Большее число {number2}, а меньшее число {number} ");
}*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

if(number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Максимальное число: {number1}");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Максимальное число: {number2}");
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"Максимальное число: {number3}");
}*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);



if (number%2 == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else Console.WriteLine($"Число {number} является нечетным");*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num2 = 1;

for (int i = num2; i <= number; i++)
{
    if (i % 2 == 0)
    {
Console.Write(i + " ");
    }
}

