//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46

Console.Clear();

int num = new Random().Next(100, 1000);
Console.WriteLine($"Число: {num}");

int firstValue = num / 100;
int thirdValue = num % 10;

int result = firstValue * 10 + thirdValue;

Console.WriteLine($"Результат удаления второй цифры из числа: {result}");


