//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.



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
            for(int j = 0; i < array.GetLength(1); j++)
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
ChangeArray(myArray);
Show2dArray(myArray);


//Задача: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


//Задача: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.



