namespace Lib.ProblemSolving.Test02.Challenge5;

public static class Challenge5
{
    public static int RecursiveFactorial(int number)
    {
        int factorialOfNumber = 1;

        while (number > 0)
        {
            factorialOfNumber *= number;
            number--;
        }

        return factorialOfNumber;
    }
}