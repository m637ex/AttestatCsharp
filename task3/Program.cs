// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Произвольный массив чисел
        int[] array = { 1, 2, 3, 4, 5 };

        // Вызов рекурсивной функции для вывода элементов массива
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        // Базовый случай: если индекс стал меньше 0 (выход за границы массива)
        if (index < 0)
            return;

        // Вывод текущего элемента массива
        Console.WriteLine(array[index]);

        // Рекурсивный вызов для следующего элемента массива (с предыдущим индексом)
        PrintArrayReverse(array, index - 1);
    }
}
