//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1)
        ShowNums(n - 1);
}

Console.Write("Input any natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowNums(number);
*/



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int ShowNums(int m, int n)
{
    
    if(m < n)
        return m + ShowNums(m + 1, n);
    if(m > n)
        return m + ShowNums(m - 1, n);
    else return m; 
}

Console.Write("Input a first value: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second value: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int sumNums = ShowNums(m, n);
Console.WriteLine("Sum numbers this range " + sumNums);

*/




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int FunctionAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return FunctionAkkerman(m - 1, 1);
    if (m > 0 && n > 0) 
        return FunctionAkkerman(m - 1, FunctionAkkerman(m,n - 1));
    return FunctionAkkerman(m,n); 
}                  

Console.Write("Input a first positive number 'm': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second positive number 'n': ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int funcAkkerman = FunctionAkkerman(m, n);
Console.WriteLine($"If m = {m} and n = {n} -> A(m, n) = {funcAkkerman}");
*/