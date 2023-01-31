// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int N = Convert.ToInt32(Console.ReadLine());

void FindNumbers(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных чисел в промежутке [M;N] = {sum}");
        return;
    }
    sum = sum + (M++);
    FindNumbers(M, N, sum);
}

FindNumbers(M, N, 0);
