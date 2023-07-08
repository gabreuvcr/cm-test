namespace TestCM.Questions;

/*
    2. Implemente uma função que, dado uma matriz A e
    uma submatriz B (dimensões menores que A), esta 
    função retorne quantas vezes esta submatriz B pode
    ser encontrada na matriz A.
*/

public class Question2
{
    public static bool IsEqual(int[,] matrix, int[,] submatrix, int i, int j)
    {
         for (int k = 0; k < submatrix.GetLength(0); k++) {
            for (int w = 0; w < submatrix.GetLength(1); w++)
            {
                if (matrix[k + i, w + j] != submatrix[k, w])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static int CalculateOccurrences(int[,] matrix, int[,] submatrix)
    {
        if (submatrix.GetLength(0) > matrix.GetLength(0)
            || submatrix.GetLength(1) > matrix.GetLength(1))
        {
            throw new ArgumentException("Submatrix must be smaller than the matrix");
        }

        int occurrences = 0;
        for (int i = 0; i < matrix.GetLength(0) - submatrix.GetLength(0) + 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - submatrix.GetLength(1) + 1; j++)
            {
                if (IsEqual(matrix, submatrix, i, j))
                {
                    occurrences++;
                }

            }
        }

        return occurrences;
    }
}
