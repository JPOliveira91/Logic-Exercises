using Lib.ProblemSolving.Test02.Challenge6;

namespace Lib.ProblemSolving.UnitTest.Test02;

public class Challenge6Test
{
    [Fact]
    public void TestCase01()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(1);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase02()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(2);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 3, 4, 5, 6, 7, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase03()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(3);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 4, 5, 6, 7, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase04()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(4);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase05()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(5);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase06()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(6);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 3, 4, 5, 7, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase07()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(7);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 3, 4, 5, 6, 8, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase08()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(8);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 9, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase09()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        challenge6.Remove(9);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    [Fact]
    public void TestCase10()
    {
        var challenge6 = new Challenge6();
        challenge6.PopulateList(new List<int> { 11, 22, 33, 44, 55, 66, 77, 88, 99 });
        challenge6.Remove(99);
        var existing = challenge6.LinkedItens;
        var expected = CreateLinkedList(new List<int> { 11, 22, 33, 44, 55, 66, 77, 88 });
        Assert.True(CompareLinkedLists(existing, expected));
    }

    #region Helper
    private bool CompareLinkedLists(List<LinkedItem> result, List<LinkedItem> expected)
    {
        if (result.Count != expected.Count) return false;

        for (int index = 0; index < result.Count; index++)
        {
            if (result[index].Value != expected[index].Value) return false;
            if (result[index].Behind?.Value != expected[index].Behind?.Value) return false;
        }

        return true;
    }

    private List<LinkedItem> CreateLinkedList(List<int> numberList)
    {
        var linkedList = new List<LinkedItem>();

        foreach (var number in numberList.OrderByDescending(num => num))
        {
            var newLinkedItem = new LinkedItem() { Value = number };

            if (!linkedList.Any())
            {
                linkedList.Add(newLinkedItem);
            }
            else
            {
                var firstLinkedItem = linkedList.First();
                newLinkedItem.Behind = firstLinkedItem;

                linkedList.Insert(0, newLinkedItem);
            }
        }

        return linkedList;
    }
    #endregion
}