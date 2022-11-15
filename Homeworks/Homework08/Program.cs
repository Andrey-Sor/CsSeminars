// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int a = 1; a < array.GetLength(1); a++)
            {
                int tmpMax = 0;
                if(array[i,a] > array[i,a-1])
                {
                    tmpMax = array[i,a-1];
                    array[i,a-1] = array[i,a];
                    array[i,a] = tmpMax;
                }
            }
            
        }
    }    
    return array;
}

int[,] myArray = MyArray();
Show2dArray(myArray);
Console.WriteLine();
int[,] newArray = SortArray(myArray);
Show2dArray(newArray);
*/


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] MyArray()
{
    Console.Write("Input the number of rows/columns: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
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

int SearchRow(int[,] array)
{
    int minSumOfRows = 0;
    int rowsOfMinSum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumCurrent = 0;
        //int iCurrent = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumCurrent += array[i, j];
        }
        if(minSumOfRows == 0)
            minSumOfRows = sumCurrent;

        if(sumCurrent <= minSumOfRows)
        {
            minSumOfRows = sumCurrent;
            rowsOfMinSum = i;
        }
    }
    Console.WriteLine("Min sum row: " + minSumOfRows);

    return rowsOfMinSum;
}

int[,] myArray = MyArray();
Show2dArray(myArray);
Console.WriteLine();
int serchRow = SearchRow(myArray);
Console.WriteLine("Row with the min sum element: " + serchRow);

*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] MyArray()
{
    Console.Write("Input the number of rows matrix: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns matrix: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input a min possible value: ");
    int minValue = 1; //Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input a max possible value: ");
    int maxValue = 9; //Convert.ToInt32(Console.ReadLine());

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

int[,] ProductOfArray(int[,] arrayOne, int[,] arraySecond)
{
    // int rows = arrayOne.GetLength(0);
    // int columns = arraySecond.GetLength(1);

    if(arrayOne.GetLength(0) != arraySecond.GetLength(1))
    {
        return null;
    }

    int[,] arrayNew = new int[arrayOne.GetLength(0), arraySecond.GetLength(1)];
    for(int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for(int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for(int k = 0; k < arraySecond.GetLength(0); k++)
                arrayNew[i,j] += arrayOne[i,k] * arraySecond[k,j];
                //Console.WriteLine(arrayNew[i,j]);
        }
    }
    return arrayNew;    
    
}


Console.WriteLine("Creat first matrix: ");
int[,] myArrayOne = MyArray();
Console.WriteLine("Creat second matrix: ");
int[,] myArraySecond = MyArray();
Console.WriteLine("First matrix: ");
Show2dArray(myArrayOne);
Console.WriteLine("Second matrix: ");
Show2dArray(myArraySecond);
int[,] productOfArray = ProductOfArray(myArrayOne, myArraySecond);
if(productOfArray == null)
    Console.WriteLine("These arrays cannot be multiplied!!!");
else
{
    Console.WriteLine($"The resulting array: ");
    Show2dArray(productOfArray);
}

*/



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] MyArray()
{
    // bool FindElement(int[,,] arr, int findElement)
    // {
    //     bool result;
    //     for(int i = 0; i < arr.GetLength(0); i++)
    //         {
    //             for(int j = 0; j < arr.GetLength(1); j++)
    //             {
    //                 for(int k = 0; k < arr.GetLength(2); k++)
    //                 {
    //                     if(findElement != arr[i,j,k])
    //                         result = true;
    //                     else
    //                         result = false;
    //                      return result;
    //                 }
    //             }
    //         }
       
    // }

   

    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of layer: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[rows, columns, layers];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < layers; k++)
            {
                int tmp = new Random().Next(minValue, maxValue + 1);              
                // if(tmp == bool FindElement(array, tmp))
                // {

                // }
            }
        }
    }
    return array;
}


void Show3dArray(int[,,] array)
{   
    for(int k = 0; k < array.GetLength(2); k++)
    {        
        Console.WriteLine($"Layer {k+1}");
        for(int i = 0; i < array.GetLength(0); i++)
        {            
            for(int j = 0; j < array.GetLength(1); j++)
            {                            
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }  
        Console.WriteLine();
        }
    Console.WriteLine();
    }    
}

int[,,] myArray = MyArray();
Console.WriteLine();
Console.WriteLine("The resulting 3D-array:\n");
Show3dArray(myArray);
Console.WriteLine();





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07








