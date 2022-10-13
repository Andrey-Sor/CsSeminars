/*

int FindBiggestDigit(int num)

{
    int max;
       
    int ed = num % 10;
    int dec = num / 10;

    if(ed >dec)
        max = ed;
    else
        max = dec;
    
    return max;
}

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");

*/


/*
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int TwoDigitNumber(int num)

{    
    int hun = num / 100;
    int ed = num % 10;

    int twoNumber = hun * 10 + ed;
    return twoNumber;
}

int threeDigitNumber = new Random().Next(100,1000);
int twoDigitNumber = TwoDigitNumber(threeDigitNumber);

Console.WriteLine($"Removing the middle digit from the number {threeDigitNumber} - {twoDigitNumber}");

*/

// Напишите программу, которая принимает на вход число N и проверяет, кратно ли оно одновременно a и b, a и b - инфо от пользователя(тоже int)

// код пока не работает!

bool Multiples(int number, int a, int b);
{
    bool result;

    if(number % a == 0 && number % b == 0)
        result = true;
    else
        result = false;

    return result;

}


// int number = new Random().Next(10, 100);
// Console.Write("Number = " + number);

Console.Write("Input number, N = ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input first devider, a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second devider, b = ");
int b = Convert.ToInt32(Console.ReadLine());

bool res = Multiples(number, a, b);
Console.WriteLine(res);