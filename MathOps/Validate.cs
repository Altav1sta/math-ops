namespace MathOps
{
    internal static class Validate
    {
        public static void GreaterThan(string parameterName, int parameterValue, int boundary)
        {
            if (parameterValue <= boundary)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName, 
                    parameterValue, 
                    $"Value should be greater than {boundary}");
            }
        }

        public static void LessThan(string parameterName, int parameterValue, int boundary)
        {
            if (parameterValue >= boundary)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName,
                    parameterValue,
                    $"Value should be greater than {boundary}");
            }
        }

        public static void Positive(string parameterName, int parameterValue)
        {
            if (parameterValue <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName, 
                    parameterValue, 
                    $"Value should be positive");
            }
        }

        public static void NonPositive(string parameterName, int parameterValue)
        {
            if (parameterValue > 0)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName,
                    parameterValue,
                    $"Value should be non-positive");
            }
        }

        public static void Negative(string parameterName, int parameterValue)
        {
            if (parameterValue >= 0)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName,
                    parameterValue,
                    $"Value should be negative");
            }
        }

        public static void NonNegative(string parameterName, int parameterValue)
        {
            if (parameterValue < 0)
            {
                throw new ArgumentOutOfRangeException(
                    parameterName,
                    parameterValue,
                    $"Value should be non-negative");
            }
        }
    }
}
