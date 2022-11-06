//Пирамида из цифр

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
Console.Write("\n");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.Write("\n");
}
