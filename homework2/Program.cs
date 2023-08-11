//Задание 1.Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int randomNumber = new Random().Next(100, 1000);
int num = randomNumber % 100 / 10;

Console.WriteLine(randomNumber);
Console.WriteLine(num);


// Задание 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

int randomNumber = new Random().Next(10, 1000);

Console.WriteLine(randomNumber);

if (randomNumber > 99)
{
    int num1 = randomNumber % 10;
    Console.WriteLine(num1);
}

else
{
    Console.WriteLine("третьей цифры нет");
}



// Задание 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

string numStr = Console.ReadLine();
int num = int.Parse(numStr);

if (num == 6 || num == 7)
{
    Console.WriteLine("Этот день выходной");
}

else if (num < 1 || num > 7)
{
    Console.WriteLine("Это не день недели");
}

else
{
    Console.WriteLine("Этот день не выходной");
}
