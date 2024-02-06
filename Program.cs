using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку элементов, разделяя их запятой:");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');

        // Считает сколько в массиве элементов <= 3, чтобы создать массив необходимой длинны
        int j = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                j++;
            }
        }

        // Создаем новый массив для хранения строк
        string[] newArray = new string[j];
        int newIndex = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            // Если длина строки <= 3 символам, добавляем ее в новый массив
            if (inputArray[i].Length <= 3)
            {
                newArray[newIndex] = inputArray[i];
                newIndex++;
            }
        }
        // Выводим новый массив строк
        Console.WriteLine();
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i < newArray.Length - 1)
            {
                Console.Write(newArray[i] + ", ");
            }
            else
            {
                Console.Write(newArray[i]);
            }
        }
    }
}