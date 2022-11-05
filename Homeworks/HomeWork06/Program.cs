/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

//Метод с использованием массива:
/* 
int[] CreatArray()
{
    Console.Write("How many numbers do you want to enter? - ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i+1} number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindPositiveNumbers(int[] userArray)
{
    int count = 0;
    for(int i = 0; i < userArray.Length; i++)
    {
        if(userArray[i] > 0)
            count++;
    }
    return count;
}

int[] userArray = CreatArray();
Console.Write("\nYour numbers: ");
ShowArray(userArray);

int findPositiveNum = FindPositiveNumbers(userArray);
Console.WriteLine($"\nQuantity of positive numbers : {findPositiveNum}\n");
*/

//Метод без использования массива:
/*
int ScorePositiveNumbers(int quantity)
{
    int count = 0;
    int i = 1;
    while(i <= quantity)
        {
            Console.Write($"Input a {i} number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
                count ++;
        i++;
        }
    return count;    
}

Console.Write("How many numbers do you want to enter? - ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int scorePositiveNumbers = ScorePositiveNumbers(quantity);
Console.WriteLine($"\nQuantity of positive numbers : {scorePositiveNumbers}\n");
*/





/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
void Calculation()
{
    Console.WriteLine("\nThere is an two equation of the line: y = k1 * x + b1 and y = k2 * x + b2");
    Console.WriteLine("\nInput numbers k1 and b1 for first equation of a straight line: ");
    Console.Write("k1 = ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 = ");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("\nInput numbers k2 and b2 for second equation of a straight line: ");
    Console.Write("k2 = ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if(k1==k2) 
    {
        Console.WriteLine("\nStraight line parallel");
    }
    else
        if(b1==b2)
        {
            Console.WriteLine("\nStraight line match");
        }
        else

        {
            double x = (b2-b1)/(k1-k2);
            double y = k1 * x + b1;
        
            Console.WriteLine("\nCoordinates intersection point" + (x, y));
        }
}

Calculation();
Console.WriteLine();
*/

