using ProblemPlecakowy;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace Knapsack_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNoItemFits()
        {
            const int N = 5;
            int cap = 5;

            Item[] arr = new Item[N] {
                new Item(0, 10, 1),
                new Item(1, 10, 1),
                new Item(2, 10, 1),
                new Item(3, 10, 1),
                new Item(4, 10, 1)
            };

            Problem problem = new Problem(N, 1);

            problem.Items = arr;

            Assert.AreEqual(0, problem.Solve(cap).ItemsID.Count);
        }

        [TestMethod]
        public void TestExampleOutput()
        {

            const int N = 5;
            int cap = 15;

            Item[] arr = new Item[N] {
                new Item(0, 4, 9),
                new Item(1, 3, 9),
                new Item(2, 4, 9),
                new Item(3, 8, 5),
                new Item(4, 6, 3)
            };

            Problem problem = new Problem(N, 1);

            problem.Items = arr;

            var actual = problem.Solve(cap).ItemsID;

            List<int> expected = new List<int> {1, 0, 2};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestItemsOrder()
        {
            const int N = 4;
            int cap = 10;

            Item[] arr1 = new Item[N]
            {
                new Item(0, 3, 5),
                new Item(1, 4, 6),
                new Item(2, 5, 7),
                new Item(3, 6, 8)
            };

            Item[] arr2 = new Item[N]
            {
                new Item(3, 6, 8),
                new Item(1, 4, 6),
                new Item(0, 3, 5),
                new Item(2, 5, 7)
            };

            Problem problem1 = new Problem(N, 1);
            Problem problem2 = new Problem(N, 1);
            problem1.Items = arr1;
            problem2.Items = arr2;
            Result result1 = problem1.Solve(cap);
            Result result2 = problem2.Solve(cap);

            CollectionAssert.AreEqual(result1.ItemsID, result2.ItemsID);

        }

        [TestMethod]
        public void TestAtLeastOne()
        {

            const int N = 5;
            int cap = 15;

            Item[] arr = new Item[N] {
                new Item(0, 4, 9),
                new Item(1, 3, 5),
                new Item(2, 4, 12),
                new Item(3, 8, 16),
                new Item(4, 6, 15)
            };

            Problem problem = new Problem(N, 1);

            problem.Items = arr;

            var actual = problem.Solve(cap).ItemsID;

            Assert.IsTrue(actual.Count >= 1);
        }


        [TestMethod]
        public void TestUniqueResults()
        {
            const int N = 5;
            int cap = 15;

            Item[] arr = new Item[N] {
                new Item(0, 4, 9),
                new Item(1, 3, 5),
                new Item(2, 4, 12),
                new Item(3, 8, 16),
                new Item(4, 6, 15)
            };

            Problem problem = new Problem(N, 1);

            problem.Items = arr;

            var result = problem.Solve(cap);
            int expected = result.ItemsID.Count;
            int actual = result.ItemsID.Distinct().Count();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberOfItems()
        {
            const int N = 7;

            Problem problem = new Problem(N, 42);
            int items_num = problem.Items.Length;

            Assert.AreEqual(N, items_num);

        }

        [TestMethod]
        public void TestZeroItemsPassed()
        {
            const int N = 0;
            int cap = 15;

            Problem problem = new Problem(N, 1);

            var result = problem.Solve(cap);

            int expectedW = 0;
            int expectedV = 0;
            int expectedLen = 0;
            Assert.AreEqual(expectedLen, result.ItemsID.Count);
            Assert.AreEqual(expectedW, result.TotalW);
            Assert.AreEqual(expectedV, result.TotalV);
        }

        [TestMethod]
        public void TestNegativeItemsNumber()
        {
            const int N = -7;
            int cap = 20;
            Problem problem = new Problem(N, 42);

            var result = problem.Solve(cap);

            Assert.AreEqual(0, result.TotalV);
            Assert.AreEqual(0, result.TotalW);
        }
    }

}