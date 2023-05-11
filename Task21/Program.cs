// // Задача 21

// // Напишите программу, которая 
// 1.принимает на вход координаты двух точек и 
// 2.находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z = ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xA, yA, zA, xB, yB, zB);

Console.WriteLine("Расстояние между точками в 3D пространстве = ");
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)

// Вариант 1
// {
//     int katet1 = x2- x1;
//     Console.WriteLine($"x2-x1 -> {katet1}");
//     int katet2 = y2 - y1;
//     Console.WriteLine($"y2-y1 -> {katet2}");
//     int katet3 = z2 - z1;
//     Console.WriteLine($"z2-z1 -> {katet3}");
//     double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2 + katet3 * katet3);
//     return hypo;
// }

// Вариант2
// {
// double sumcatet = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
// double distance = Math.Sqrt(sumcatet);
// return distance;
// }

// Вариант 3
{
     double distance = Math.Sqrt (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
     return distance;
}
