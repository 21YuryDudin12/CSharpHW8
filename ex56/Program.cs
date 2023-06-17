//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить 
//строку с наименьшей суммой элементов.

int rows = Prompt("Введите колличество строк массива: ");
int columns = Prompt("Введите колличество столбцов массива: ");

int[,] array = GetArray(rows, columns, 0,10);
PrintArray(array);
FindMinSumRow(array);


int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            result[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return result;

}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinSumRow(int[,] array)
{
    int minSum = int.MaxValue; 
    int minSumRowIndex = -1; 
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0; 
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j]; 
        }
        
        if (rowSum < minSum)
        {
            minSum = rowSum; 
            minSumRowIndex = i+1; 
        }
    }
    
    if (minSumRowIndex != -1)
    {
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");
        Console.WriteLine("Сумма элементов этой строки равна: " + minSum);
    }
    else
    {
        Console.WriteLine("Массив пуст.");
    }
}
