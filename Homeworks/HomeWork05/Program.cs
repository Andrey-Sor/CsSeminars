/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    Console.WriteLine("\nCrating array: ");
    Console.WriteLine("++++++++++");
        for(int i = 0; i < size; i++)
        {
            myArray[i] = new Random().Next(minValue, maxValue);
        }
    Console.WriteLine("Complete array!");
    return myArray;
}

void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
        Console.Write(myArray[i] + " ");
    Console.WriteLine();
}

int CountEvenNumbers(int[] myArray)
{
    int count = 0;
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] % 2 == 0)
            count ++;
    }
    return count;
}

Console.Write("\n   Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("\n   Input a min element of array ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("\n   Input a max element of array ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
int result = CountEvenNumbers(myArray);

ShowArray(myArray);
//Console.WriteLine($"In array {myArray} \n {result} even elements");

Console.WriteLine($"\nCount even numbers in array is {result} \n" );
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    Console.WriteLine("\nCrating array: ");
    Console.WriteLine("++++++++++");
        for(int i = 0; i < size; i++)
        {
            myArray[i] = new Random().Next(minValue, maxValue);
        }
    Console.WriteLine("Complete array!");
    return myArray;
}

void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
        Console.Write(myArray[i] + " ");
    Console.WriteLine();
}

int SumUnevElements(int[] myArray)
{
    int sum = 0;
    for(int i = 1; i < myArray.Length; i += 2)
    {
        sum = sum + myArray[i];
    }
    return sum;
}

Console.Write("\n   Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

//Console.Write("\n   Input a min element of array ");
int minValue = 0;

//Console.Write("\n   Input a max element of array ");
int maxValue = 10;

int[] myArray = CreateRandomArray(size, minValue, maxValue);
int result = SumUnevElements(myArray);

ShowArray(myArray);
//Console.WriteLine($"In array {myArray} \n {result} even elements");

Console.WriteLine($"\nSum a numbers array uneven position is {result} \n" );
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] myArray = new double[size];
    Console.WriteLine("\nCrating array: ");
    Console.WriteLine("++++++++++");
        for(int i = 0; i < size; i++)
        {
            myArray[i] = new Random().Next(minValue, maxValue);
        }
    Console.WriteLine("Complete array!");
    return myArray;
}

void ShowArray(double[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
        Console.Write(myArray[i] + " ");
    Console.WriteLine();
}

double MinElementOfArray(double[] myArray)
{
    double minElem = myArray[0];
    for(int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] < minElem)
            minElem = myArray[i];           
    }   
    return minElem;
}

double MaxElementOfArray(double[] myArr)
{
    double maxElem = myArr[0];
    for(int i = 0; i < myArr.Length; i++)
    {
        if(myArr[i] > maxElem)
            maxElem = myArr[i];           
    }   
    return maxElem;
}

Console.Write("\n   Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("\n   Input a min element of array ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("\n   Input a max element of array ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, minValue, maxValue);
double minResult = MinElementOfArray(myArray);
double maxResult = MaxElementOfArray(myArray);

double result = MaxElementOfArray(myArray) - MinElementOfArray(myArray);

ShowArray(myArray);
//Console.WriteLine($"In array {myArray} \n {result} even elements");

Console.WriteLine($"\nDifference between maximum and minimum numbers of the array is {result} \n" );




/* Задача дополнительная: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

