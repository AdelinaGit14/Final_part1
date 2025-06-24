using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим исходный массив
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(' ');

        // Считаем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив 
        string[] resultArray = new string[count];

        // Новый массив
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }

        // Вывод массива 
        Console.WriteLine("Результат: ");
        Console.WriteLine(string.Join(", ", resultArray));
    }
}