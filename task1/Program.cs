// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений M и N
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        // Вызов рекурсивной функции для вывода чисел от M до N
        PrintNumbersInRange(m, n);

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static void PrintNumbersInRange(int start, int end)
    {
        // Базовый случай: если начальное значение больше конечного
        if (start > end)
            return;

        // Вывод текущего значения
        Console.WriteLine(start);

        // Рекурсивный вызов для следующего числа
        PrintNumbersInRange(start + 1, end);
    }
}
