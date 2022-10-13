/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

/*
int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
*/

//int FindQuart(double x, double y)

/*
int FindQuart(double x, double y)
{
    int quart = 0;

    if(x > 0 && y > 0) quart = 1;
    if(x < 0 && y > 0) quart = 2;
    if(x < 0 && y < 0) quart = 3;
    if(x > 0 && y < 0) quart = 4;
    return quart;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x},{y}) is on the {FindQuart} quart");
*/

// Задача 1: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.




// Задача 3: Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void SquareNumber(int n)
{
    int count = 1;

    while (count <= n)
    {
        Console.Write(Convert.ToInt32(Math.Pow(count,2)) + " ");
        count++;
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
SquareNumber(n);
