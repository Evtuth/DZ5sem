//Задача 38. Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элементов массива.
//[3.7, 7.2, 2.1, 7.8] -> 5.7

double[] CreateArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*10, 1);
    }
    return array;
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] array = new double[12];
array = CreateArray(array);
Console.Write("Ваш массив вещественных чисел: ");
Console.WriteLine(string.Join("; ", array));

double min = MinNumber(array);
double max = MaxNumber(array);
double diff = Math.Round(max - min, 1);
Console.Write($"Разница между максимальным и минимальным элементами массива равна {diff} !!!");
