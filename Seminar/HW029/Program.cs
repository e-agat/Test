// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


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
int[] ReplaceNum(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] *= -1;

    }

    return arr;
}


int[] array = FillArray(8, -5, 6);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"[{String.Join(", ", ReplaceNum(array))}]");