// Семинар 6.
// Необходимо перевернуть одномерный массив.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
     newArray[i] = new Random().Next(minValue,maxValue+1);    

    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write($"{array[i]}, ");
    Console.WriteLine("\n");
}

int[] ReverseArray(int[] array)
{
    for (int i = 0, j= array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
ShowArray(ReverseArray(newArray));
*/

//Задача семинара для выполнения.
//Задача 1. Напишите программу, которая будет преобразовывать десятиричное число в двоичное. Остатки от деления.
/*
string Converts(int a)
{
    string result = string.Empty;
    while (a != 0)
    {
        result = a % 2 + result;
        a = a / 2;
        
    }
    return result;
}

Console.Write("Введите число n:");
int num = Convert.ToInt32(Console.ReadLine());


string res = Converts(num);
Console.WriteLine(res);
*/
//Задача 2. Напишите программу Не используя рекурсию вывести ряд фибоначи, каждое последующее число форминурется из арифметической суммы двух предыдущих.
/*
int[] Fibonachi(int num_a, int num_b, int num_n)
{
    int[] arr = new int [num_n];
    arr[0] = num_a;
    arr[1] = num_b;
   for (int i = 2; i < num_n; i++)
   {
     arr[i] = arr[i-2] + arr[i-1];
   }
return arr;

}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write($"{array[i]}, ");
    Console.WriteLine("\n");
}
Console.Write("Введите первое число ряда Фибоначи a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ряда Фибоначи b:");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Сколько чисел ряда Фибоначи Вы хотите указать N:");
int N = Convert.ToInt32(Console.ReadLine());

int[] arrs = Fibonachi(a, b, N);

ShowArray(arrs);
*/

//Задача 3. Напишите программу которая примет на вход три числа и проверит, может ли существовать треугольник. 
//каждая сторона треугольника должна быть меньше суммы длин двух других сторон.
/*
void CheckingExistenceTriangle(int numA, int numB, int numC)
{
    if ((numA - numB) < numC & numC < (numA + numB))
        Console.WriteLine("С данными сторонами треугольник может существовать");
    else
        Console.Write("С данными сторонами треугольник не может существовать");
}



Console.Write("Введите длину стороны треугольника  a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны треугольника  b:");
int b = Convert.ToInt32(Console.ReadLine());
double sideLengthC = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
Console.WriteLine("\nВведите длину основания треугольника с = {0},\n"+
"чтобы треугольник существовал",Math.Round(sideLengthC,0));
Console.Write("\nВведите длину основания треугольника с:");
int c = Convert.ToInt32(Console.ReadLine());

CheckingExistenceTriangle(a, b, c);

*/
