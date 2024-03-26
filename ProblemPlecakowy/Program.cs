using System.Runtime.CompilerServices;

namespace ProblemPlecakowy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Enter the capacity: ");
            int cap = int.Parse(Console.ReadLine());

            Result result = problem.Solve(cap);
            Console.WriteLine(result.ToString());
            //Console.WriteLine(problem.Solve(cap).ToString());
        }
    }
}
