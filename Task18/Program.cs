// 18. напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координатных точек в этой 
// четерти(x и y).
Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string diapazon = GetCoordinate(quarter);

Console.WriteLine(diapazon == null ?$"введен некоректный номер" : $"{diapazon}");



string GetCoordinate(int quarNumber){
    if(quarter == 1) return "x > 0, y > 0";
    if(quarter == 2) return "x < 0, y > 0";
    if(quarter == 3) return "x < 0, y < 0";
    if(quarter == 4) return "x > 0, y < 0";
    return null;
}