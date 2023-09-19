// int num = 656427;
// int num1= num / 100 ;
// int num2 = num1 % 10;
// Console.WriteLine(num2);

// 17. Напишите программу, которая на вход принимает координаты точки
// ( X и Y ), причем x != 0 и y != 0  и выдает номер четверти 
// плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quar = GetQuarter(xCoordinate, yCoordinate);
string result = quar > 0 
        ? $"Указанные координаты соответствуют четверти -> {quar}"
        : "Введены некоректные данные";
Console.WriteLine(result);

int GetQuarter(int x, int y){
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}