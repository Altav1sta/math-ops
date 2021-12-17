namespace TestConsole
{
    internal static class Validate
    {
        public static void GreaterThan(string parameterName, int parameterValue, int lowerBound)
        {
            if (parameterValue <= lowerBound)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName, 
                    parameterValue, 
                    $"Value should be greater than {lowerBound}");
            }
        }
    }
}
