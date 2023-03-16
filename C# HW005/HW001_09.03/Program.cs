// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int WritePositieNum (int [] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count+=1;
        }
        
    }
    return count;
}
int [] array = FillArray(10, 100, 1000);
Console.WriteLine($"В массиве [{string.Join (", ", array)}] {WritePositieNum(array)} четных чисел(ла)");