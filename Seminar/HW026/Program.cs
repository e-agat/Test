/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

Console.Clear();

Console. WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

/*int GetLenghtNumberToStr(int value) 
{
    string spamNumber = value.ToString();
    return spamNumber.Length;
}*/
int GetLenghtNumberMath(int value)
{
    if( value == 0)
    {
        return 1;
    }
    
    int count = 0;
    for(int i = 0; value >= 1; i++)
    {
        value /= 10;
        count++;
    }
    return count;
}
Console. WriteLine(GetLenghtNumberMath(a));