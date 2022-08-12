Console.WriteLine("Введите число");
Double number = double.Parse(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("Число равно нулю");
}
else if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else Console.WriteLine("Число нечетное");