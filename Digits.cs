namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            const ulong temp = 10;

            ulong sum = 0, div = 0;
            while (n != 0)
            {
                div = n % temp;
                n = n / temp;
                sum += div;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            const ulong temp = 10;

            ulong prod = 1, div = 0;
            if (n == 0)
            {
                prod = 0;
            }

            while (n != 0)
            {
                div = n % temp;
                n = n / temp;
                prod *= div;
            }

            return prod;
        }
    }
}
