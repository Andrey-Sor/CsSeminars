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

Console.WriteLine($"The point A({x},{y}) is on the {FindQuart(x,y)} quart");
*/


// Самостаятельная работа:
// Задача 1: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void FindRange (int qrt)
{
    if(qrt >= 1 && qrt <=4)
    {
        if(qrt == 1) Console.WriteLine("Quarter 1 has a range of x > 0 and y > 0");
        if(qrt == 2) Console.WriteLine("Quarter 2 has a range of x < 0 and y > 0");
        if(qrt == 3) Console.WriteLine("Quarter 3 has a range of x < 0 and y < 0");
        if(qrt == 4) Console.WriteLine("Quarter 4 has a range of x > 0 and y < 0");
    }
    else Console.WriteLine("Error input quart");
}
Console.Write("Input number quart ");
int qrt = Convert.ToInt32(Console.ReadLine());
FindRange(qrt);

*/


// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Coordinate(double x1, double y1, double x2, double y2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)),2);
    return distance;
}

Console.Write("Input coordinares point A x1= ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1= ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinares point B x2= ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2= ");
double y2 = Convert.ToDouble(Console.ReadLine());


Coordinate(x1, y1, x2, y2);

Console.WriteLine(Coordinate(x1, y1, x2, y2));
*/

// Задача 3: Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
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
*/