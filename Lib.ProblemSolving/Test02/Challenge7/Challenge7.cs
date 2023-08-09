namespace Lib.ProblemSolving.Test02.Challenge7;

public static class Challenge7
{
    public static List<int>? RetrieveMode(List<int> studentAges)
    {
        if (!studentAges.Any() || studentAges.Any(num => num < 0)) return null;

        var modeList = new List<int>();
        var modeCheck = new Dictionary<int, int>();

        foreach (var age in studentAges)
        {
            if (!modeCheck.ContainsKey(age))
            {
                modeCheck.Add(age, 1);
            }
            else
            {
                modeCheck[age]++;
            }
        }

        var maxOcurrences = modeCheck.Values.Max();

        if (maxOcurrences > 1) modeCheck.Where(item => item.Value.Equals(maxOcurrences)).OrderBy(item => item.Key).ToList().ForEach(item => modeList.Add(item.Key));

        return modeList;
    }
}