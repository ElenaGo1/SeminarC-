//Семинар 7 
//Рассмотрено преподователем

int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue +1);
    
    return newArray;        
}

void Show2dArray(int[,] array)
{   Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j]+ " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//===============================================
//Задача 1. Задайте двумерный массив размера m на п, каждый элемент в массиве находится по формуле: A [i,j] = i+j. Выведите полученный массив на экран.

/*
int[,] Create2dArrayNum()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
        
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = i+j;
    
    return newArray;        
}

int[,] newArray = Create2dArrayNum();
Show2dArray(newArray);
*/

//=============================
//Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateRandom2dArr()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue +1);
    
    return newArray;        
}
/*
int[,] ChangeOddPosPowSquaredNum(int[,] arrays)
{
    for (int i = 0; i < arrays.GetLength(0); i += 2)
        for (int j = 0; j < arrays.GetLength(1); j += 2)
            arrays[i, j] = Convert.ToInt32(Math.Pow(Convert.ToDouble(arrays[i, j]), 2));

    return arrays;
}

int[,] newArrays = CreateRandom2dArr();
Show2dArray(newArrays);
int[,] afterChange = ChangeOddPosPowSquaredNum(newArrays);
Show2dArray(afterChange);
*/

//Задача 3. Найти сумму чисел на главной диагонали матрицы. от верхнего павого угла до правого нижнего.

int SumMainDiagonalMatrices(int[,] matricesArr)
{
    int sum = 0;
    for (int i = 0; i < Math.Min(matricesArr.GetLength(0),matricesArr.GetLength(1)); i++)
        sum += matricesArr[i, i];
return sum;
}

int[,] matrices = CreateRandom2dArr();
Show2dArray(matrices);
int sumMatricesMainDiag = SumMainDiagonalMatrices(matrices);
Console.WriteLine("Sum main diagonal matrices = {0}", sumMatricesMainDiag);

