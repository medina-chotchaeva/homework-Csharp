//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2-> 2
//1, -7, 567, 89, 223-> 3



Console.WriteLine("Сколько чисел вы хотите ввести?");
int lengthOfArr = Convert.ToInt32(Console.ReadLine());
int[] result = new int[lengthOfArr];


void newArray(int lengthOfArr)
{
    for (int i = 0; i < lengthOfArr; i++)
    {
        Console.WriteLine("Введите число массива");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int NumberSum(int[] result)
{
    int sum = 0;
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i] > 0)
            sum++;
    }
    return sum;
}

newArray(lengthOfArr);
Console.WriteLine($"Чисел больше нуля: {NumberSum(result)}");




// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());


var x = (-b2 + b1) / (-k1 + k2);
var y = k2 * x + b2;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Точка пересечения: ({x};{y})");
