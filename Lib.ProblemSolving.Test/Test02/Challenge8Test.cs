using Lib.ProblemSolving.Test02.Challenge8;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge8Test
{
    [Fact]
    public void TestCase01()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 42 }
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 10 }
        };

        var resultExpected = new List<List<int>>()
        {
            new List<int> { 420 }
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Equal(resultExpected, value);
    }

    [Fact]
    public void TestCase02()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2 }
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 3, 4 }
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Null(value);
    }

    [Fact]
    public void TestCase03()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2 }
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 3, 4, 30, 40 },
            new List<int> { 5, 6, 50, 60 },
            new List<int> { 7, 8, 70, 80 }

        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Null(value);
    }

    [Fact]
    public void TestCase04()
    {
        var matrixA = new List<List<int>>()
        {
            null,
            new List<int> { 1, 2 }
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 1, 2 },
            null
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Null(value);
    }

    [Fact]
    public void TestCase05()
    {
        var value = Challenge8.MutiplyMatrix(null, null);

        Assert.Null(value);
    }

    [Fact]
    public void TestCase06()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2 },
            null
        };

        var matrixB = new List<List<int>>()
        {
            null,
            new List<int> { 1, 2 }
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Null(value);
    }

    [Fact]
    public void TestCase07()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 3, 5, 1 },
            new List<int> { 1, 7, 2 },
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 1, 3 },
            new List<int> { 2, 4 },
            new List<int> { 1, 1 }
        };

        var resultExpected = new List<List<int>>()
        {
            new List<int> { 14, 30 },
            new List<int> { 17, 33 },
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Equal(resultExpected, value);
    }

    [Fact]
    public void TestCase08()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 1 },
            new List<int> { 2 },
            new List<int> { 3 },
            new List<int> { 4 },
            new List<int> { 5 },
            new List<int> { 6 },
            new List<int> { 7 },
            new List<int> { 8 },
            new List<int> { 9 },
            new List<int> { 10 },
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 11, 12 }
        };

        var resultExpected = new List<List<int>>()
        {
            new List<int> { 11, 12 },
            new List<int> { 22, 24 },
            new List<int> { 33, 36 },
            new List<int> { 44, 48 },
            new List<int> { 55, 60 },
            new List<int> { 66, 72 },
            new List<int> { 77, 84 },
            new List<int> { 88, 96 },
            new List<int> { 99, 108 },
            new List<int> { 110, 120 },
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Equal(resultExpected, value);
    }

    [Fact]
    public void TestCase09()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 9, 8, 7 },
            new List<int> { 6, 5, 4 },
            new List<int> { 3, 2, 1 }
        };

        var resultExpected = new List<List<int>>()
        {
            new List<int> { 30, 24, 18 },
            new List<int> { 84, 69, 54 },
            new List<int> { 138, 114, 90 }
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Equal(resultExpected, value);
    }

    [Fact]
    public void TestCase10()
    {
        var matrixA = new List<List<int>>()
        {
            new List<int> { 4, 53, 1, 546, 49 },
            new List<int> { 9, 4, 541, 84, 4 },
            new List<int> { 7, 4109, 809, 4, 984 },
            new List<int> { 98, 409, 540, 984, 95 },
            new List<int> { 8, 70, 5768, 30, 7 },
        };

        var matrixB = new List<List<int>>()
        {
            new List<int> { 109, 9, 840, 10654, 0 },
            new List<int> { 3, 54, 8, 0, 80 },
            new List<int> { 4, 40, 0, 1, 9 },
            new List<int> { 80, 8, 84, 0, 80 },
            new List<int> { 40, 8, 8, 4, 8 },
        };

        var resultExpected = new List<List<int>>()
        {
            new List<int> { 46239, 7698, 50040, 42813, 48321 },
            new List<int> { 10037, 22641, 14680, 96443, 11941 },
            new List<int> { 56006, 262213, 46960, 79323, 344193 },
            new List<int> { 96589, 53200, 169008, 1045012, 117060 },
            new List<int> { 26834, 234868, 9856, 91028, 59968 },
        };

        var value = Challenge8.MutiplyMatrix(matrixA, matrixB);

        Assert.Equal(resultExpected, value);
    }
}