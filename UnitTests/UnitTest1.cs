using ProblemPlecakowy;

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
                new Item(0, 10, 1),
                new Item(0, 10, 1),
                new Item(0, 10, 1),
                new Item(0, 10, 1)
            };

            Problem obj = new Problem(N, 1);

            obj.Items = arr;

            Assert.IsFalse(obj.Solve(cap).ItemsID.Any());

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

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"{i} Result 1 :{problem1.Items[i]}");
            //    Console.WriteLine($"{i} Result 2 :{problem2.Items[i]}");
            //}
            CollectionAssert.AreEqual(result1.ItemsID, result2.ItemsID);

        }
    }

}