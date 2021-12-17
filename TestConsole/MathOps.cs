using TestConsole.GreatestCommonDivisor;

namespace TestConsole
{
    public static class MathOps
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            IGCDSearchAlgorithm algorithm = new EuclideanAlgorithm();

            return algorithm.FindGreatestCommonDivisor(a, b);
        }
    }
}
