using System.Drawing;

namespace Lib.ProblemSolving.Test03.Challenge11;

public class Challenge11
{
    public static char[] RetrieveValue(char[] inputArray)
    {
        List<char> resultList = new List<char>() { };
        char lastChar = inputArray[0];
        int count = 0;

        foreach (var charactere in inputArray)
        {
            if (lastChar == charactere)
            {
                // Improve consecutive count
                count++;
            }
            else
            {
                // Add existing consecutive char
                AddConsecutiveNumberIntoResultArray(ref resultList, lastChar, count);

                // Reset consecutive check
                lastChar = charactere;
                count = 1;
            }
        }

        // Add last char
        AddConsecutiveNumberIntoResultArray(ref resultList, lastChar, count);

        return resultList.ToArray();
    }

    private static void AddConsecutiveNumberIntoResultArray(ref List<char> listToInsert, char charInserted, int countCharInserted)
    {
        listToInsert.Add(charInserted);

        // If char is alone, only add it and ignore the count
        if (countCharInserted == 1) return;

        // Add the count number as a list of chars
        foreach (var singleNumber in GetDigits(countCharInserted))
        {
            listToInsert.Add((char)(singleNumber + 48));
        }
    }

    // Method to transform a number into a List of single Digits
    // 123456 -> { '1', '2', '3', '4', '5', '6', }
    private static IEnumerable<int> GetDigits(int source)
    {
        Stack<int> digits = new Stack<int>();
        while (source > 0)
        {
            var digit = source % 10;
            source /= 10;
            digits.Push(digit);
        }

        return digits;
    }
}