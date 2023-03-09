// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых 
//лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] FillArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int SumNum(int [] arr)
{
    int result = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if(arr[i]>10 && arr[i]<99)
        {
result++;
        }
    }
    return result;
}

int [] array = FillArray(123, 1, 200);
Console.WriteLine ($"[{String.Join(", ", array)}]");
Console.WriteLine(SumNum(array));



