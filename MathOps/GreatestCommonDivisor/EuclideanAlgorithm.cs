namespace MathOps.GreatestCommonDivisor
{
    /// <summary>
    /// <see href="https://en.wikipedia.org/wiki/Euclidean_algorithm"/>
    /// </summary>
    internal class EuclideanAlgorithm : IGcdAlgorithm
    {
        public int FindGreatestCommonDivisor(int a, int b)
        {
            Validate.Positive(nameof(a), a);
            Validate.Positive(nameof(b), b);

            if (a < b) Helper.Swap(ref a, ref b);

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
    }
}
