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
        TempArray = QuickSort(TempArray, 0, n - 1);
        for (int j = 0; j < n; j++) NumsArray[i, j] = TempArray[j];
    }
}

int[] QuickSort(int[] NumsArray, int i, int j)
{
    if (i < j)
    {
        int q = Partition(NumsArray, i, j);
        NumsArray = QuickSort(NumsArray, i, q);
        NumsArray = QuickSort(NumsArray, q + 1, j);
    }
    return NumsArray;
}

int Partition(int[] NumsArray, int p, int r)
{
    int x = NumsArray[p];
    int i = p - 1;
    int j = r + 1;
    while (true)
    {
        do
        {
            j--;
        }
        while (NumsArray[j] > x);
        do
        {
            i++;
        }
        while (NumsArray[i] < x);
        if (i < j)
        {
            int tmp = NumsArray[i];
            NumsArray[i] = NumsArray[j];
            NumsArray[j] = tmp;
        }
        else
        {
            return j;
        }
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
