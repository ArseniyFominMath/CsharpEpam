namespace WhilePractice
{
    public static class Task2
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1, one = 1;
            while (i <= n)
            {
                sum += one / (i * (i + 1));
                i++;
                one *= -1;
            }

            return sum;
        }
    }
}
