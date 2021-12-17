using MathOps.GreatestCommonDivisor;
using MathOps.LeastCommonMultiple;

namespace MathOps
{
    public static class ComputationalOps
    {
        private static readonly IGcdAlgorithm _gcdAlgorithm;
        private static readonly ILcmAlgorithm _lcmAlgorithm;

        static ComputationalOps()
        {
            _gcdAlgorithm = new BinaryAlgorithm();
            _lcmAlgorithm = new GCDBasedAlgorithm(_gcdAlgorithm);
        }

        public static int GreatestCommonDivisor(int a, int b)
        {
            return _gcdAlgorithm.FindGreatestCommonDivisor(a, b);
        }

        public static int LeastCommonMultiple(int a, int b)
        {
            return _lcmAlgorithm.FindLeastCommonMultiple(a, b);
        }
    }
}
