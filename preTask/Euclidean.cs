using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace preTask
{
    public class Euclidean
    {
        public int FindGDC(int first, int second, ref Stopwatch startTime)
        {
            try
            {
                while (first != second)
                    if (first > second)
                        first -= second;
                    else
                        second -= first;

                return first;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public int FindGDC(int first, int second, int third, ref Stopwatch startTime)
        {
            var result = FindGDC(first, second, ref startTime);
            return FindGDC(result, third, ref startTime);
        }

        public int FindGDC(int first, int second, int third, int fourth, ref Stopwatch startTime)
        {
            var result = FindGDC(first, second, third, ref startTime);
            return FindGDC(result, fourth, ref startTime);
        }

        public int FindGDC(int first, int second, int third, int fourth, int fifth, ref Stopwatch startTime)
        {
            var result = FindGDC(first, second, third, fourth, ref startTime);
            return FindGDC(result, fifth, ref startTime);
        }

        public int FindGDCByStein(int first, int second, ref Stopwatch startTime)
        {
            try
            {
                if (first == 0) return second;
                if (second == 0) return first;
                if (first == second) return first;

                bool val1IsEven = (first & 1u) == 0;
                bool val2IsEven = (first & 1u) == 0;

                if (val1IsEven && val2IsEven)
                    return FindGDCByStein(first >> 1, second >> 1, ref startTime) << 1;
                else if (val1IsEven && !val2IsEven)
                    return FindGDCByStein(first >> 1, second, ref startTime);
                else if (val2IsEven)
                    return FindGDCByStein(first, second >> 1, ref startTime);
                else if (first > second)
                    return FindGDCByStein((first - second) >> 1, second, ref startTime);
                else
                    return FindGDCByStein(first, (second - first) >> 1, ref startTime);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public List<(string, TimeSpan)> GetDataForHistogram(int first, int second)
        {
            var startTimeForStein = System.Diagnostics.Stopwatch.StartNew();
            var steinResult = FindGDCByStein(first, second, ref startTimeForStein);
            var resultTimeForStein = startTimeForStein.Elapsed;

            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var euclidianResult = FindGDCByStein(first, second, ref startTimeForEuclid);
            var resultTimeForEuclid = startTimeForEuclid.Elapsed;

            List<(string, TimeSpan)> items = new List<(string, TimeSpan)>();
            items.Add(("Euclidian", resultTimeForStein));
            items.Add(("Stain", resultTimeForEuclid));

            return items;
        }
    }
}
