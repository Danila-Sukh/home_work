﻿Console.WriteLine("Введите координаты первой точки по очереди");
int X1=int.Parse (Console.ReadLine());
int Y1=int.Parse (Console.ReadLine());
int Z1=int.Parse (Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по очереди");
int X2=int.Parse (Console.ReadLine());
int Y2=int.Parse (Console.ReadLine());
int Z2=int.Parse (Console.ReadLine());
double max = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

Console.WriteLine(Math.Round(max, 2));