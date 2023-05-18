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

bool palidrom = Palidrom(number);
if (palidrom==true)
{
    Console.WriteLine($"число {number} -> является палиандром ");
} 
else
{
    Console.WriteLine($"число {number} -> Не является палиандром  ");
}

if ((number > 9999 && number < 100000) || (number < -9999 && number > -100000))
{
    Console.WriteLine($"число {number} -> является пятизначным ");
}
else
{
    Console.WriteLine($"число {number} -> Не является пятизначным ");
    Console.WriteLine("Введите новое число");
}

bool Palidrom(int num)
{
    int digit1 = num / 10000;
    Console.WriteLine(digit1);
    int digit2 = num / 1000 % 10;
    Console.WriteLine(digit2);
    int digit4 = num % 100 /10;
    Console.WriteLine(digit4);
    int digit5 = num % 10;
    Console.WriteLine(digit5);
    return digit1 == digit5 && digit2 == digit4 ? true : false;
}