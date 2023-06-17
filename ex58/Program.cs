//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

int rows = Prompt("Введите колличество строк массива: ");
int columns = Prompt("Введите колличество столбцов массива: ");

int[,] array = GetArray(rows, columns, 0,10);
int[,] massiv = GetArray(rows, columns,0,10);
PrintArray(array);
PrintArray(massiv);
NewArray(array, massiv);


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

void NewArray(int[,] arrayNew, int[,] newArray)
{
    int rows = arrayNew.GetLength(0);
    int columns = newArray.GetLength(1);
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int k = 0; k < arrayNew.GetLength(1); k++)
            {
                sum += arrayNew[i, k] * newArray[k, j];
            }
            result[i, j] = sum;
        }
    }

    PrintArray(result);
}


