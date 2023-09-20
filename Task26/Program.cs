// 26. Напишите программу, которая принимает на вход число и 
// выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = numberLength(number);
Console.WriteLine(result);

int numberLength(int num){
    if (num == 0 ) return 1;
    int counter = 0;
    while (num != 0){
        num /= 10;
        counter++;
    }
    return counter;
}