/*
//Задача 1. Текст задачи.
Console.Write("Input integer number:");

int number = Convert.ToInt32(Console.ReadLine()); 

int kvadrat = number * number;

Console.WriteLine($"Квадрат числа {number} это {kvadrat}");
*/
/*
//Задача 2. Напишите программу, которая на вход принмает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input fisrt integer number:");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input second integer number:");
int num2 = Convert.ToInt32(Console.ReadLine()); 

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}
else
{
    Console.WriteLine($"{num1} не является квадратом {num2}");
}
*/

/*
//Задача 3. Напишите программу, которая на вход принмает число (N), а на выходе выводит все целые числа от -N до N

Console.Write("Input positive integer number:");
int num = Convert.ToInt32(Console.ReadLine());
int current = num * (-1);

while (current <= num)
{
    Console.Write(current +" ");
    current++;
}
*/

//Задача 4. Напишите программу, которая на вход принимает трехзначное число, а на выходе выводит последнее число цифры.

Console.Write("Input three-digit integer number:");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;

Console.Write($"last digit of {num} is {result}");
