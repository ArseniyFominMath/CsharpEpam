namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            bool result = true;
            uint i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    result = false;
                }

                i++;
            }

            if (n > 1)
            {
                return result;
            }
            else
            {
                return false;
            }
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint i = 2, number = 0;
            while (i <= n)
            {
                bool flag = true;
                uint j = 2;
                while (j < i)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }

                    j++;
                }

                if (flag)
                {
                    number = i;
                }

                i++;
            }

            if (n > 1)
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint i = n, sum = 0;
            while (i > 1 && count > 0)
            {
                bool flag = true;
                uint j = 2;
                while (j < i)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }

                    j++;
                }

                if (flag)
                {
                    sum += i;
                    count--;
                }

                i--;
            }

            if (n > 1)
            {
                return sum;
            }
            else
            {
                return 0;
            }
        }
    }
}
