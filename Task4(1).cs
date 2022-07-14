namespace IfStatements
{
    public static class Task4
    {
        public static int DoSomething(bool b1, bool b2, bool b3, bool b4)
        {
            int result = 0;

            if ((b2 || !b3) && b4 && b1)
            {
                result = 1;
            }
            else if (b1 && (b2 || !b3) && !b4)
            {
                result = 2;
            }
            else if (b1 && !b2 && b3 && !b4)
            {
                result = 3;
            }
            else if (b1 && !b2 && b3 && b4)
            {
                result = 4;
            }
            else if (!b1 && !b3 && (b2 || !b4))
            {
                result = 5;
            }
            else if (!b1 && b3 && (b2 || !b4))
            {
                result = 6;
            }
            else if (!b1 && !b2 && b3 && b4)
            {
                result = 7;
            }
            else if (!b1 && !b2 && !b3 && b4)
            {
                result = 8;
            }

            return result;
        }
    }
}
