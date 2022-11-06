// while = когда не знаме сколько надо итераций


Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int counter = 0;

// while (counter < n)
// {
//     Console.WriteLine($"Значение counter {counter}");
//     counter++;
// }

do // do  while - полезен, когда нам надо, чтобы цикл выполнился хотяб один раз
{
    Console.WriteLine($"Значение counter {counter}");
    counter++;
} while (counter < n);
