//Семинар 2. 
//напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру из этого числа
/*
int FindBiggerDigit(int number)
{
    int ed = number % 10;
    int dec = number / 10;

    int result;
    if (ed > dec) result = ed;
    else result = dec;

    return result;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");
*/

/*
int FunctionS(int number)
{
    int first = number / 100;
    int second = number % 10;
    int result = first * 10 + second;
    return result;
}

int randomNumber = new Random().Next(100, 1000);
int result = FunctionS(randomNumber);
Console.WriteLine($"Из трехзначного числа {randomNumber} is {result}");
*/
//Напишите программу, которая принимает на вход два числа и проверяет, кратное оно или нет.
/*
void CheckNumber(int a, int b)
{
int res = b%a;
if (res == 0)
 Console.WriteLine("Второе число кратно первому");
 else 
 Console.WriteLine($"Остаток от деления второго  числа равен {res}");
}
Console.WriteLine("Программа проверки второго числа на кратность первому");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
CheckNumber(a,b);
*/
/*
bool Checknumber(int x, int a, int b)
{
    if ((x%a==0)& (x%b)==0)
    return true;
    else
    return false;
}
Console.WriteLine("Программа проверки кратности числа двум другим числам");
Console.WriteLine("Введите число для проверки: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое условие кратности: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе условие кратности: ");
int b = Convert.ToInt32(Console.ReadLine());

bool result = Checknumber(x, a, b);

if (result)
    Console.WriteLine($"Число {x} кратное числу {a} и числу {b}");
else
 Console.WriteLine($"Число {x} не кратное числу {a} и числу {b}");
*/
