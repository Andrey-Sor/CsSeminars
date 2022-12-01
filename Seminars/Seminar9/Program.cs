// Задача: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/*
void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);
    Console.Write(n + " ");
}
ShowNums(5);
*/

// Задача: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(SumOfDigits(5736));
