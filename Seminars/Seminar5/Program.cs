// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("\nComplete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegatives(int[] array)
{
    int sumNeg = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sumNeg += array[i];
    }
    return sumNeg;
}

int SumOfPositives(int[] array)
{
    int sumPos = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sumPos += array[i];        
    }
    return sumPos;
}


Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int resultNeg = SumOfNegatives(myArray);
int resultPos = SumOfPositives(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negatives elements is " + resultNeg);
Console.WriteLine("Sum of a positives elements is " + resultPos);
*/

// Задача1: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]





// Задача2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.






// Задача: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].



