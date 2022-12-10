void FillHelix(ref int[,] NumsArray)
{
    int N = NumsArray.GetLength(0);
    
    for (int ik = 0; ik < NumsArray.GetLength(0); ik++)
        for (int jk = 0; jk < NumsArray.GetLength(1); jk++)
        {
            int i = ik + 1;    
            int j = jk + 1;
            
            int switcher =  (j - i + N) / N;
            int Ic = Math.Abs(i - N / 2  - 1) + (i - 1)/(N /2) * ((N-1) % 2);
            int Jc = Math.Abs(j - N / 2  - 1) + (j - 1)/(N /2) * ((N-1) % 2);
            int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = i - Ring + j - Ring - 1;    
            int Coef =  4 * Ring * (N - Ring);
            
            NumsArray[ik, jk] =  Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);
        }

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

int N = 4;

int[,] NumsArray = new int[N, N];
FillHelix(ref NumsArray);
PrintArray(NumsArray);