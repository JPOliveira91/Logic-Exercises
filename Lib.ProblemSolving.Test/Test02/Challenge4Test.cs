using Lib.ProblemSolving.Test02.Challenge4;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge4Test
{
    [Fact]
    public void TestCase01()
    {
        var value = Challenge4.InvertList(new List<int>() { 1, 2, 3, 4, 5 });
        Assert.Equal(new List<int>() { 5, 4, 3, 2, 1 }, value);
    }

    [Fact]
    public void TestCase02()
    {
        var value = Challenge4.InvertList(new List<int>() { 5, 4, 3, 2, 1 });
        Assert.Equal(new List<int>() { 1, 2, 3, 4, 5 }, value);
    }

    [Fact]
    public void TestCase03()
    {
        var value = Challenge4.InvertList(new List<int>() { 1, 1, 1, 1, 1 });
        Assert.Equal(new List<int>() { 1, 1, 1, 1, 1 }, value);
    }

    [Fact]
    public void TestCase04()
    {
        var value = Challenge4.InvertList(new List<int>() { 1, 3, 2, 4, 5 });
        Assert.Equal(new List<int>() { 5, 4, 2, 3, 1 }, value);
    }

    [Fact]
    public void TestCase05()
    {
        var value = Challenge4.InvertList(new List<int>() { 6, 8, 9, 10, 7, 1, 3, 2, 4, 5 });
        Assert.Equal(new List<int>() { 5, 4, 2, 3, 1, 7, 10, 9, 8, 6 }, value);
    }

    [Fact]
    public void TestCase06()
    {
        var value = Challenge4.InvertList(new List<int>() { -96, -4, -62, -7, -53, -14, -24, -10, -99, -34 });
        Assert.Equal(new List<int>() { -34, -99, -10, -24, -14, -53, -7, -62, -4, -96 }, value);
    }

    [Fact]
    public void TestCase07()
    {
        var value = Challenge4.InvertList(new List<int>() { 62, 85, 98, 82, -19, -92, -54, 26, -93, 0 });
        Assert.Equal(new List<int>() { 0, -93, 26, -54, -92, -19, 82, 98, 85, 62 }, value);
    }

    [Fact]
    public void TestCase08()
    {
        var value = Challenge4.InvertList(new List<int>() { 1 });
        Assert.Equal(new List<int>() { 1 }, value);
    }

    [Fact]
    public void TestCase09()
    {
        var value = Challenge4.InvertList(new List<int>() { 123456 });
        Assert.Equal(new List<int>() { 123456 }, value);
    }

    [Fact]
    public void TestCase10()
    {
        var value = Challenge4.InvertList(new List<int>() { });
        Assert.Equal(new List<int>() { }, value);
    }
}