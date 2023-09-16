// 11. напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// int number = Console.ToInt32(Console.Readline());
 int number = new Random().Next(100, 1000 );
 Console.WriteLine($"Случайное число из диапазона 10 - 99 ->{number}");
//int firstDigit = number / 100;
//int secondDigit = number % 10;
//Console.WriteLine($"Первое и третье число из трехзначного = {firstDigit}{secondDigit}");

int RemoveSecondDigit(int num){
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit*10 + secondDigit;// первое число умношается на 10 и 
// второе прибавляется к первому... умно.
    return result;
 
}

int remove1 = RemoveSecondDigit(number);
Console.WriteLine(remove1);
int remove2 = RemoveSecondDigit(684);
Console.WriteLine(remove2);
int remove3 = RemoveSecondDigit(834);
Console.WriteLine(remove3);


