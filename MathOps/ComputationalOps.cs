using MathOps.GreatestCommonDivisor;

namespace MathOps
{
    public static class ComputationalOps
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            IGCDAlgorithm algorithm = new BinaryAlgorithm();
            //IGCDAlgorithm algorithm = new EuclideanAlgorithm();

            return algorithm.FindGreatestCommonDivisor(a, b);
        }
    }
}
