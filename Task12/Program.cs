// 12. Напишите программу, которая будет принимать на вход
// да числа и выводить,является ли первое число кратным второму.
// Если первое число не кратно второму, то программа выводит 
// остаток отделения.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно 4=4

Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int reninder = multiplicity(firstNum, secondNum);
// if (reninder == 0){
//     Console.WriteLine("Кратно") ;
// }else{
//     Console.WriteLine($" не кратно, остаток = {reninder}");
// }
Console.WriteLine(reninder == 0 ? "кратно" : $"не кратно, остаток {reninder}");

int multiplicity(int firstDigit, int secondDigit){
    return firstDigit % secondDigit;
}