// 10. напишите программу, которая нпринимает на вход трехзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


/* Console.WriteLine("Введите трехзначное  число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringIndex= Convert.ToString(number);
Console.WriteLine("вторая цифра этого числа -> "+stringIndex[1]); */



// 13. Напишите программу, которая выводит третью цифру заданного 
// числа и сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> no 3 number
// 32679 -> 6


/* Console.Write("Введи число: ");
int number= Convert.ToInt32(Console.ReadLine());
string strAnyNumber= Convert.ToString(number);
if (strAnyNumber.Length > 2){
  Console.WriteLine("третья цифра -> " + strAnyNumber[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
 */



// 15. Напишите программу, которая примает на вход цифру, 
// обозначающую день недел, и проверяет, является ли этот день 
// выходным
// 6 -> yes
// 7 -> yes
// 1 -> no

/* Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void weekNumber (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

weekNumber(dayNumber); */
