/*
Задача 68: Задайте значения M и N. 
Напишите программу, которая найдёт наибольший общий 
делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"M = {numberM}; N = {numberN} -> {Nod(numberM, numberN)}");

int Nod(int n, int m)
{
    if (m == 0)
        return n;
    return Nod(m, n % m);
}
