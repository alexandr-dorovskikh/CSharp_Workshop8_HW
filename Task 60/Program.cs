void FillRandomValuesInArray(ref int[,,] Matrix)
{
    int X = Matrix.GetLength(0);
    int Y = Matrix.GetLength(1);
    int Z = Matrix.GetLength(2);

    int i = 0;

    int[] UsedValues = new int[X * Y * Z];

    for (int x = 0; x < X; x++)
        for (int y = 0; y < Y; y++)
            for (int z = 0; z < Z; z++)
                while (true)
                {
                    int NewValue = new Random().Next(10, 100);
                    if (Array.IndexOf(UsedValues, NewValue) == -1)
                    {
                        Matrix[x, y, z] = NewValue;
                        UsedValues[i] = NewValue;
                        i++;
                        break;
                    }
                }
}

void PrintArray(int[,,] Matrix)
{
    for (int z = 0; z < Matrix.GetLength(2); z++)
        for (int x = 0; x < Matrix.GetLength(0); x++)
            {
                for (int y = 0; y < Matrix.GetLength(1); y++)
                    Console.Write($"{Matrix[x, y, z]}({x},{y},{z}) \t");
                Console.WriteLine("");
            } 
}

int X = 2;
int Y = 2;
int Z = 2;

int[,,] Matrix = new int[X, Y, Z];
FillRandomValuesInArray(ref Matrix);
PrintArray(Matrix);
