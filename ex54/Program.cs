//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

int rows = Prompt("Введите колличество строк массива: ");
int columns = Prompt("Введите колличество столбцов массива: ");

int[,] array = GetArray(rows, columns, 0,10);
PrintArray(array);
NewArray(array);


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

void NewArray(int[,] arrayNew)
{
    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        int[] tempArray = new int[arrayNew.GetLength(1)];
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            tempArray[j] = arrayNew[i, j];
        }
        Array.Sort(tempArray);
        Array.Reverse(tempArray);
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            arrayNew[i, j] = tempArray[j];
        }
    }
    Console.WriteLine("Упорядоченный массив:");
    PrintArray(arrayNew);
}


