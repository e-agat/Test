//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет


Console.Clear();

Console.WriteLine("Введите 2 числа: ");

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

double squareOfFirstNum = Math.Pow(firstNum,2);
double squareOfSecondNum = Math.Pow(secondNum,2);

if(firstNum == squareOfSecondNum || secondNum == squareOfFirstNum)
{
    Console.WriteLine($"Одно из чисел {firstNum}, {secondNum} является квадратом другого");
}
else
{
    Console.WriteLine("Числа не являются квадрататми друг друга");
}
