namespace TestCM.Questions;
/*
    1. Implemente uma função que inverta as diagonais 
    de uma matriz quadrada.
*/

public class Question1
{
    public static void Swap(ref int d1, ref int d2)
    {
        (d1, d2) = (d2, d1);
    }

    /// <exception cref="ArgumentException">The matrix must be square.</exception>
    public static void InvertMatrixDiagonal(int[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1)) {
            throw new ArgumentException("The matrix must be square");
        }

        int n = matrix.GetLength(0) - 1;
        for (int i = 0; i <= n; i++) {
            Swap(ref matrix[i, i], ref matrix[i, n - i]);
        }
    }
}
