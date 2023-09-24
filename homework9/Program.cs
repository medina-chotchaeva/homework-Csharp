
//Задача 64:Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int n)
{
    if (n >= 1) return $"{n} " + NumbersRec(n - 1);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(n));




// Задача 66:Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRec(int m, int n)
{
    if (m == n + 1 || m > n) return 0;
    else return m + SumRec(m + 1, n);
}

System.Console.WriteLine(SumRec(m, n));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Accerman(n - 1, 1);
    else
        return Accerman(n - 1, Accerman(n, m - 1));
}

System.Console.WriteLine(Accerman(n, m));
