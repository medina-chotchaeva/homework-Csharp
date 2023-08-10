//Задание 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{

    Console.WriteLine("Первое число больше, а второе меньше");
}
if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine("Второе число больше, а первое меньше ");
}


// Задание 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("Максимальное число: ");
Console.WriteLine(max);


//Задание 3. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}


// Задание 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int lenght1 = int.Parse(Console.ReadLine());


for (int num = 1; num <= lenght1; num++)
    if (num % 2 == 0)
        Console.WriteLine(num);

