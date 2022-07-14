namespace WhilePractice
{
    public static class Task5
    {
        public static double GetSequenceProduct(int n)
        {
            double prod = 1, i = 1;
            while (i <= n)
            {
                prod *= 1.0 + (1 / (i * i));
                i++;
            }

            return prod;
        }
    }
}
