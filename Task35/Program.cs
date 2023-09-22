// 35. Задавайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых
// лежат в отрезке[10, 99].
// пример для массива из 5, а не 123 элементов. 
// В своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] ->0
// [10, 11, 12, 13, 14] ->5

/* int[] randomArrray(int size, int min, int max){
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

int finedTwoNumbers(int[] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i]>=10&&arr[i]<=99){
            count ++;
        }
    }
    return count;
}

int[] array  = randomArrray(5, -200, 200);
PrintArray(array);

int fined = finedTwoNumbers(array);
Console.WriteLine(fined);
 */



// 37. Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        Console.Write(arr[i]);
        if(i == arr.Length -1){
            break;
        };
        Console.Write(", ");
    }
    Console.WriteLine("]");
}

int[] numberPair(int[] arr){
    int size = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2+1;
    int[] product = new  int[size];
    for(int i = 0; i< size; i++ ){
        int prod = arr[i] * arr[arr.Length -i -1];
        product[i] = prod;
    }
    if(arr.Length %2 != 0) product[size -1] = arr[arr.Length / 2];
    return product;
}

int[] array  = ArrayAutoInt(5, 1, 9);
PrintArray(array);

int[] prodict = numberPair(array);
PrintArray(prodict);
