// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 1. Сгенерировать массивы;
// 2. Перемножить каждый элемент первой строки массива 1
//    с первым элементом колонки 1 массива 2;
// 3. Записать результат в результирующий массив;
// 4. Вывести результурующий массив;

int[,] GetArray(int m, int n, int minValue, int maxValue) // Генерация двумерного массива
{
    int[,] result = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int column = 0; column < n; column++)
        {
            result[row, column] = new Random().Next(minValue, maxValue);
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
                resultMatrix[row, column] += matrix[row, oneRow] * inMatrix[oneRow, column];
            }
        }
    } 
    return resultMatrix;
}

void Main()
{
    
    int[,] ourMatrix = GetArray(3, 4, 0, 10);
    int[,] doubleMatrix = GetArray(4, 3, 0, 10);
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