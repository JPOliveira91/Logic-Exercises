using Lib.ProblemSolving.Test03.Challenge11;

namespace Lib.ProblemSolving.UnitTest.Test03;

public class Challenge11Test
{
    [Fact]
    public void TestCase01()
    {
        var inputArray = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', '2', 'b', '2', 'c', '3' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase02()
    {
        var inputArray = new char[] { 'a' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase03()
    {
        var inputArray = new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', 'b', '1', '2' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase04()
    {
        var inputArray = new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c', 'a', 'a', 'a' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', '2', 'b', '2', 'c', '3', 'a', '3' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase05()
    {
        var inputArray = new char[] { };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { };

        Assert.Equal(expectedResult, result);

    }

    [Fact]
    public void TestCase06()
    {
        var inputArray = new char[] { 'a', 'a', 'b', 'b', 'c', 'a', 'a', 'a' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', '2', 'b', '2', 'c', 'a', '3' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase07()
    {
        var inputArray = new char[] { 'a', 'a', 'b', 'b', 'c' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', '2', 'b', '2', 'c' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase08()
    {
        var inputArray = new char[] { 'a', 'b', 'b', 'c' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', 'b', '2', 'c' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase09()
    {
        var inputArray = new char[] { 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', '1', '2', 'b', '1', '2', 'c', '1', '2' };

        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void TestCase10()
    {
        var inputArray = new char[] { 'a', 'a', 'a', 'd', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'e', 'b', 'b', 'b', 'b', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'f', 'c' };
        var result = Challenge11.RetrieveValue(inputArray);

        var expectedResult = new char[] { 'a', '3', 'd', 'a', '8', 'b', '7', 'e', 'b', '4', 'c', '1', '0', 'f', 'c' };

        Assert.Equal(expectedResult, result);
    }
}