Console.WriteLine("Введите цифру обозначающую день недели");
int a = int.Parse(Console.ReadLine());
if (a == 6 || a == 7) Console.WriteLine("Выходной!!!");
else Console.WriteLine("Не сегодня.");