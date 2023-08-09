using Lib.ProblemSolving.Test02.Challenge5;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge5Test
{
    [Fact]
    public void TestCase01()
    {
        var value = Challenge5.RecursiveFactorial(1);
        Assert.Equal(1, value);
    }

    [Fact]
    public void TestCase02()
    {
        var value = Challenge5.RecursiveFactorial(2);
        Assert.Equal(2, value);
    }

    [Fact]
    public void TestCase03()
    {
        var value = Challenge5.RecursiveFactorial(3);
        Assert.Equal(6, value);
    }

    [Fact]
    public void TestCase04()
    {
        var value = Challenge5.RecursiveFactorial(4);
        Assert.Equal(24, value);
    }

    [Fact]
    public void TestCase05()
    {
        var value = Challenge5.RecursiveFactorial(5);
        Assert.Equal(120, value);
    }

    [Fact]
    public void TestCase06()
    {
        var value = Challenge5.RecursiveFactorial(6);
        Assert.Equal(720, value);
    }

    [Fact]
    public void TestCase07()
    {
        var value = Challenge5.RecursiveFactorial(7);
        Assert.Equal(5040, value);
    }

    [Fact]
    public void TestCase08()
    {
        var value = Challenge5.RecursiveFactorial(8);
        Assert.Equal(40320, value);
    }

    [Fact]
    public void TestCase09()
    {
        var value = Challenge5.RecursiveFactorial(9);
        Assert.Equal(362880, value);
    }

    [Fact]
    public void TestCase10()
    {
        var value = Challenge5.RecursiveFactorial(10);
        Assert.Equal(3628800, value);
    }
}