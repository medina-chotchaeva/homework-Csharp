//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetExponent(int number, int extent)
{
    int result = 1;
    for (int i = 0; i != extent; i++)
    {
        result *= number;
    }
    return result;
}
int num = GetExponent(3, 5);
System.Console.WriteLine(num);


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;

}

int number = GetSumNum(1154);
System.Console.WriteLine(number);


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

PrintArray(GenerateArray(8));

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 99);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

