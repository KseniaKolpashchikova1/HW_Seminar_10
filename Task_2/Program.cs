/* Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника. */
using System;
using static System.Console;
Clear();

int i, c;
WriteLine("Введите нужное количество строк треугольника Паскаля: ");
int n = Convert.ToInt32(ReadLine());

for (i = 0; i < n; i++)
{
    for (c = 0; c <= (n - i); c++)
    {
        Console.Write(" ");
        }
        for (c = 0; c <= i; c++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
            }
            Console.WriteLine();
            Console.WriteLine();
             }
            Console.ReadLine();

int Factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
 }