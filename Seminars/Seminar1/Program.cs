/*

// Задача 1. Текст задачи.

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int quad2 = b*b;

if (a==quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*

// Задача 2.

Console.Write("Input a number = ");
int number=Convert.ToInt32(Console.ReadLine());

int current=-number;

if(number>0)
{
    current=-number;
}
else
{
    current=number;
    number*=-1;
}

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}

*/

/*
// Выделение цифр из числа:

253 % 10 -> 3
253 % 100 -> 53
253 % 1000 -> 253

253 / 10 -> 25
253 / 100 -> 2
253 / 1000 -> 0

4827 % 1000 /10 ->82
4827 / 10 % 100 ->82

*/

/*

// Задача 3

Console.Write("Input a three-digit number = ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >=100 && number < 1000)
{
    int lastDigit = number % 10;
    Console.Write($"Last digit of {number} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrent input!");
}

*/