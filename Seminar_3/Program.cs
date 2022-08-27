// Семинар 3. точки координат
// Необходимо написать программу, которая примет на вход  точку координат и вернет номер четверти этой плоскости.
/*
int FindQuadrant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;    
}

Console.Write("Input x coordinat: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y coordinat: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);

Console.WriteLine("Number of quadrant is {0}", quadrant);
*/

//Задача 1.
//Напишите программу, которая по заданной четверти покажет возможный диапозон координат в этой четверти.
/*
void QuarterRange(int num)
{
 if (num == 1) Console.Write($"Для четверти {num} (x > 0) а (y > 0)");
 if (num == 2) Console.Write($"Для четверти {num} (x < 0) а (y > 0)");
 if (num == 3) Console.Write($"Для четверти {num} (x < 0) а (y < 0)");
 if (num == 4) Console.Write($"Для четверти {num} (x > 0) а (y < 0)");
 if (num == 0 || num > 4) Console.Write($"Вы указали не существующий диапозон: {num} не корректно!");
}

Console.Write("Введите номер четверти (1, 2, 3 или 4): ");
int Num = Convert.ToInt32(Console.ReadLine());
QuarterRange(Num);
*/


//Задача 2. Необходимо написать программу, которая принмает на вход число N и выдает таблицу (ряд чисел) квадратов от 1 до N
/*
void SquareNumber(double num)
{ int count = 1;
    while (count <= num)
    {
        Console.Write($"n:{count} = n^2:"+Math.Pow(count, 2)+"\n");
        count++;
    }

}

Console.Write("Введит квадраты чисел от 1 до N");
Console.Write("Введите число N: ");
int Num = Convert.ToInt32(Console.ReadLine());

SquareNumber(Num);
*/
//Задача 3. Напишите программу которая принмает на вход координаты двух точек и выводит расстояние между этими точками
/*
void DistancePoints(double x1, double y1, double x2, double y2)
{
   double res = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
   Console.WriteLine($"Расстояние между точками А ({x1},{y1}) и B ({x2},{y2}) = {Math.Round(res, 2)})");
}

Console.Write("Введите координаты точек A (x1,y1) и B (x2,y2)\n");
Console.Write("Введите координаты для точки A (x1,y1)\n");
Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты для точки B (x2,y2)\n");
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

DistancePoints(x1,y1,x2,y2);
*/