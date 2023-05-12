﻿// Задача 23

// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


Console.Write("Введите положительное целое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Cube(numberN);

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3} {count * count * count,5}");
        count++;
    }
}

 