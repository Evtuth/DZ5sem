//задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2.

int[] CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int EvenAmount(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            amount += 1;
        }
    }
    return amount;
}

int[] array = new int[12];
array = CreateArray(array);
Console.Write("Ваш массив случайных трёхзначных чисел: ");
Console.WriteLine(string.Join(", ", array));

int amount = EvenAmount(array);
Console.Write($"Количество чётных элементов массива равно {amount} !!!");
