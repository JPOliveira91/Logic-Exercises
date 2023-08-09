using Lib.ProblemSolving.Test02.Challenge7;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge7Test
{
    [Fact]
    public void TestCase01()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 0, 0, 3, 4, 5 });
        Assert.Equal(new List<int> { 0 }, value);
    }

    [Fact]
    public void TestCase02()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 5, 4, 3, 2, 1 });
        Assert.Equal(new List<int> { }, value);
    }

    [Fact]
    public void TestCase03()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 9, 2, 2, 2, 5, 5, 5, 1, 8, 7 });
        Assert.Equal(new List<int> { 2, 5 }, value);
    }

    [Fact]
    public void TestCase04()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 5, 5, 4, 4, 3, 3, 2, 2, 1, 1 });
        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, value);
    }

    [Fact]
    public void TestCase05()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { });
        Assert.Null(value);
    }

    [Fact]
    public void TestCase06()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { -1, 2, 3, 4, 5, 5, 6, 7, 8, 9 });
        Assert.Null(value);
    }

    [Fact]
    public void TestCase07()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 1, 8, 3, 4, 5, 5, 6, 7, 2, 9 });
        Assert.Equal(new List<int> { 5 }, value);
    }

    [Fact]
    public void TestCase08()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 1, 1, 10 });
        Assert.Equal(new List<int> { 1 }, value);
    }

    [Fact]
    public void TestCase09()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 1 });
        Assert.Equal(new List<int> { }, value);
    }

    [Fact]
    public void TestCase10()
    {
        var value = Challenge7.RetrieveMode(new List<int>() { 1, 10, 10 });
        Assert.Equal(new List<int> { 10 }, value);
    }
}