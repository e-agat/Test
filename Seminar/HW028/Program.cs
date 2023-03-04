/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

void WriteBinRandValue(int[] arr)
{
    int arrLenght = arr.Length;
    for (int i = 0; i < arrLenght; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArr(int[] arr)
{
    Console.WriteLine($"");
}

const int arrLenght = 8;
int[] arrBinNumRand = new int[arrLenght];

WriteBinRandValue(arrBinNumRand);
PrintArr(arrBinNumRand);


Console.WriteLine($"Вывод №2! [{string.Join(", ", arrBinNumRand)}]");

