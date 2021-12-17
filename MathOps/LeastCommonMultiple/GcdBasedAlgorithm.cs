using MathOps.GreatestCommonDivisor;

namespace MathOps.LeastCommonMultiple
{
    internal class GCDBasedAlgorithm : ILcmAlgorithm
    {
        private readonly IGcdAlgorithm _gcdAlgorithm;

        public GCDBasedAlgorithm(IGcdAlgorithm gcdAlgorithm)
        {
            _gcdAlgorithm = gcdAlgorithm;
        }

        public int FindLeastCommonMultiple(int a, int b)
        {
            var gcd = _gcdAlgorithm.FindGreatestCommonDivisor(a, b);

            return Math.Abs(a / gcd * b);
        }
    }
}
