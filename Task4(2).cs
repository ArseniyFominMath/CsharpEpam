namespace WhilePractice
{
    public static class Task4
    {
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1;
            while (i <= n)
            {
                double odd_num = (2 * i) + 1;
                sum += 1 / (odd_num * odd_num);
                i++;
            }

            return sum;
        }
    }
}
