// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений m и n
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        // Вызов функции Аккермана и вывод результата
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Значение функции Аккермана для ({m}, {n}) равно {result}");

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
