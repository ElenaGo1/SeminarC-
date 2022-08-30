// ====Семинар 4. Урок 4.
//============================
/*
int FindSum(int a)
{
    int sum = 0;
    for (int current = 0; current <= a; current++)
     sum +=current;

return sum;
    
}

Console.Write("Input positive integer number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");
*/

//Необходимо написать написать программу, которая принмает число и возвращает количество цифр.
/*
int CharDigit(int num)
{
    int char_n = 0;
    int num1 = Math.Abs(num);
    while (num1 > 0)
    {
        if ((num1 % 10) >= 0)
        {
            num1 = num1 / 10;
            char_n++;
        }
    }
    
    return char_n;
}
Console.WriteLine("Принимает число лучше трехзначное число и выводит количество цифр");
Console.Write("Введите трехзначное сичло (100, 300):");
int numr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе равно {CharDigit(numr)}");
*/

//Найти факториал и вывести его в терминал.
/*
int Factorial(int num)
{   int n = 1;
    for (int i = 1; i <= num; i++)
    {
        n *=i;
    }

    return n;
}
Console.WriteLine("Найдем факториал введенного числа n, n!");
Console.Write("Введите число n!(5, 4):");
int numr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе равно {Factorial(numr)}");
*/
//Написать программу которая выводит массив из 8 элеиентов, заполненный нулями и единицами в случайном порядке
/*
int[] CreateArray(int n)
{
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
    {   int num = new Random().Next(0,2);
        arr[i] = num;

    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

PrintArr(CreateArray(8));
*/
//Вариант 2

int[] CreateArray(int n, int minVal, int maxVal)
{
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
    {   int num = new Random().Next(minVal,maxVal+1);
        arr[i] = num;

    }
    return arr;
}

void PrintArr(int[] arr)
{
Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
Console.WriteLine("\b\b]");
}

PrintArr(CreateArray(8, 0, 1));