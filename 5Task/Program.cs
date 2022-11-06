// for-цикл удобен, когда мы знаме сколько мы сделаем итераций


Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

for (int i = n; i >= 0; i--)
{
    Console.WriteLine($"Значение {i}");
}