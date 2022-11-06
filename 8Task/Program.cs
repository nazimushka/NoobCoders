// Вывод четных чисел

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    if (i % 2 != 0)
    {
        continue;
    }
    Console.WriteLine($"Значение {i}");
}
