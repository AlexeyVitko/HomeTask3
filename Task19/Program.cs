// Задача 19

// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 3. выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number > 9999 && number < 100000) || (number < -99999 && number > -100000));
{
    Console.WriteLine($"число {number} -> является пятизначным ");
}
else
{
     Console.WriteLine($"число {number} -> является пятизначным ");
     Console.WriteLine("Введите новое число");
}
// // int palidrom = palidrom(number);
// // Console.WriteLine($"{number} -> является палидромом");

// // bool Palidrom(int num)
// // {
// //     int digit1 = num / 10000;
// //     int digit2 = num / 1000 % 10;
// //     int digit4 = num / 100 % 10;
// //     int digit5 = num % 10;
// //     return digit1 == digit5 && digit2 == digit4 ? true : false;
// }