// 14. Напишите прорамму, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> no
// 46 -> no
// 161 -> yes

Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

bool twoBool = TwoBool(number);
Console.WriteLine(twoBool ? "yes" : "no");


bool TwoBool(int num1 ){
    return num1 % 7 == 0 && num1 % 23 == 0 ;
      
}