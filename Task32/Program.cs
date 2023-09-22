// 32. напишите программу замены элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// создает метод массива
/* int[] ArrayAutoInt(int size, int min, int max){
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


void numberArray(int[] array){
    for (int i = 0; i < array.Length; i++ ){
        array[i] *= -1;
    }
}

int[] array = ArrayAutoInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();

numberArray(array);
PrintArray(array); */

// 33. Задайте массив. напиишите программу, которая определяет ,
// присутствует ли заданное число в массиве.
// 4; [4, 7, 19, 345, 3] -> no
// 3; [6, 7, 19, 345, 3] -> yes

int[] ArrayAutoInt(int size, int min, int max){
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; 
}

void PrintArray(int[] arr){
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++){
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

bool finedNumber(int num, int[] array){
    for(int i =0; i < array.Length; i++){
        if (array[i] == num) return true;
        
    }
    return false;
}

int[] array  = ArrayAutoInt(12, -9, 9);
PrintArray(array);
bool isExsistNumber = finedNumber(6, array);
Console.WriteLine(isExsistNumber);