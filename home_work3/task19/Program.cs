﻿Console.WriteLine("Введите пятизначное число: ");
string str=Console.ReadLine();
if (str[0]==str[4] && str[1]==str[3])   Console.Write("Число палиндром");
else  Console.Write("Число не палиндром");