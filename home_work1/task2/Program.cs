Console.WriteLine("Введите первое число");

int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB)
{
    Console.WriteLine("Первое число равно второму числу");
}
else if (numberA > numberB)
{
    Console.WriteLine("Первое число большее чем второе");
}
else Console.WriteLine("Первое число меньшее чем второе");