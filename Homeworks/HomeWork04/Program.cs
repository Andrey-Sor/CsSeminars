/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int DegreeNumber(int num, int degr)
{
    int result = 1;
        
    for(int current = 1; current <= degr; current++)    
        result *= num;
    return result;

    // int current = 1;
    // while(current <= degr)
    // {
    //     result *= num;
    //     current++;
    // }
    // return result;

}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input degree number: ");
int degr = Convert.ToInt32(Console.ReadLine());

int res = DegreeNumber(num, degr);

Console.WriteLine($"Degree {degr} of number {num} is {res}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int DigitSum(int n)
{
    int result = n;
    int sum = 0;
       
    while(result >=1)
    {
        sum = sum + result % 10;
        result = result /10;
    }
    return sum;
}

Console.WriteLine("Input positive integer number");
int number = Convert.ToInt32(Console.ReadLine());

int d = DigitSum(number);

Console.WriteLine($"Sum digits of numbers from {number} is {d}");
*/


/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
m = 5 -> [1, 2, 5, 7, 19]
m = 3 -> [6, 1, 33]
*/
/*
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
Console.WriteLine("Input minimum element of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum element of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/