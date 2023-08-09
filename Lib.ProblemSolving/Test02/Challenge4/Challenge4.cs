namespace Lib.ProblemSolving.Test02.Challenge4;

public static class Challenge4
{
    public static List<int> InvertList(List<int> listNumbers)
    {
        var invertedList = new List<int>();

        for (var currentIndex = listNumbers.Count - 1; currentIndex > -1; currentIndex--)
        {
            invertedList.Add(listNumbers[currentIndex]);
        }

        return invertedList;
    }
}