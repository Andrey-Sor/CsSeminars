/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    456 -> 5
    782 -> 8
    918 -> 1
*/

/*
Console.WriteLine("============");

int SecondDigitNumber(int num)

{    
    int secNum = num % 100 / 10;

    return secNum;
}

int threeDigitNumber = new Random().Next(100,1000);
int secDigNum = SecondDigitNumber(threeDigitNumber);

Console.WriteLine($"Second digit from the number {threeDigitNumber} this is {secDigNum}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6
*/

/*
int TreeDiditNumber(int num)
{
    int result;
    while (num >= 1000)
    {
        num = num / 10;
    }
    result = num % 10;
    return result;

}

int resultNum = 0;
//int inNum = new Random().Next(1, 100000);         //При использовании случайных чисел закомментировать следующие две строки!
Console.Write("Input number from 1 to 100 000 = ");
int inNum = Convert.ToInt32(Console.ReadLine());

if(inNum < 100)
Console.WriteLine($"In the number {inNum} no thrid digit");
else
{
if(inNum >= 1000)
    resultNum = TreeDiditNumber(inNum);
else
    if(inNum >= 100 && inNum < 1000)
        resultNum = inNum % 10;
Console.WriteLine($"Third digit of the number {inNum} this is {resultNum}");
}
/*


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    6 -> да
    7 -> да
    1 -> нет
*/

/*
bool Weekend(int inNum)
{
    bool result;

    if(inNum == 6 || inNum == 7)
        result = true;
    else
        result = false;

    return result;
}

Console.Write("Enter the dey of the week ");
int inNum = Convert.ToInt32(Console.ReadLine());
//int inNum = new Random().Next(1, 8);
bool res = Weekend(inNum);
if(inNum >= 1 && inNum <=7)
{
    if(res == true)
        Console.WriteLine($"{inNum} dey week - Yes, is weekend");
    else
        Console.WriteLine($"{inNum} dey week - No, is not weekend");
}
else
    Console.WriteLine("Dey input error!!!");

*/