//Семинар 5.
//Задача вводная: Необходиом задать массив из двенадцати элементов и заполнить случайными числами от -9 до 9 найти сумму отрицательным элементов массива.
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

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0) sum += array[i];
    return sum;          
    
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

Console.WriteLine($"Sum of negative elements is {FindNegativeSum(newArray)}");
*/

//Задача 1. - Написать программу для замены эллементов массива, положительный элемент заменить соответсвующим отрицательным, а отрицательный положительным
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

int[] ChangeNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      array[i] = array[i]*(-1);
    
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
ShowArray(ChangeNum(newArray));
*/
//Задача 2. - Необходимо задать массив и написать программу, которая определяет присутсвует ли заданное число в массиве. bool true or false
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

bool Checknumber(int array_num, int find_num)
{
      if (array_num == find_num)
         return true;
      else
        return false;
            
}

bool FindNumArray(int[] array, int find_num)
{    
     for (int i = 0; i < array.Length; i++)
     {
        if (array[i] == find_num) return true;        
                       
    }
    return false;    
}

 
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input find number in array: ");
int findnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] newArray = CreateRandomArray(size, min, max);
newArray[2] = 15;
ShowArray(newArray);
if (FindNumArray(newArray, findnum))
Console.WriteLine($"В массиве заданное число {findnum} есть = {FindNumArray(newArray, findnum)}");
else
Console.WriteLine($"В массиве заданное число {findnum} нету = {FindNumArray(newArray, findnum)}");
*/
//Задача 3. - Задать одномерный массив из 15 чисел и найти колличество чисел значение которых лежат в отрезке от 10 до 99.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
     newArray[i] = new Random().Next(minValue,maxValue+1);    

    return newArray;
}
int CheckQuantityNumber(int[] array, int minV, int maxV)
{  int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if (array[i] > minV-1 && array[i] < maxV+1) quantity ++;    
    }
        
    return quantity;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write($"{array[i]}, ");
    Console.WriteLine("\n");
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Let's set the numbers of the search scale from min to max\n"+
"from 10 to 99, or other numbers from 100 to 1000");
Console.Write("Input min value: ");
int minV= Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int maxV = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateRandomArray(size, min, max);
Array[1] = 10;
Array[3] = 99;
ShowArray(Array);
Console.WriteLine($"Количство чисел в массиве от {minV} до {maxV} включительно = {CheckQuantityNumber(Array, minV, maxV)}");
*/
//Задача 4. - Необходимо найти произвендение чисел пар элементов массива, парой считаем первый и последний элемент второй в 
//предпоследний и результат записать в новый массив.
/*<
//=== 1.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
     newArray[i] = new Random().Next(minValue,maxValue+1);    

    return newArray;
}
//==== 2.
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write($"{array[i]}, ");
    Console.WriteLine("\n");
}
//==== 3.
//Вариант 1.

int[] MultiplyingArrayOut(int[] array){
    int size_a = array.Length;
    int size_b = array.Length;
    int size_new = (size_a/2)+(size_a%2);
    int[] arrnew = new int [size_new];
    for (int i = 0; i < size_a; i++)
    { size_a -=1;
      int a = array[i], b = array[size_a];
      arrnew[i] = a*b;          
    }
    return arrnew;
}

//Вариант 2.
/*
int[] MultiplyingArrayOut(int[] array){
    int size_a = array.Length;
    int size_new = (size_a/2)+(size_a%2);
    int[] arrnew = new int [size_new];
    for (int i = 0; i < size_new; i++)
    { 
      int a = array[i], b = array[size_a - i - 1];
      arrnew[i] = a*b;          
    }
    return arrnew;
}
*/
/*<
//==== 4. input 
Console.WriteLine("Let's set the size of the array and generate numbers for example from 2 to 30\n");
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

//==== 4. Generation
int[] arrchik = CreateRandomArray(size, min, max);
//==== 5. Output to
ShowArray(arrchik);
//==== 5. Output and Multiplying
ShowArray(MultiplyingArrayOut(arrchik));
>*/
