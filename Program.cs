﻿/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double b1;
Console.WriteLine("Vvedite pervoe 4islo dli pervoi przmoi");
double.TryParse(Console.ReadLine(), out b1);
double k1;
Console.WriteLine("Vvedite vtoroe 4islo dli pervoi przmoi");
double.TryParse(Console.ReadLine(), out k1);
double b2;
Console.WriteLine("Vvedite pervoe 4islo dli vtoroi przmoi");
double.TryParse(Console.ReadLine(), out b2);
double k2;
Console.WriteLine("Vvedite vtoroe 4islo dli vtoroi przmoi");
double.TryParse(Console.ReadLine(), out k2);
double x = ((b2 - b1)/(k2-k1))/2;
double y = k2*x+b2;
Console.WriteLine($"To4ka perese4enii dvux primix: x={x}, y={y}");
