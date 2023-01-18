//Задача 36. Задайте одномерный массив,
//заполненый случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = new int[6];
array = CreateArray(array);
Console.Write("Ваш массив случайных чисел: ");
Console.WriteLine(string.Join(", ", array));

int sum = SumOddIndex(array);
Console.Write($"Сумма элементов массива, стоящих на нечётных позициях равна {sum} !!!");
