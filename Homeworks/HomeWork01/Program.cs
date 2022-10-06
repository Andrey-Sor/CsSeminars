/ HomeWork 1 of seminar 1.
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Option 1: На вход поступают числа из условия задачи");

Console.WriteLine("------------");
Console.WriteLine("Example 1:");
Console.WriteLine("First number = -9");
int a1 = -9;
Console.WriteLine("Second number = -3");
int b1 = -3;

if (a1 > b1)
{
    Console.WriteLine("Max number " + a1);
}
else
{
    Console.WriteLine("Max number " + b1);
}

Console.WriteLine("------------");
Console.WriteLine("Example 2:");
Console.WriteLine("First number = 2");
int a2 = 2;
Console.WriteLine("Second number = 10");
int b2 = 10;

if (a2 > b2)
{
    Console.WriteLine("Max number " + a2);
}
else
{
    Console.WriteLine("Max number " + b2);
}

Console.WriteLine("------------");
Console.WriteLine("Example 3:");
Console.WriteLine("First number = -9");
int a3 = -9;
Console.WriteLine("Second number = -3");
int b3 = -3;

if (a3 > b3)
{
    Console.WriteLine("Max number " + a3);
}
else
{
    Console.WriteLine("Max number " + b3);
}
*/

/*
Console.WriteLine("============");
Console.WriteLine("Option 2: На вход поступают числа от пользователя");

Console.Write("Input a first number = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Max number " + a);
}
else
{
    Console.WriteLine("Max number " + b);
}
*/



/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/

/*
Console.WriteLine("============");
Console.WriteLine("Option 1: На вход поступают числа из условия задачи"); 
Console.WriteLine("------------");
Console.WriteLine("Example 1:");
Console.Write("First number = 2, ");
int a1 = 2;
Console.Write("Second number = 3, ");
int b1 = 3;
Console.WriteLine("Third number = 7");
int c1 = 7;
int max1 = 0;

if (a1 > b1)
{
    max1 = a1;
}
else
{
    max1 = b1;
}
if (max1 > c1)
{
    Console.WriteLine("Max number = " + max1);
}
else
{
    Console.WriteLine("Max number = " + c1);
}


Console.WriteLine("------------");
Console.WriteLine("Example 2:");
Console.Write("First number = 44, ");
int a2 = 44;
Console.Write("Second number = 5, ");
int b2 = 5;
Console.WriteLine("Third number = 78");
int c2 = 78;
int max2 = 0;

if (a2 > b2)
{
    max2 = a2;
}
else
{
    max2 = b2;
}
if (max2 > c2)
{
    Console.WriteLine("Max number = " + max2);
}
else
{
    Console.WriteLine("Max number = " + c2);
}


Console.WriteLine("------------");
Console.WriteLine("Example 3:");
Console.Write("First number = 22, ");
int a3 = 22;
Console.Write("Second number = 3, ");
int b3 = 3;
Console.WriteLine("Third number = 9");
int c3 = 9;
int max3 = 0;

if (a3 > b3)
{
    max3 = a3;
}
else
{
    max3 = b3;
}
if (max3 > c3)
{
    Console.WriteLine("Max number = " + max3);
}
else
{
    Console.WriteLine("Max number = " + c3);
}
*/

/*
Console.WriteLine("============");
Console.WriteLine("Option 2: На вход поступают числа от пользователя");
Console.Write("Input a first number = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number = ");
int c = Convert.ToInt32(Console.ReadLine());

int max1 = 0;

if (a > b)
{
    max1 = a;
}
else
{
    max1 = b;
}
if (max1 > c)
{
    Console.WriteLine("Max number = " + max1);
}
else
{
    Console.WriteLine("Max number = " + c);
}
*/

/*
Console.WriteLine("============");
Console.WriteLine("Option 3: На вход поступают числа от пользователя, программа выводит максимальное и минимальное числа");
Console.Write("Input a first number = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number = ");
int c = Convert.ToInt32(Console.ReadLine());

int max1 = 0;
int min1 = 0;

if (a > b)
{
    max1 = a;
    min1 = b;
}
else
{
    max1 = b;
    min1 = a;
}
if (max1 > c)
{
    Console.WriteLine("Max number = " + max1);
}
else
{
    Console.WriteLine("Max number = " + c);
}
if (min1 < c)
{
    Console.WriteLine("Min number = " + min1);
}
else
{
    Console.WriteLine("Min number = " + c);
}
*/


/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    4 -> да
    -3 -> нет
    7 -> нет

*/

/*
Console.WriteLine("============");
Console.WriteLine("Option 1: На вход поступают числа из условия задачи"); 
Console.WriteLine("------------");
Console.WriteLine("Является ли число чётным:");
Console.Write("First number = 4, ");
int a = 4;
Console.Write("Second number = -3, ");
int b = -3;
Console.WriteLine("Third number = 7");
int c = 7;

if (a % 2 == 0)
{
    Console.WriteLine($"Yes, the first number {a} is even");
}
else
{
    Console.WriteLine($"No, the first number {a} is uneven");
}
if (b % 2 == 0)
{
    Console.WriteLine($"Yes, the second number {b} is even");
}
else
{
    Console.WriteLine($"No, the second number {b} is uneven");
}
if (c % 2 == 0)
{
    Console.WriteLine($"Yes, the third number {c} is even");
}
else
{
    Console.WriteLine($"No, the third number {c} is uneven");
}
*/


