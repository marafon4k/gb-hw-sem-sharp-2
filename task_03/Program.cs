// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


while (true)
{
    Console.WriteLine("Введите цифру");
    if (int.TryParse(Console.ReadLine(), out var number))
    {
        if (number < 1 || number > 7)
        {
            Console.WriteLine("Неверный диапазон");
            continue;
        }

        Console.WriteLine(number <= 5 ? "Нет" : "Да");
        break;
    }
    else
    {
        Console.WriteLine("Введи число");
    }
}







// int number = 0;

// while (true) {
//     Console.WriteLine("Введите цифру (день недели): ");
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number >= 1 && number <= 7) {
//         break;
//     }
//     if (number < 1 || number > 7) {
//         Console.WriteLine("Вы ввели недопустимый диапазон!");
//     }
// }

// if (number >= 1 && number <= 5) Console.WriteLine("Нет");
// if (number >= 6 && number <= 7) Console.WriteLine("Да");
