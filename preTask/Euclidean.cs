using System;
using System.Collections.Generic;
using System.Text;

namespace preTask
{
    class Euclidean
    {
        public int FindGDC(int first, int second)
        {
            while (first != second)
                if (first != second)
                    first -= second;
                else
                    second -= first;

            return first;
        }

        public int FindGDC(int first, int second, int third)
        {
            var result = FindGDC(first, second);
            return FindGDC(result, third);
        }

        public int FindGDC(int first, int second, int third, int fourth)
        {
            var result = FindGDC(first, second, third);
            return FindGDC(result, fourth);
        }

        public int FindGDC(int first, int second, int third, int fourth, int fifth)
        {
            var result = FindGDC(first, second, third, fourth);
            return FindGDC(result, fifth);
        }
    }
}
