// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
void FindProductNum(int[] arr)
{
    int i = 0;
    int result = 0;
    int n = arr.Length;
    //if(arr.Length%2==0)
    // {
    while (i < arr.Length / 2)
    {

        Console.WriteLine(arr[i] * arr[n - 1]);
        i++;
        n--;
    }
    // }
}
int[] array = FillArray(6, 1, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindProductNum(array);


