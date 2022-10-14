/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


bool Palindrom(int number);
{
    bool result;

    int a5 = number % 10;
    int a4 = number % 100 / 10;
    int a2 = number / 1000 % 10;
    int a1 = number / 10000;
    
    if(a1 == a5 && a2 == a4)
        result = true;
    else
        result = false;

    return result;

}

Console.WriteLine("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
bool palindr = Palindrom(number);

if(palindr == true)
    Console.WriteLine($"Number {number} is palindrom");
else
    Console.WriteLine($"Number {number} is NOT palindrom");



/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double Coordinate(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)),2);
    return distance;
}

Console.Write("Input coordinares point A x1= ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1= ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1= ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinares point B x2= ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2= ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2= ");
double z2 = Convert.ToInt32(Console.ReadLine());

Coordinate(x1, y1, z1, x2, y2, z2);

Console.WriteLine(Coordinate(x1, y1, z1, x2, y2, z2));
*/


/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void SquareNumber(int n)
{
    int count = 1;

    while (count <= n)
    {
        Console.Write(Convert.ToInt32(Math.Pow(count,3)) + " ");
        count++;
    }
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
SquareNumber(n);
*/