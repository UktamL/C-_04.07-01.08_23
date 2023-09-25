// 46.Задайте двумерный массив размером MxN, заполненный случайными 
// целыми числами.
// m = 3
// n = 4
// 0   1   4    8   19
// 1   5  -2   33   -2
// 2  77   3    8    1



// int[ , ] CreateMatrixRndInt(int rows, int columns, int min, int max){
//     int[,] matrix = new int[rows, columns]; // rows = 3; columns = 4
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++){
//         for(int j = 0; j < matrix.GetLength(1) ; j++){
//                 matrix[i,j] = rnd.Next(min, max +1);
//         }
//     }
//     return matrix; 
// }



// void PrintMatrix(int[,] matrix){
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i,j], 4}");
//         }
//          Console.WriteLine("]");
//     }
   
// }

// int[,] twoArray = CreateMatrixRndInt(3, 4, -100, 100);
// PrintMatrix(twoArray);

////////////////////////////////////////////////////////////////

// 48 Задайте двумерный массив размером m на n, каждый элемент 
// в массиве находится по формуле: Amn = m + n.
// Выыедите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5
/* int[ , ] sumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns]; // rows = 3; columns = 4
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         for(int j = 0; j < matrix.GetLength(1) ; j++)
        {
                matrix[i,j] =i + j;
        }
    }
    return matrix; 
}

void PrintSumIndex(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
         Console.WriteLine("]");
    }
}
int[,] arr = sumIndex(3, 4);
PrintSumIndex(arr); */


////////////////////////////////////////////////////////
// 49.Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса четные, и замените эти элементы на их квадраты.
// Например:       как будет выглядеть:
// 1 4 7 2             1 4 49 2
// 5 9 2 3             5 9 2 3
// 8 4 2 4             64 4 4 4
/* Console.WriteLine("Введите двумерный массив");

// metod 
int[,] CreateArray (int rows, int colons, int min, int max){
    int[,] replace = new int[rows, colons];
    Random rnd = new Random();
    for(int i = 0; i < replace.GetLength(0); i++){
        for(int j = 0; j < replace.GetLength(1); j++){
            replace[i, j] = rnd.Next(min, max +1);
        }
    }return replace;
}

void PrintArray (int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
         Console.WriteLine("]");
    }
}
void ReplaceArray(int[,] array){
    for(int i=0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i%2== 0 && j%2==0) array[i,j] *= array[i,j];
            
        }
    }
}
int[,] arr = CreateArray(3, 4, 1, 9);
PrintArray(arr);
Console.WriteLine("/////////////////////////");
ReplaceArray(arr);
PrintArray(arr); */

/////////////////////////////////////////////////////////////

// 51. Задайте двумерный массив. Найдите суммуэллементов, находящихся
// на главной диагонали(с индексами (0,0; (1,1) и тд.)).
// например:
// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4 
// Сумма элементов главной диагонали 1+9+2=12

// metod 
int[,] CreateArray (int rows, int colons, int min, int max){
    int[,] replace = new int[rows, colons];
    Random rnd = new Random();
    for(int i = 0; i < replace.GetLength(0); i++){
        for(int j = 0; j < replace.GetLength(1); j++){
            replace[i, j] = rnd.Next(min, max +1);
        }
    }return replace;
}

void PrintArray (int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 4}");
        }
         Console.WriteLine("]");
    }
}
int SumElemDiag(int[,] array){
    int sumResult = 0;
    for(int i=0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
           if(i == j)  sumResult += array[i, j];
        }
    } 
    return sumResult;
}
int[,] arr = CreateArray(3, 4, 1, 9);
PrintArray(arr);
Console.WriteLine("/////////////////////////");
int sumResult = SumElemDiag(arr);
Console.WriteLine(sumResult);