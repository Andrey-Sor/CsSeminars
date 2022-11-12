//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minWalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxWalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {   for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minWalue, maxWalue +1);
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

void ChangeArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
    }
    else
        Console.WriteLine("It's impossible!!!");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
ChangeArray(myArray);
Show2dArray(myArray);
*/

//Задача: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minWalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxWalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {   for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minWalue, maxWalue +1);
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

void ChangeArray(int[,] array)
{
    int i = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[i,j];
        array[i,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = temp;
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
ChangeArray(myArray);
Show2dArray(myArray);
*/

//Задача: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minWalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxWalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {   for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minWalue, maxWalue +1);
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

int[,] CreateNewArray(int[,] array)
{
    int min = array[0,0];
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min)
            {    
                min = array[i,j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine("Min element: " + min);
    Console.WriteLine($"Index min element:  ({minI}, {minJ})");
    Console.WriteLine();
  
    int[,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];

        for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
            {
                if(i == minI)
                    {
                        m--;
                        continue;
                    }
                    for(int j = 0, n = 0; j < array.GetLength(1); j++, n++)
                    {
                        if(j == minJ)
                            {
                                n--;
                                continue;
                            }
                            newArray[m,n] = array[i,j];
                    }
            }
    return newArray;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int[,] newArray = CreateNewArray(myArray);
Show2dArray(newArray);
