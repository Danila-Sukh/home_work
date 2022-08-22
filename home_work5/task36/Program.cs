int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

int Summ(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum = sum + array[i];

    }
    return sum;
}
int[] array = new int[8];
Console.WriteLine(" ");
Console.WriteLine("Сумма нечетных элементов равна: " + Summ(FillArray(array)));