// 9. Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

 int number = new Random().Next(10, 100); //99+1 = 100
Console.WriteLine($"Случайное число из диапазона 10 - 99 ->{number}");
// int firstDigit = number / 10; // 78 / 10 = 7(.8) 8 отбрасывается
// int secondDigit = number % 10; // 78%10  остается 8  
// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"Max number = {firstDigit}");
// }else{
//     Console.WriteLine($"Иначе {secondDigit}");
// }

int maxDigit = MaxDigit(number);
Console.WriteLine($"Max number -> {maxDigit}");
int maxDigit1 = MaxDigit(56);
Console.WriteLine($"Max number -> {maxDigit1}");
int maxDigit2 = MaxDigit(88);
Console.WriteLine($"Max number -> {maxDigit2}");

int MaxDigit(int num){
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    return firstDigit > secondDigit ? firstDigit : secondDigit;

}

