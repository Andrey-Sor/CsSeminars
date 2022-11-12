// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
int[,] MyArray()
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }    
}

int[,] myArray = MyArray();
Show2dArray(myArray);
*/





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

/*
int[,] Create2dArray()
{
    int rows = new Random().Next(4,10);
    Console.WriteLine("\nRows: " + rows);
    int columns = new Random().Next(4,10);
    Console.WriteLine("Columns: " + columns);
    int minValueNum = 0;                                //new Random().Next(0,10);
    Console.WriteLine("MIN element "  + minValueNum);
    int maxValueNum = 10;                               //new Random().Next(minValueNum + 1,10 + minValueNum);
    Console.WriteLine("MAX element: " + maxValueNum);
    Console.WriteLine();
    
    int[,] array2d = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array2d[i,j] = new Random().Next(minValueNum,maxValueNum);
        }
    }
    return array2d;
}


void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

void GetElement(int[,] array2d)
{
    Console.WriteLine("Input the number element of row: ");
    int indexRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the number element of column: ");
    int indexColumn = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    if(indexRow <= array2d.GetLength(0) && indexColumn <= array2d.GetLength(1))
    {   
        int number = 0;
        for(int i = 0; i < indexRow; i++)
        {
            for(int j = 0; j < indexColumn; j++)
            {
                number = array2d[i,j];
            }
        }
    Console.WriteLine("You requested number: " +  number);
    Console.WriteLine();
    }
    else
        Console.WriteLine("There are no numbers with such indexes in the array\n");
}

void NextFindNumber(int[,] array2d)
{
    Console.WriteLine("Search for more (input '1' for YES or input any number for end programm):  ");
    int findMore = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Rows: " + array2d.GetLength(0));
    Console.WriteLine("Columns: " + array2d.GetLength(1));
    Show2dArray(array2d);
        while(findMore == 1)
        {
            GetElement(array2d);
            Console.WriteLine();
            Console.WriteLine("Search for more (input '1' for YES or input any number for end programm):  ");
            findMore = Convert.ToInt32(Console.ReadLine());
            if(findMore == 1)
            {
                Console.WriteLine("/nRows: " + array2d.GetLength(0));
                Console.WriteLine("Columns: " + array2d.GetLength(1));
                Show2dArray(array2d);
            }
        }
    Console.WriteLine("\nEnd programm!\n");        
        
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
GetElement(myArray);
NextFindNumber(myArray);
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] Create2dArray()
{
    int rows = new Random().Next(4,10);
    Console.WriteLine("\nRows: " + rows);
    int columns = new Random().Next(4,10);
    Console.WriteLine("Columns: " + columns);
    int minValueNum = 0;                               
    Console.WriteLine("MIN element "  + minValueNum);
    int maxValueNum = 10;                              
    Console.WriteLine("MAX element: " + maxValueNum);
    Console.WriteLine();
    
    int[,] array2d = new int[rows,columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array2d[i,j] = new Random().Next(minValueNum,maxValueNum);
        }
    }
    return array2d;
}


void Show2dArray(int[,] array2d)
{
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array2d)
{
    
    for(int j = 0; j < array2d.GetLength(1); j++)
    {
        int count = 0;
        double sum = 0;
        for(int i = 0; i < array2d.GetLength(0); i++)
        {
            sum += array2d[i,j];
            count++;
        }
        Console.Write($"Sum columns =  {sum}, ");
        Console.WriteLine("arithmetic mean = " + Math.Round(sum/count, 1));
    }
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
ArithmeticMean(myArray);
*/