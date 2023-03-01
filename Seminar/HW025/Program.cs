//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

Console.Clear();

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int GetSumByNumber(int limit)
{
int result = 0;
for(int i = 1; i<=limit; i++)
{
    result+=i;
}
return result;
}
Console.WriteLine($"Сумма сисел от 1 до {a} равна {GetSumByNumber(a)}");
