// 7. напишите программу, которая принмает на вход трехзначное 
// число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0){
    number *= -1;
}
// % это деление "/" после которого остается остаток
 if (number >= 100 && number <= 999)
 {
    int lastDigit = number % 10; // ~ 458 % 10 = 8
    //Console.Write(lustDigit);
    Console.Write($"Последняя цифра числа: {lastDigit}");
 } else {
    Console.Write("Ошибка ввода");
 }