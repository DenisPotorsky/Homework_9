using static System.Console;
Clear();
// Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
WriteLine("Введите значения");
int x = int.Parse(ReadLine()!);
int y = int.Parse(ReadLine()!);

if (x < 0 || y < 0)
{
    WriteLine("ERROR");
    return;
}

WriteLine(AckermannFunction(x,y));

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}