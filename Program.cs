// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray() // Генерация двумерного массива
{
    int m = new Random().Next();
    int n = new Random().Next();
    int[,] result = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int column = 0; column < n; column++)
        {
            result[row, column] = new Random().Next();
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < inArray.GetLength(1); colunm++)
        {
            Console.Write($"{inArray[row, colunm]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplayMatrix(int[,] matrix, int[,] inMatrix)
{
    int[,] resultMatrix = new int[matrix.GetLength(0), inMatrix.GetLength(1)];
    for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int column = 0; column < inMatrix.GetLength(1); column++)
        {   
            for(int oneRow = 0; oneRow < inMatrix.GetLength(0); oneRow++)
            {
                resultMatrix[row, oneRow] = matrix[row, oneRow] * inMatrix[oneRow, column];
            }
        }
    } 
    return resultMatrix;
}

void Main()
{
    Console.Clear();
    int[,] ourMatrix = GetArray();
    int[,] doubleMatrix = GetArray();
    if(ourMatrix.GetLength(0) != doubleMatrix.GetLength(1))
    { 
        System.Console.WriteLine("Невозможно перемножить данные матрицы");
    }
    else
    {
        PrintArray(ourMatrix);
        Console.WriteLine();
        PrintArray(doubleMatrix);
        int[,] resultMatrix = MultiplayMatrix(ourMatrix, doubleMatrix);
        System.Console.WriteLine();
        PrintArray(resultMatrix);
    }
}

Main();