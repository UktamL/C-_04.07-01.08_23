// 2. Напишите программу, которая на вход принимает два 
// числа и выдает, какое число большее, а какое меньшее.
// a = 5, b = 7  -> max = 7
// a = 2, b = 10 -> max = 10
// a = -9, b = -3 -> max = -3
/* Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b){
    Console.WriteLine($" max = {a}");
} else {
    Console.WriteLine($" max = {b}");
} */

// 4. Напишите программу, которая принимает на вход три числа и
// выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78 
// 22, 3, 9 -> 22

//  Console.Write("Введите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
//     int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
//     int c = Convert.ToInt32(Console.ReadLine());
//     int max = a;
    
// Вариант №3
/*     int max = Math.Max(a, Math.Max(b, c));
    Console.WriteLine(max); */

// Вариант №2
  /*   if (b > max && b > c) Console.Write(max = b);
    if (c > max && c > b) Console.Write(max = c);
    if (max > b && max > c) Console.Write(a); */
// в чем разница? если только else нету...,
// разницы особой нету от варианта 1...

// Вариант №1
/*
if (a > b && a > c){
    Console.WriteLine($"Максимальное число = {a}");
} else if(b > a && b > c){
    Console.WriteLine($"Максимальное число = {b}");
} else if (a < c && b < c){
    Console.WriteLine($"Максимальное число = {c}");
} else {
    Console.WriteLine("Чет пошло не так");
} */


// 6. Напишите программу, которая на вход принимает число и 
// выдает, является ли число четным 
// ( делитя оно на 2 без остатка).
//  4 -> yes
//  -3 -> no
//  7 -> no

/* Console.Write("Введите любое число:  ");

int a = Convert.ToInt32(Console.ReadLine());

if ((a % 2) == 0){
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("no");
} */



// 8. Напишите программу, которая на вход принимает число N,
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
} */
