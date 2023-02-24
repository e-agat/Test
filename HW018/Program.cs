//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Clear();

Console.WriteLine("Введите два числа: ");

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

int remainder = firstNum % secondNum;

if (remainder == 0)
{
    Console.WriteLine($"Число {secondNum} кратно числу {firstNum}");
}
else
{
    Console.WriteLine($"Число {secondNum} не кратно числу {firstNum}, остаток от деления равен {remainder}");
}
