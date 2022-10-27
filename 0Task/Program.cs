Console.WriteLine("Введите число:");
string number = Console.ReadLine();

int intNum = int.Parse(number);

intNum++;
intNum += 1;

Console.WriteLine($"Теперь значение введённого числа равно: {intNum}");

// Для того, чтобы программа не "схлапывалась сразу после вывода
Console.Read();
