namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            if (i < -3)
            {
                return i;
            }
            else if (i >= -3 && i < 0)
            {
                return i + (2 * i);
            }
            else if (i > 0 && i <= 3)
            {
                return i - (i * i);
            }
            else if (i > 3)
            {
                return i;
            }
            else
            {
                return 0;
            }
        }
    }
}
