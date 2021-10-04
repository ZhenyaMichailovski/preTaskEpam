using NUnit.Framework;
using preTask;

namespace Tests
{
    public class Tests
    {
        [Test]
        [TestCase(1568, 1352, 8)]
        [TestCase(999, 666, 333)]
        [TestCase(1, 1, 1)]
        public void TestEuclideanMethodWithTwoParam(int first, int second, int answer)
        {
            Euclidean euclidean = new Euclidean();
            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var result = euclidean.FindGDC(first, second, ref startTimeForEuclid);
            Assert.AreEqual(answer, result);
        }

        [Test]
        [TestCase(1542, 734, 1642, 2)]
        [TestCase(120, 90, 30, 30)]
        [TestCase(1, 1, 1, 1)]
        public void TestEuclideanMethodWithThreeParam(int first, int second, int third, int answer)
        {
            Euclidean euclidean = new Euclidean();
            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var result = euclidean.FindGDC(first, second, third, ref startTimeForEuclid);
            Assert.AreEqual(answer, result);
        }

        [Test]
        [TestCase(1542, 734, 1642, 564, 2)]
        [TestCase(120, 90, 60, 30, 30)]
        [TestCase(1, 1, 1, 1, 1)]
        public void TestEuclideanMethodWithFourthParam(int first, int second, int third, int fourth, int answer)
        {
            Euclidean euclidean = new Euclidean();
            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var result = euclidean.FindGDC(first, second, third, fourth, ref startTimeForEuclid);
            Assert.AreEqual(answer, result);
        }

        [Test]
        [TestCase(1542, 734, 1642, 564, 458, 2)]
        [TestCase(120, 90, 60, 30, 45, 15)]
        [TestCase(1, 1, 1, 1, 1, 1)]
        public void TestEuclideanMethodWithFifthParam(int first, int second, int third, int fourth, int fifth, int answer)
        {
            Euclidean euclidean = new Euclidean();
            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var result = euclidean.FindGDC(first, second, third, fourth, fifth, ref startTimeForEuclid);
            Assert.AreEqual(answer, result);
        }

        [Test]
        [TestCase(1568, 1352, 8)]
        [TestCase(999, 666, 333)]
        [TestCase(1, 1, 1)]
        public void TestSteinMethodWithTwoParam(int first, int second, int answer)
        {
            Euclidean euclidean = new Euclidean();
            var startTimeForEuclid = System.Diagnostics.Stopwatch.StartNew();
            var result = euclidean.FindGDC(first, second, ref startTimeForEuclid);
            Assert.AreEqual(answer, result);
        }
    }
}