// 24. Напишите программу, которая принимает на вход число (A) и 
// выдает сумму чисел от 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sun2 = Summa(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sun2} ");

int Summa (int num){
        int sum = 0;
        for(int i = 1; i <= num; i++ ){
            sum += i; // sum =  sum + i
        }
        return sum; 
}