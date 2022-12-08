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

void SortArray(ref int[,] NumsArray)
{
    
    int m = NumsArray.GetLength(0);
    int n = NumsArray.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        int[] TempArray = new int[n];
        for (int j = 0; j < n; j++) TempArray[j] = NumsArray[i, j];
        
        Array.Sort(TempArray);
        Array.Reverse(TempArray);

        for (int j = 0; j < n; j++) NumsArray[i, j] = TempArray[j];
    }
}

int m = 3;
int n = 4;

int[,] NumsArray = new int[m, n];
FillRandomValuesInArray(ref NumsArray);

Console.WriteLine("Original array:");
PrintArray(NumsArray);

SortArray(ref NumsArray);

Console.WriteLine("Sorted array:");
PrintArray(NumsArray);
