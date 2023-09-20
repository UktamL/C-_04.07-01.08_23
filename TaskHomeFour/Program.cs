// Задача 25: Напишите цикл, который принимает на вход два
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int Factorial(int a, int b){
    int fact = 1;
    for(int i = 1; i <= b; i++){
        fact = fact * a;
    }
    return fact;
}

int result = Factorial(numberOne, numberTwo);
Console.WriteLine(result);
 */


// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

int result = sum(numberOne);
Console.WriteLine(result);

int sum(int a){
    if (a < 10) return a;
    int digit = a % 10;
    int nextA = a / 10;
    return digit + sum(nextA);
}

// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов заполненный псевдослучайными числами 
//и выводит их на экран.
// 1, 2, 5, 7, 19 ->[1,2,5,7,19]
// 6, 1, 33 -> [6,1,33]


//вариант №1
/* Console.WriteLine("Задайте массив из 8 элементов");

void ArrayRandom(int[] arr){
    int[] randomArray = new int[8];

    for (int i = 0; i < 8; i++)
        {
            randomArray[i] = new Random().Next(1,99);
            Console.Write(randomArray[i] + » «);
        }
} */

//вариант №2