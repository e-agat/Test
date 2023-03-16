// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int [] FillArray(int size, int min, int max)
{
    int []result = new int [size];
    for(int i = 0; i< result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int FindSumElements(int [] arr)
{
    int sum = 0;
    for(int i = 1; i< arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
int [] array = FillArray(10, 1, 20);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве [{string.Join(", ", array)}], равна {FindSumElements(array)}");