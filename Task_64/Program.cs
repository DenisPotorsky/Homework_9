using static System.Console;
Clear();
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные 
// числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Write("Введите значение N: ");
int num = int.Parse(ReadLine()!);
NaturalNumbers(num);

void NaturalNumbers(int n)
{
    if (n == 0) return;
    Write($"{n} ");
    NaturalNumbers(n - 1);
}