namespace TestConsole.GreatestCommonDivisor
{
    /// <summary>
    /// <see href="https://en.wikipedia.org/wiki/Euclidean_algorithm"/>
    /// </summary>
    internal class EuclideanAlgorithm : IGCDSearchAlgorithm
    {
        public int FindGreatestCommonDivisor(int a, int b)
        {
            Validate.GreaterThan(nameof(a), a, 0);
            Validate.GreaterThan(nameof(b), b, 0);

            if (a < b) Swap(ref a, ref b);

            var remainder2StepsAgo = a;
            var remainder1StepAgo = b;

            for (var step = 0; ; step++)
            {
                var quotient = remainder2StepsAgo / remainder1StepAgo;
                var remainder = remainder2StepsAgo % remainder1StepAgo;

                if (remainder > 0)
                {
                    remainder2StepsAgo = remainder1StepAgo;
                    remainder1StepAgo = remainder;
                }
                else
                {
                    return quotient;
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}
