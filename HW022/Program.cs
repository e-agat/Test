// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти: ");

int quarterNum = int.Parse(Console.ReadLine());

if(quarterNum==1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if(quarterNum==2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if(quarterNum==3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if(quarterNum==4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Такой четверти нет");
}