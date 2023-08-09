namespace Lib.ProblemSolving.Test02.Challenge8;

public static class Challenge8
{
    public static List<List<int>>? MutiplyMatrix(List<List<int>> matrixA, List<List<int>> matrixB)
    {
        // Check if any matrix is null
        if (matrixA == null || matrixB == null) return null;
        // Check if any row in a matrix is null
        if (matrixA.Any(row => row == null) || matrixB.Any(row => row == null)) return null;
        // Check if any matrix is empty
        if (matrixA.Count == 0 || matrixB.Count == 0) return null;
        // Check if both matrix are able to multiply
        if (matrixA.First().Count != matrixB.Count) return null;

        List<List<int>> result = new List<List<int>>();

        for (var matrixALineMultiplied = 0; matrixALineMultiplied < matrixA.Count; matrixALineMultiplied++)
        {
            result.Add(new List<int>());

            for (var matrixBColumnMultiplied = 0; matrixBColumnMultiplied < matrixB.First().Count; matrixBColumnMultiplied++)
            {
                var valueToAdd = 0;

                for (var matrixBLineMultiplied = 0; matrixBLineMultiplied < matrixB.Count; matrixBLineMultiplied++)
                {
                    valueToAdd += matrixA[matrixALineMultiplied][matrixBLineMultiplied] * matrixB[matrixBLineMultiplied][matrixBColumnMultiplied];
                }

                result.Last().Add(valueToAdd);
            }
        }

        return result;
    }
}