Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n) Console.WriteLine($"Первое число {m} больше второго {n}. Поиск натуральных чисел рассчитываеться от второго к первому");
int result = Count(m, n);
int Count(int m, int n)
{
    if (m == n && m > 0)
    {
        Console.Write($" {m} ");
        return m;
    }
    else if (m < n && m > 0)
    {
        Console.Write($" {m} ");
        return Count(m + 1, n);
    }
    else if (m > n) return Count(n, m);
    else return Count(1, n);
}