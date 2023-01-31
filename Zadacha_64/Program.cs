// Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbers(int N)
{
    if (N == 0) return;
    Console.WriteLine(N);
    PrintNumbers(N - 1);
}

int N = 5;
PrintNumbers(N);
