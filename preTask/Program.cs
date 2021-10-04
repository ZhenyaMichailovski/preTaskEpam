using System;

namespace preTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Euclidean euclidean = new Euclidean();
            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var items = euclidean.FindGDC(1568, 1352, ref startTimeForEuclid);
            
           
        }
    }
}
