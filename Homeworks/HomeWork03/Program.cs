




/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


void SquareNumber(int n)
{
    int count = 1;

    while (count <= n)
    {
        Console.Write(Convert.ToInt32(Math.Pow(count,3)) + " ");
        count++;
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
SquareNumber(n);
