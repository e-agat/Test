//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//int a = 25, b = 5;
int a = new Random().Next(1,5);
Console.WriteLine(a);
int b = new Random().Next(1,3);
Console.WriteLine(b);

if (Math.Sqrt(a) == b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}





