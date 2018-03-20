using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RichTeaMan.Maths.Tests
{
    [TestClass]
    public class CalculateMeanTests
    {
        [TestMethod]
        public void CalculateMeanFromDoublesTest()
        {
            var set = new[] { 2.0, 10.0, 3.0, 6.0, 4.0, 6.0, 10.0};

            var expectedMean = 5.8571428571428568;
            
            var mean = set.CalculateMean();

            Assert.AreEqual(expectedMean, mean, double.Epsilon);
        }

        [TestMethod]
        public void CalculateMeanFromIntsTest()
        {
            var set = new[] { 2, 10, 3, 6, 4, 6, 10 };

            var expectedMean = 5.8571428571428568;

            var mean = set.CalculateMean();

            Assert.AreEqual(expectedMean, mean, double.Epsilon);
        }
    }
}
