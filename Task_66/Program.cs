using static System.Console;
Clear();
// Задайте значения M и N. 
// Напишите программу, которая найдёт
// сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30;

System.Console.Write("Значение М: ");
int m = int.Parse(ReadLine()!);
System.Console.Write("Значение N: ");
int n = int.Parse(ReadLine()!);

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

int result = SumNaturalNumbers(m, n);
Write($"Сумма натуральных элементов: {result}");

int SumNaturalNumbers(int x, int y)
{
    if (x == y) return x;
    else return x + SumNaturalNumbers(x + 1, y);
}