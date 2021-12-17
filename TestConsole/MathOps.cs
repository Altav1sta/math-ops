using TestConsole.GreatestCommonDivisor;

namespace TestConsole
{
    public static class MathOps
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            IGCDAlgorithm algorithm = new BinaryAlgorithm();
            //IGCDAlgorithm algorithm = new EuclideanAlgorithm();

            return algorithm.FindGreatestCommonDivisor(a, b);
        }
    }
}
