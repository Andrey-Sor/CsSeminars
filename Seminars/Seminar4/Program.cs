// Задача1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum(int a)
{
    int sum = 0;
    
    for(int current = 1; current <= a; current++)    
        sum += current;
    return sum;
}

Console.WriteLine("Input positive integer number");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of numbers from 1 to  {num} is {s}");
*/

// Задача: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int DigitNumber(int n)
{
    int count = 1;

    for(int div = n; div >= 10; count++)
        div = div / 10;

    return count;
}

Console.WriteLine("Input positive integer number");
int num = Convert.ToInt32(Console.ReadLine());

int d = DigitNumber(num);

Console.WriteLine($"Quantity of numbers from {num} is {d}");



// Задача: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*
int GetMult(int a)
{
    int mult = 1;
    
    for(int current = 1; current <= a; current++)    
        mult *= current;
    return mult;
}

Console.WriteLine("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int m = GetMult(num);

Console.WriteLine($"Multiplication of numbers from 1 to  {num} is {m}");
*/

// Задача 4: Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

// метод генерации массива:

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
Console.WriteLine("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 9;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);