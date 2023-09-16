// 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, являелтся ли одно число квадратом другого.
// 5, 25 -> yes
// -4, 16 -> yes
// 25, 5 -> yes
// 8, 9 -> no

Console.WriteLine("Введите первое число :");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = squaAr(number1, number2);
Console.WriteLine(result ? "yes" : "no");

bool squaAr(int squar1, int squar2){
 return squar1 == squar2 * squar2 || squar2 == squar1 * squar1;
   
}  