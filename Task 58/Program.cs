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

int[,] MatrixMultiplication(int[,] Matrix1, int[,] Matrix2)
{
    int M = Matrix1.GetLength(0);
    int K = Matrix1.GetLength(1);
    int N = Matrix2.GetLength(1);
    

    int[,] Result = new int[M, N];

    for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
        {    
            Result[i, j] = 0;

            for (int p = 0; p < K; p++)
                Result[i, j] += Matrix1[i, p] * Matrix2[p, j];
        }
    
    return Result;
}

int M = 2;
int K = 3;
int N = 4;

Console.WriteLine("");
Console.WriteLine("First matrix");

int[,] Matrix1 = new int[M, K];
FillRandomValuesInArray(ref Matrix1);
PrintArray(Matrix1);

Console.WriteLine("");
Console.WriteLine("Second matrix");

int[,] Matrix2 = new int[K, N];
FillRandomValuesInArray(ref Matrix2);
PrintArray(Matrix2);

int[,] MultiplicatedMatrix = MatrixMultiplication(Matrix1, Matrix2);

Console.WriteLine("");
Console.WriteLine("Multiplicated matrix");
PrintArray(MultiplicatedMatrix);