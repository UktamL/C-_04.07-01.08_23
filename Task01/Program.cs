// Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом 
// второго.
// a = 25, b = 5 -> yes
// a = 2, b = 10 -> no
// a = 9, b = -3 -> yes
// a = -3, b = -9 -> no

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b number");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.Write("Yes");
} 
else 
{
    Console.Write("No");
}
