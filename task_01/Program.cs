// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3х значное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int a) {
    int firstNumber = a / 100; // 4
    int secondNumber = a % 10; // 6
    a = a - secondNumber; // 456 - 6 = 450
    a = a - firstNumber * 100;
    a = a / 10;
    return a;
}

int sum = SecondNumber(number);
Console.WriteLine(sum);