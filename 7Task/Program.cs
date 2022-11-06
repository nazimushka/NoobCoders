// не знаем, когда надо прервать выполенние

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int counter = 0;

while (true)
{
    Console.WriteLine($"Значение counter {counter}");
    counter++;
    if (counter >= n)
    {
        break;
    }
}

Console.WriteLine($"URRRA!");
