namespace WhilePractice
{
    public static class Task6
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1, one = -1;
            while (i <= n)
            {
                sum += one / ((2 * i) + 1);
                i++;
                one *= -1;
            }

            return sum;
        }
    }
}
