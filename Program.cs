Console.Write("Введи 1 число: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи 2 число: ");
int m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();