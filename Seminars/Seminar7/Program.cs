// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreateRand2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Input a min possible value: ");
    //int minWalue = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Input a max possible value: ");
    // int maxWalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {   for(int j = 0; j < columns; j++)
        {
            array[i,j] = i+j;
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

int[,] myArray = CreateRand2dArray();
Show2dArray(myArray);
*/


//Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*
int[,] CrRand2dArray()
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

void ShowNewQardArray(int[,] qArray)
{
    for(int i = 0; i < qArray.GetLength(0); i+=2)
    {
        for(int j = 0; j < qArray.GetLength(1); j+=2)
        {
            qArray[i,j] *= qArray[i,j];

            // int a = qArray[i,j];
            // a = Math.Pow(a,2);
            // qArray[i,j] = a;
            Console.Write(qArray[i,j] + " ");
        }
        Console.WriteLine();
}
}

int[,] myArray = CrRand2dArray();
Show2dArray(myArray);
Console.WriteLine();
ShowNewQardArray(myArray);
*/



//Задача 3: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int SumDiagArray(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
            if(i == j)
                sum += array[i,j];
        }
    }
    return sum;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int sumDiagNum = SumDiagArray();  // надо доделать!!!!
Console.WriteLine(sumDiagNum);

