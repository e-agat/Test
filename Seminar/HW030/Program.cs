// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool  FindNumber (int [] arr, int num)
{
for(int i=0; i < arr.Length; i++ )
{
    if(arr[i] == num)
    {
        return true;
   
    }
   
}
 return false;
}
int [] array = FillArray(8, 1, 15);
if(FindNumber(array, 5))
{
    Console.WriteLine($"Число присутствует в массиве [{String.Join(", ", array)}]");
}
else
{
    Console.WriteLine($"Числа нет в массиве [{String.Join(", ", array)}]");
}