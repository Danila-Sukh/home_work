Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine());
int i = 1;
int result = 1;
while (i <= b)
{
    result = result * a;
    i++;
}
Console.WriteLine(result);