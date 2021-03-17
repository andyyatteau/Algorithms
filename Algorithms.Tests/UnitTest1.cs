using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinarySearchTest1()
        {
            int target = 6;
            int[] arr = { 1, 3, 5, 6, 8, 11, 15, 20 };
            Assert.IsTrue(Search.BinarySearch(target, arr));
        }

        [TestMethod]
        public void BinarySearchTest2()
        {
            int target = 1;
            int[] arr = { 1, 3, 5, 6, 8, 11, 15, 20 };
            Assert.IsTrue(Search.BinarySearch(target, arr));
        }

        [TestMethod]
        public void BinarySearchTest3()
        {
            int target = 15;
            int[] arr = { 1, 3, 5, 6, 8, 11, 15, 20 };
            Assert.IsTrue(Search.BinarySearch(target, arr));
        }

        [TestMethod]
        public void BinarySearchTest4()
        {
            int target = 0;
            int[] arr = { 1, 3, 5, 6, 8, 11, 15, 20 };
            Assert.IsFalse(Search.BinarySearch(target, arr));
        }
    }
}
