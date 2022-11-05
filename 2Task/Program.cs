// Напишите программу, в которой пользователь вводит с клавиатуры 4 числа.
// Программа должна вывести наибольшее число и наименьшее число
// Sample Input:
// 8 11 16 20
// Sample Output:
// Наименьшее число - 8


string line = Console.ReadLine();
string[] splitString = line.Split(' ');

int a = Convert.ToInt32(splitString[0]);
int b = Convert.ToInt32(splitString[1]);
int c = Convert.ToInt32(splitString[2]);
int d = Convert.ToInt32(splitString[3]);

int[] arr = new int[] { a, b, c, d };
Array.Sort(arr);
if (arr.Length > 0)
{
    Console.WriteLine("Наименьшее число - " + arr[0]);
    Console.WriteLine("Наибольшее число - " + arr[arr.Length - 1]);
}
