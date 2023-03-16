// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] FillArray(int size, double min, double max)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next((int)min, (int)max);
    }
    return result;
}
double FindMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double FindMin(double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
double[] array = FillArray(10, 1.1, 20.2);
double result = FindMax(array) - FindMin(array);
Console.WriteLine($"Разица между максимальым и минимальым числом массива [{String.Join(", ", array)}] равна {result}");