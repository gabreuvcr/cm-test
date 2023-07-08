namespace QuestionsTest;

using Xunit;

using TestCM.Questions;

public class Question1Test
{
    [Fact]
    public void InvertDiagonalOf_3x3_SquareMatrix()
    {
        int[,] matrix_3 = new int[,] {
            {3, 2, 1},
            {5, 2, 2},
            {4, 6, 8}
        };

        int[,] expected_matrix = new int[,] {
            {1, 2, 3},
            {5 ,2, 2},
            {8, 6, 4}
        };

        Question1.InvertMatrixDiagonal(matrix_3);

        Assert.Equal(expected_matrix, matrix_3);
    }

    [Fact]
    public void InvertDiagonalOf_4x4_SquareMatrix()
    {

        int[,] matrix_4 = new int[,] {
            {3, 2, 1, 8},
            {5, 2, 2, 2},
            {4, 6, 8, 4},
            {6, 3, 2, 6},
        };

        int[,] expected_matrix = new int[,] {
            {8, 2, 1, 3},
            {5, 2, 2, 2},
            {4, 8, 6, 4},
            {6, 3, 2, 6},
        };

        Question1.InvertMatrixDiagonal(matrix_4);

        Assert.Equal(expected_matrix, matrix_4);
    }

    
    [Fact]
    public void InvertDiagonalOf_5x5_SquareMatrix()
    {

        int[,] matrix_5 = new int[,] {
            { 1,  2,  3,  4,  5},
            { 6,  7,  8,  9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25},
        };

        int[,] expected_matrix = new int[,] {
            { 5,  2,  3,  4,  1},
            { 6,  9,  8,  7, 10},
            {11, 12, 13, 14, 15},
            {16, 19, 18, 17, 20},
            {25, 22, 23, 24, 21},
        };

        Question1.InvertMatrixDiagonal(matrix_5);

        Assert.Equal(expected_matrix, matrix_5);
    }

    [Fact]
    public void InvertDiagonalOf_2x3_ThrowsException()
    {
        int[,] matrix_3 = new int[,] {
            {3, 2, 1},
            {5, 2, 2},
        }; 

        Action action = () => Question1.InvertMatrixDiagonal(matrix_3);
        
        var exception = Record.Exception(action);

        Assert.NotNull(exception);
        Assert.IsType<ArgumentException>(exception);
    }
}
