// Домашняя работа в конце
/*
//TASK_1 Квадрат числа
/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

// Математический  
int sqr = number*number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");

//Biblioteka
int sqr1 = Convert.ToInt32(Math.Pow(number, 3));
Console.WriteLine($"Куб числа {number} равен {sqr1}");
*/
/*
//TASK_2 является ли первое число квадратом второго 
Console.Write("Введите A = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B = ");
int b = int.Parse(Console.ReadLine()!);

if (a == Convert.ToInt32(Math.Pow(b, 2)))
{
    Console.WriteLine($"Число А {a} ЯВЛЯЕТСЯ квадратом числа {b}");
}
else Console.WriteLine($"Число А {a} НЕ является квадратом числа {b}");
*/
/*
//TASK_3 День недели
Console.Write("Enter day number of week: ");
int day = int.Parse(Console.ReadLine()!);
if (day == 1) Console.WriteLine("Today is Monday");
if (day == 2) Console.WriteLine("Today is Tuesday");
if (day == 3) Console.WriteLine("Today is Wednesday");
if (day == 4) Console.WriteLine("Today is Thursday");
if (day == 5) Console.WriteLine("Today is Friday");
if (day == 6) Console.WriteLine("Today is Saturday");
if (day == 7) Console.WriteLine("Today is Sunday");
if (day<1 || day > 7) Console.WriteLine("Error: Wrong number");
*/
/*
//TASK_4 постойте диапозон от отрицательгого до положительного заначения введенного числа
Console.Write("Введите число: ");
int diapoz = int.Parse(Console.ReadLine()!);
int diapoz2 = -diapoz;

while (diapoz2 <= diapoz) {
    Console.Write($"{diapoz2} ");
    diapoz2 ++;
}
*/

/*
//TASK_5 Выведите последнюю цифру трехзначного числа
Console.Write("Введите трехзначиное число: ");
int tri = int.Parse(Console.ReadLine()!);
// % - деление с остатком Ex: 456%10=45.6 ->6
// / - деление целочисленное  Ex: 456/10=45 ->45
Console.WriteLine($"Послежняя цифра от числа {tri} равна {tri%10}");
*/

/*
// HOMEWORK
//HW_TASK_2 поиск наибольшего числа из двух 
Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
if (first > second) Console.WriteLine($"max = {first}");
else Console.WriteLine($"max = {second}");
*/

/*
//HW_TASK_4 поиск наибольшего числа из трех чисел
using System.ComponentModel.DataAnnotations;

Console.Write("Введите первое число: ");
int first1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int third = int.Parse(Console.ReadLine()!);
int maks = first1;
if (maks < second1) maks = second1;
if (maks < third) maks = third;
Console.Write(maks);
*/

/*
//HW_TASK_6 четное нечетное
Console.Write("Введите число: ");
int nolornotnol = int.Parse(Console.ReadLine()!);

if (nolornotnol % 2 == 0) Console.Write($"Число {nolornotnol} четное");
else Console.Write($"Число {nolornotnol} не четное");
*/

//HW_TASK_8 четнst от 1 до N
Console.Write("Введите число: ");
int dochisla = int.Parse(Console.ReadLine()!);
int i = 1;

while (i <= dochisla) {
    if (i%2 == 0) Console.Write($"{i}, ");
    i = i+1;
}