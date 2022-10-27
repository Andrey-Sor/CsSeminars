/*
Задача № 1
Необходимо написать консольную программу, где пользователь будет вводить с клавиатуры 2 числа. Числа будут сравниваться с последующим выводом в консоль
результата этого сравнения (равны ли значения, а если нет, то какое число больше/меньше).
*/

/*
void CompaireNumbers(int a, int b)
{
    if(a == b)
    {
        Console.WriteLine($"Numder {a} = {b}");
    }
    else
    {
        if(a > b)
            Console.WriteLine($"Number {a} > {b}");
        else
            Console.WriteLine($"Number {a} < {b}");
    }
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
CompaireNumbers(a, b);
*/

/*
Пусть пользователь имеет возможность ввести одно число, причем:
— когда значение больше пяти и одновременно с этим меньше десяти, выводится один текст с соответствующим сообщением;
—  когда значение не попадает в указанный диапазон, программа его не узнает, выводя другой текст с соответствующим сообщением. Таким образом, алгоритм решения будет несколько отличаться:
*/
/*
void Recognize(int num)
{
    if(num > 5 && num < 10)
        Console.WriteLine("This number is right!");
    else
        Console.WriteLine("This number is not right");

}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Recognize(num);
*/
