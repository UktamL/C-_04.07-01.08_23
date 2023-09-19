// Задача 19: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

/* Console.Write("Введите число: ");
//string? number = Console.ReadLine();
string number = Console.ReadLine();

void CheckNumberFive(string num){
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckNumberFive(number);
}
else Console.WriteLine($"Некорректное число"); */


// // Задача 21: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D 
// пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/* Console.WriteLine("Введите координаты точки A: ");
Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance3d = ThreeD(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"расстояние между точками A и B  в 3D пространстве = {distance3d}");


double ThreeD(int a1, int b1, int c1, int a2, int b2, int c2){
    double XCoordinate = a2 - a1;
    double YCoordinate = b2 - b1;
    double ZCoordinate = c2 - c1;
    double distance = Math.Sqrt(XCoordinate*XCoordinate+
                                YCoordinate*YCoordinate+
                                ZCoordinate*ZCoordinate);
    return distance;
} */



// //Задача 23: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/* Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);

void Square(int num){
    int count = 1;
    while(count <= num){
        Console.WriteLine($"{count} {count*count*count}");
        count++;
    }
} */

