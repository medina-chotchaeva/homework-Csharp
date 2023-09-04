//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

GenerateArray(length);
Console.Write("Количество четных чисел в массиве: ");
Console.Write(EvenNumbers(array));

void GenerateArray(int length)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}


//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

GenerateArray(length);
Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.Write(FindSum(array));

void GenerateArray(int length)
{
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
}

int FindSum(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}


// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];

void GenerateArray(int length)
{
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble();
        Console.Write($"{array[i]:F2} ");

    }

}

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }

    return max - min;
}

GenerateArray(length);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {FindDifference(array):F2}");