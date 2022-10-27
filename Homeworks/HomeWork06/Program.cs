/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

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
