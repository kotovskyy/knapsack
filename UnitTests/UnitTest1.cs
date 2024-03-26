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


    }
}