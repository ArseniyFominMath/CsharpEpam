namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0, i = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint firstTerm = 13;
            const uint commonRatio = 3;

            uint sum = 0, i = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= commonRatio;
                    j++;
                }

                sum += firstTerm * rpow;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint i = 0, term = a;
            while (term <= maxTerm)
            {
                i++;
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                term = a * rpow;
            }

            return i;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint term, i = 0, count = 0;
            while (i < n)
            {
                uint j = 0, rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                term = a * rpow;
                if (term >= minTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }
    }
}
