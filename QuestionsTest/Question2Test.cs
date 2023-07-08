namespace QuestionsTest;

using Xunit;

using TestCM.Questions;

public class Question2Test
{
    [Fact]
    public void CalculateOccurrences_Matrix3x3_ReturnsAllOccurrences()
    {
        int[,] matrix = new int[,] {
            {3, 2, 1},
            {5, 2, 2},
            {4, 6, 8}
        };
        int[,] submatrix = new int[,] {
            {2, 2},
            {6, 8}
        };

        int occurrences = Question2.CalculateOccurrences(matrix, submatrix);

        Assert.Equal(1, occurrences);
    }

        [Fact]
    public void CalculateOccurrences_Matrix3x3_ReturnsZeroOccurrences()
    {
        int[,] matrix = new int[,] {
            {3, 2, 1},
            {5, 2, 2},
            {4, 6, 8}
        };
        int[,] submatrix = new int[,] {
            {1, 1},
            {1, 1}
        };

        int occurrences = Question2.CalculateOccurrences(matrix, submatrix);

        Assert.Equal(0, occurrences);
    }

    [Fact]
    public void CalculateOccurrences_Matrix4x4_ReturnsAllOccurrences()
    {
        int[,] matrix = new int[,] {
            {3, 2, 1, 8},
            {5, 2, 2, 1},
            {1, 8, 8, 2},
            {2, 1, 8, 2}
        };
        int[,] submatrix = new int[,] {
            {1, 8},
            {2, 1}
        };

        int occurrences = Question2.CalculateOccurrences(matrix, submatrix);

        Assert.Equal(2, occurrences);
    }

    
    [Fact]
    public void CalculateOccurrences_Matrix3x4_ReturnsAllOccurrences()
    {
        int[,] matrix = new int[,] {
            {1, 1, 1, 1},
            {1, 1, 1, 1},
            {1, 1, 1, 1},
        };
        int[,] submatrix = new int[,] {
            {1, 1, 1},
            {1, 1, 1},
        };

        int occurrences = Question2.CalculateOccurrences(matrix, submatrix);

        Assert.Equal(4, occurrences);
    }

    [Fact]
    public void CalculateOccurrences_Matrix4x3_ReturnsAllOccurrences()
    {
        int[,] matrix = new int[,] {
            {1, 2, 1},
            {3, 4, 1},
            {1, 1, 2},
            {1, 1, 2}
        };
        int[,] submatrix = new int[,] {
            {1, 2}
        };

        int occurrences = Question2.CalculateOccurrences(matrix, submatrix);

        Assert.Equal(3, occurrences);
    }

    [Fact]
    public void CalculateOccurrences_SubmatrixRowsBigger_ThrowsException()
    {
        int[,] matrix = new int[,] {
            {1, 2, 1},
            {3, 4, 1},
            {1, 1, 2},
            {1, 1, 2}
        };
        int[,] submatrix = new int[,] {
            {1, 2, 3, 4, 5}
        };

        Action action = () => Question2.CalculateOccurrences(matrix, submatrix);

        var exception = Record.Exception(action);

        Assert.NotNull(exception);
        Assert.IsType<ArgumentException>(exception);
    }

    
    [Fact]
    public void CalculateOccurrences_SubmatrixColumnsBigger_ThrowsException()
    {
        int[,] matrix = new int[,] {
            {1, 2, 1},
            {3, 4, 1},
        };
        int[,] submatrix = new int[,] {
            {1, 2},
            {1, 2},
            {1, 2},
            {1, 2},
            {1, 2},
        };

        Action action = () => Question2.CalculateOccurrences(matrix, submatrix);

        var exception = Record.Exception(action);

        Assert.NotNull(exception);
        Assert.IsType<ArgumentException>(exception);
    }
}
