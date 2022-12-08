void FillRandomValuesInArray(ref int[,] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            NumsArray[i, j] = new Random().Next(0, 10);


}

void PrintArray(int[,] NumsArray)
{
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            Console.Write($"{NumsArray[i, j]} \t");

        Console.WriteLine("");
    }
}

int LineWithMinSum(int[,] NumsArray)
{
    int? MinSum = null;
    int Result = 0;
    for (int i = 0; i < NumsArray.GetLength(0); i++)
    {    
        int LineSum = 0;
        
        for (int j = 0; j < NumsArray.GetLength(1); j++)
            LineSum += NumsArray[i, j];
        
        if (MinSum == null || LineSum < MinSum) 
        {
            MinSum = LineSum;
            Result = i + 1;
        };
    }

    return Result;        
}

int m = 5;
int n = 5;

int[,] NumsArray = new int[m, n];
FillRandomValuesInArray(ref NumsArray);
PrintArray(NumsArray);

Console.WriteLine($"Line with min sum: {LineWithMinSum(NumsArray)}");