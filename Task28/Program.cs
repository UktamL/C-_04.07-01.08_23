// 28. Напишите программу, которая принимает на вход число N и выдает
// произведение чисел от 1 до N.
// 4->24
// 5->120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumFact = Factorial(number);
Console.WriteLine(sumFact);


int Factorial (int num){

        int fact = 1;
        for(int i = 1; i <= num; i++ ){
            checked{
                fact *= i; // sum =  sum * i
            }
            
        }
        return fact; 
}