namespace MathOps.GreatestCommonDivisor
{
    /// <summary>
    /// <see href="https://en.wikipedia.org/wiki/Binary_GCD_algorithm"/>
    /// </summary>
    internal class BinaryAlgorithm : IGcdAlgorithm
    {
        public int FindGreatestCommonDivisor(int a, int b)
        {
            Validate.NonNegative(nameof(a), a);
            Validate.NonNegative(nameof(b), b);

            if (a == 0) return b;
            if (b == 0) return a;

            // finding k = greatest power of 2 dividing both a and b
            int k;
            for (k = 0; ((a | b) & 1) == 0; k++)
            {
                a >>= 1;
                b >>= 1;
            }

            // dividing a by 2 until it becomes odd
            while ((a & 1) == 0) a >>= 1;

            do
            {
                // dividing b by 2 until it becomes odd
                while ((b & 1) == 0) b >>= 1;

                if (a > b) Helper.Swap(ref a, ref b);

                // gcd(a, b) = gcd(|a - b|, min(a, b)) <-- if a and b are both odd
                b -= a;
            }
            while (b != 0);

            return a << k;
        }
    }
}
