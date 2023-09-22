// 31. Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
// элементов массива.
// Например: [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// чисел равна 29, сумма триательных равна -20

// метод создания массива

int[] ArrayAutoInt(int size, int min, int max){
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; 
}

// печатающий метод
void PrintArray(int[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++){
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
//метод сложения положительных чисел
int SumPlus(int[] arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] > 0) sum += arr[i];
    } 
    return sum;
}
// метод вычитания отрицательных чисел
int SumMinus(int[] arr){
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    } 
    return sum;
}

// метод вычитания и сложения чисел 2 в 1
int[] SumPlusMinus(int[] arr){
    int plus = 0;
    int minus = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i] > 0){
            plus += arr[i];
        } else {
            minus += arr[i];
        }
    }
    return new int[] {plus, minus};
}
int[] array = ArrayAutoInt(12, -9, 9);
PrintArray(array);

int sumPlus = SumPlus(array);
int sumMinus = SumMinus(array);
Console.WriteLine($"Сумма положительных = {sumPlus}, сумма отрицательных = {sumMinus}");

int[] result = SumPlusMinus(array);

Console.WriteLine($"сумма положительных = {result[0]}, сумма отрицательных = {result[1]}");