// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 1000 || number < -100 && number > -1000)
    Console.WriteLine(number % 10);
if (number < 100 && number > -100)
    Console.WriteLine("Третьей цифры нет");

int ThirdNumber(int a)
{
    while (number > 100000 || number < -100000)
    { // Проверка в цикле на положительное или отриц число 100к
        number = number / 10;
    }
    number = number / 100;
    number = number % 10;
    return number;
}

if (number > 1000 || number < -100)
    Console.WriteLine(ThirdNumber(number));